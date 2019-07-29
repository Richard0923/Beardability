using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_Commerce.Models;
using Microsoft.AspNetCore.Identity;
using E_Commerce.Models.ViewModels;
using System.Security.Claims;
using E_Commerce.Data;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace E_Commerce.Pages.Account
{
    /// <summary>
    /// Adds Registration functionallity 
    /// </summary>
    public class RegisterModel : PageModel
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private ECommDbContext _context;
        private IEmailSender _emailSender;

        [BindProperty]
        public RegisterViewModel Input { get; set; }
        public string ReturnUrl { get; set; }

        public RegisterModel(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ECommDbContext context, IEmailSender emailSender )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _emailSender = emailSender;
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        /// <summary>
        /// Registers the user's input if valid and adds any claims and roles associated with that user.
        /// </summary>
        /// <param name="returnUrl"></param>
        /// <returns>Returns user to home page if registration was successfull</returns>
        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if(ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = Input.Email,
                    Email = Input.Email,
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    DOB = Input.DOB,
                    PhoneNumber = Input.PhoneNumber
                };

                var result = await _userManager.CreateAsync(user, Input.Password);

                if(result.Succeeded)
                {
                    Claim fullNameClaim = new Claim("FullName", $"{user.FirstName} {user.LastName}");
                    Claim dobClaim = new Claim(ClaimTypes.DateOfBirth, new DateTime(user.DOB.Year, user.DOB.Month, user.DOB.Day).ToString("u"), ClaimValueTypes.DateTime);
                    Claim emailClaim = new Claim(ClaimTypes.Email, user.Email, ClaimValueTypes.Email);
                    Claim phoneClaim = new Claim(ClaimTypes.MobilePhone, user.PhoneNumber, ClaimValueTypes.String);

                    List<Claim> userClaims = new List<Claim>
                    {
                        fullNameClaim,
                        dobClaim,
                        emailClaim,
                        phoneClaim
                    };

                    ClaimsIdentity claimsIdentity = new ClaimsIdentity();
                        claimsIdentity.AddClaims(userClaims);
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal();
                        claimsPrincipal.AddIdentity(claimsIdentity);

                    await _userManager.AddClaimsAsync(user, userClaims);

                    if(user.Email.ToLower() == "admin@admin.com")
                    {
                        await _userManager.AddToRoleAsync(user, ApplicationRoles.Admin);
                    }

                    await _userManager.AddToRoleAsync(user, ApplicationRoles.Member);

                    await _emailSender.SendEmailAsync(user.Email, "Welcome To BeardsRUs", "<p>Thank you for registering to BeardsRUs</p>");

                    await _signInManager.SignInAsync(user, isPersistent: false);

                    var basket = new E_Commerce.Models.Basket
                    {
                        Email = user.Email
                    };
                    await _context.Baskets.AddAsync(basket);
                    await _context.SaveChangesAsync();

                    return LocalRedirect(returnUrl);
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            return Page();
        }
    }
}