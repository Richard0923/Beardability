using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    /// <summary>
    /// Controller for the Home page just being used to return a view.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Routes to the Home Page
        /// </summary>
        /// <returns>Home Page View</returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}