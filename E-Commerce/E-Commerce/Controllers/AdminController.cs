using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    /// <summary>
    /// Controller for the Admin page just being used to return a view
    /// </summary>
    [Authorize(Policy ="AdminOnly")]
    public class AdminController : Controller
    {
        /// <summary>
        ///Routes to the Admin page 
        /// </summary>
        /// <returns>Admin Index Page</returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}