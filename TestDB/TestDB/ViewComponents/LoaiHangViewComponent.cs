using Microsoft.AspNetCore.Mvc;
using TestDB.Controllers;
using TestDB.Models;

namespace TestDB.ViewComponents
{
	public class LoaiHangViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			QLHangHoaContext db = new QLHangHoaContext();
			var loaihang = db.LoaiHangs.ToList();
			return View(loaihang);
		}
	}
}
