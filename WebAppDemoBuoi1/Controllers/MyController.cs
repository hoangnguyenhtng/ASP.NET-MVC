
using Microsoft.AspNetCore.Mvc;
using WebAppDemoBuoi1.Models;

namespace WebAppDemoBuoi1.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index(String message, int page)
        {
            //Gửi dữ liệu về View qua ViewBag
            //ViewBag là một vùng bộ nhớ chia sẻ giữa view và action
            //Hoạt động như một Collection
            ViewBag.Message = message;
            ViewBag.Date = DateTime.Now;
            ViewBag.Page = page;
            Message m = new Message(message, page);
            return View(m);
        }

        public IActionResult Add()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Add(Message m)
        {
            ViewBag.Message = m.msg;
            ViewBag.Date = DateTime.Now;
            ViewBag.Page = m.pgnum;
            return View("MyView");
        }
    }
}
