using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SecureEcommerceApp.Controllers
{
    // This lock ONLY allows the Seller badge!
    [Authorize(Roles = "Seller")]
    public class SellerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}