using Microsoft.AspNetCore.Mvc;

namespace MarketCar.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
