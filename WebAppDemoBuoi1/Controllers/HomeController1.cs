using Microsoft.AspNetCore.Mvc;

namespace WebAppDemoBuoi1.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
