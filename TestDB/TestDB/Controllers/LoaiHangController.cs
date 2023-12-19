using Microsoft.AspNetCore.Mvc;

namespace TestDB.Controllers
{
	public class LoaiHangController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
