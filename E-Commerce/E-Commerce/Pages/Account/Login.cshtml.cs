﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce.Pages.Account
{
    /// <summary>
    /// Adds login functionallity for user's
    /// </summary>
    public class LoginModel : PageModel
    {
        private SignInManager<ApplicationUser> _signInManager;
        private UserManager<ApplicationUser> _userManager;

        public LoginModel(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [BindProperty]
        public LoginInput Input { get; set; }
        public void OnGet()
        {

        }

        /// <summary>
        /// If the model state is valid it signs the user in and then sends them back to the home page.   
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var inputResult = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, false, false);

                if (inputResult.Succeeded)
                {
                    var user = await _userManager.FindByEmailAsync(Input.Email);
                    if (await _userManager.IsInRoleAsync(user, ApplicationRoles.Admin))
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                    else
                    {
                        //Sends them to the home page
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Your Login Attempt Failed");
                }
            }

            return Page();
        }

        /// <summary>
        /// Nested class for the user's input
        /// </summary>
        public class LoginInput
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }
    }
}