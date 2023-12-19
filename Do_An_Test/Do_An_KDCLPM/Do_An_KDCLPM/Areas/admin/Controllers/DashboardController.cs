using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Do_An_KDCLPM.Models;
namespace Do_An_KDCLPM.Areas.admin.Controllers
{
    public class DashboardController : BaseController
    {
        private QL_LINHKIENDIENTU_WEBEntities db = new QL_LINHKIENDIENTU_WEBEntities();
        public ActionResult Index()
        {
            return View();
        }
       
        //sản phẩm sắp hết hàng <=5
        [HttpPost]
        public JsonResult LoadProductNotStock(int month, int year)
        {
            var products = new List<string>();
            var quantity = new List<string>();
            foreach (var item in db.products)
            {
                if(item.quantity<=5)
                {
                    products.Add(item.name);
                    quantity.Add(item.quantity.ToString());
                }
            }

            return Json(new
            {
                products = products.ToArray<string>(),
                quantity = quantity.ToArray<string>()
            });
        }
      
    }
}