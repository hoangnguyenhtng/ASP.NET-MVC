using Microsoft.AspNetCore.Mvc;

namespace KiemTraDeMau.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
