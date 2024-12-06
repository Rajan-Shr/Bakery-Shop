using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bakery.Pages
{
    public class AboutModel : PageModel
    {
        public string TimeOfDay = "Evening";
        public void OnGet()
        {
            if(DateTime.Now.Hour < 18)
            {
                TimeOfDay = "Afternoon";
            }else if(DateTime.Now.Hour < 12)
            {
                TimeOfDay = "Morning";
            }
        }
    }
}
