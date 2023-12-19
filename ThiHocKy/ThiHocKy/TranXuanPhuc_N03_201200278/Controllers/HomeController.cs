using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TranXuanPhuc_N03_201200278.Models;

namespace TranXuanPhuc_N03_201200278.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly QLBanNoiContext _context;

        public HomeController(ILogger<HomeController> logger, QLBanNoiContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.SanPhams.ToList();

            return View(products);
        }

        public IActionResult Details(string id)
        {
            var product = _context.SanPhams.FirstOrDefault(p => p.MaSanPham == id);

            return View(product);
        }

        public IActionResult RemoveProduct(string id)
        {
            var product = _context.SanPhams.FirstOrDefault(p => p.MaSanPham == id);

            if(product != null)
            {
                _context.SanPhams.Remove(product);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}