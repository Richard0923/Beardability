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

namespace E_Commerce.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        [BindProperty]
        public RegisterViewModel Input { get; set; }
        public string ReturnUrl { get; set; }

        public RegisterModel(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

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
                    await _signInManager.SignInAsync(user, isPersistent: false);
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