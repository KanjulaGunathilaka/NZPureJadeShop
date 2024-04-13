using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult ContactUs()
        {
            return View("ContactUs");
        }

        public IActionResult AboutUs()
        {
            return View("AboutUs");
        }
    }
}