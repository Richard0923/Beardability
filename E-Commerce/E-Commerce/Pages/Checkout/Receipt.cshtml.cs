using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce.Pages.Checkout.Receipt
{
    [Authorize]
    public class ReceiptModel : PageModel
    {
        private readonly IBasket _basket;
        private readonly IEmailSender _emailSender;

        public ReceiptModel(IBasket basket, IEmailSender emailSender)
        {
            _basket = basket;
            _emailSender = emailSender;
        }

        public List<BasketItem> PurchaseItems { get; set; }
        public async Task OnGet()
        {
            PurchaseItems = await _basket.GetAllBasketItems();

            var user = User.Identity.Name;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Greetings {user},");
            stringBuilder.AppendLine("Thank you for your order. Here are the items you purchased:");

            foreach (BasketItem basketItem in PurchaseItems)
            {
                stringBuilder.AppendLine($"{basketItem.Name}, Quantity: {basketItem.Quanity}, Total Price: {basketItem.Price * basketItem.Quanity}");
            }

            stringBuilder.AppendLine("We appreciate your beardness. :{");

            await _emailSender.SendEmailAsync(user, "Purchase Receipt", stringBuilder.ToString());
        }
    }
}