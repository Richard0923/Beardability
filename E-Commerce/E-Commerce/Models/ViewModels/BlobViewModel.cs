using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.ViewModels
{
    /// <summary>
    /// View Model for Blob Images
    /// </summary>
    public class BlobViewModel
    {
       [Required]
       public IFormFile Image { get; set; }
    }
}
