using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NZPureJadeShop.Pages
{
    public class CheckoutCompletePageModel : PageModel
    {
        public void OnGet()
        {
            ViewData["CheckoutCompleteMessage"] = "Thank You for Your Purchase! Your order is confirmed and will be shipped soon. Enjoy your beautiful jade piece!!";
        }
    }
}
