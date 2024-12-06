using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Bakery.Model;
namespace Bakery;

public class BasketViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        Basket basket = new();
        if (Request.Cookies[nameof(basket)] is not null)
        {
            basket = JsonSerializer.Deserialize<Basket>(Request.Cookies[nameof(Basket)]);
        }

        return View(basket);
    }

}
