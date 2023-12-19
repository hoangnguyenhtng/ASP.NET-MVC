using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Drawing.Printing;
using TestDB.Models;

namespace TestDB.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;


		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}
		private int pageSize = 4;

		public IActionResult Index(int? id)
		{
			QLHangHoaContext db = new QLHangHoaContext();
			var hanghoa = (IQueryable<HangHoa>)db.HangHoas.Include(l => l.MaLoaiNavigation).Where(p => p.Gia >= 100);
			if (id != null)
			{
				hanghoa = (IQueryable<HangHoa>)db.HangHoas.Include(l => l.MaLoaiNavigation).Where(p => p.MaLoai == id);
			}
			int pageNum = (int)Math.Ceiling(hanghoa.Count() / (float)pageSize);
			ViewBag.PageNum = pageNum;
			var res = hanghoa.Take(pageSize).ToList();
			return View(res);
		}

		public IActionResult HangHoaTheoLoai(int? maloaihang)
		{
			QLHangHoaContext db = new QLHangHoaContext();
			var hanghoa = db.HangHoas.Where(p => p.MaLoai == maloaihang).ToList();
			return PartialView("MatHang", hanghoa);
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
