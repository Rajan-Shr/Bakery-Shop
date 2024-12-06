using Bakery.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using MimeKit;
using MailKit.Net.Smtp;

namespace Bakery.Pages
{
    public class CartModel : PageModel
    {
        private readonly BakeryContext _context;

        public CartModel(BakeryContext context)
        {
           this._context = context;
        }

        public Basket basket = new();
        public List<Product> SelectedItems { get; set; } = new();

        [BindProperty,Required,EmailAddress,Display(Name ="Your Email address")]
        public string CustomerEmail { get; set; }
        [BindProperty,Required,Display(Name ="Your Address")]
        public string CustomerAddress { get; set; }
        [TempData]
        public string Confirmation { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid && Request.Cookies[nameof(Basket)] is not null)
            {
                var basket = JsonSerializer.Deserialize<Basket>(Request.Cookies[nameof(Basket)]);
                if (basket is not null)
                {
                    var plural = basket.NumberOfItems == 1 ? string.Empty : "s";
                    Confirmation = $@"<p>Your order for {basket.NumberOfItems} item{plural} has been received and is being processed:</p>
            <p>It will be sent to {CustomerAddress}. We will notify you when it has been despatched</p>";
                    var message = new MimeMessage();
                    message.From.Add(MailboxAddress.Parse("bakerybliss@gmail.com"));
                    message.To.Add(MailboxAddress.Parse(CustomerEmail));
                    message.Subject = "Your order confirmation";
                    message.Body = new TextPart("html")
                    {
                        Text = Confirmation
                    };
                    using var client = new SmtpClient();
                    await client.ConnectAsync("localhost");
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                    Response.Cookies.Append(nameof(Basket), string.Empty, new CookieOptions { Expires = DateTime.Now.AddDays(-1) });
                    return RedirectToPage("/OrderConfirmation");
                }
            }
            return Page();
        }

        public async Task OnGetAsync()
        {
            if (Request.Cookies[nameof(Basket)] is not null)
            {
                basket = JsonSerializer.Deserialize<Basket> (Request.Cookies[nameof(basket)]);
            
                if(basket.NumberOfItems > 0)
                {
                    var selectedItems = basket.Items.Select(b => b.ProductId).ToList();
                    SelectedItems = await _context.Products.Where(p => selectedItems.Contains(p.Id)).ToListAsync();
                }
            }
        }
    }
}
