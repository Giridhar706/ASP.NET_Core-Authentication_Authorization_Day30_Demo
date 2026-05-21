using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SecureEcommerceApp.Controllers
{
    // Notice there are no specific roles listed here!
    // This lock simply means: "You must be logged in to enter."
    [Authorize]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}