using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using TranXuanPhuc_N03_201200278.Models;

namespace TranXuanPhuc_N03_201200278.Views.Shared.Components.NavMenu
{
    public class NavMenu : ViewComponent
    {
        private readonly QLBanNoiContext _context;
        public NavMenu(QLBanNoiContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var phanLoaiPhus = _context.PhanLoaiPhus.ToList();
            return View(phanLoaiPhus);
        }
    }
}
