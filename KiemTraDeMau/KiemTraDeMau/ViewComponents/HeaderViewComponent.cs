using Microsoft.AspNetCore.Mvc;
using KiemTraDeMau.Models;

namespace KiemTraDeMau.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {

        
        public async Task<IViewComponentResult> InvokeAsync()

        {
            QLHangHoaContext db = new QLHangHoaContext();
            List<LoaiHang> loai = new List<LoaiHang>();
            return View(loai);
        }
    }
}
 