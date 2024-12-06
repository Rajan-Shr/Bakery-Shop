using Bakery.Model;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Pages;
public class OrderModel : PageModel
{
    private readonly BakeryContext _context;

    public OrderModel(BakeryContext context)
    {
        this._context = context;
    }

    [BindProperty(SupportsGet =true)]
    public int Id { get; set; }

    public Product Product { get; set; }

    [BindProperty,Range(1,int.MaxValue,ErrorMessage ="Atleast 1 Product required")]
    public int Quantity { get; set; }

    [BindProperty]
    public decimal UnitPrice { get; set; }
    [TempData]
    public string ConfirmationMessage { get; set; }

    public async Task OnGetAsync(){
        Product = await _context.Products.FindAsync(Id);
    }

    public async Task<IActionResult> OnPostAsync()
    {
        Product = await _context.Products.FindAsync(Id);

        if (ModelState.IsValid)
        {
            //ConfirmationMessage = $@"Your have ordered {Quantity} x {Product.Name} , Your total amount is {Quantity*Product.Price}$.";
            //return RedirectToPage("/OrderConfirmation");

            Basket basket = new();

            if (Request.Cookies[nameof(Basket)] is not null)
            {
                basket = JsonSerializer.Deserialize<Basket>(Request.Cookies[nameof(Basket)]);
            }

            basket.Items.Add(
                new OrderItem
                {
                    ProductId = Id,
                    UnitPrice = UnitPrice,
                    Quantity = Quantity
                });

            var json = JsonSerializer.Serialize(basket);

            var cookieOptions = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(30)
            };
              
            Response.Cookies.Append(nameof(Basket), json, cookieOptions);

            return RedirectToPage("/Index");
        }
        Product = await _context.Products.FindAsync(Id);
        return Page();
    }
}