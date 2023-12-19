using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Do_An_KDCLPM.Models;
using PagedList;

namespace Do_An_KDCLPM.Areas.admin.Controllers
{
    public class Product_adminController : BaseController
    {
        private QL_LINHKIENDIENTU_WEBEntities db = new QL_LINHKIENDIENTU_WEBEntities();
        int pageSize = 10;
        void ViewBagNoti(List<products> temp, int page)
        {
            ViewBag.last = 1;
            if (temp.Count() > 0)
            {
                int last = int.Parse(Math.Ceiling((double)temp.Count() / pageSize).ToString());
                ViewBag.last = last;
                ViewBag.noti = "Showing " + page + "-" + last + " of " + temp.Count() + " results";
            }
        }
        public ActionResult Index(int page = 1)
        {
            var temp = db.products.Include(p => p.category).ToList();
            var products = temp.ToPagedList(page, pageSize);
            ViewBagNoti(temp, page);
            ViewBag.check = true;
            return View(products);
        }
        public ActionResult Search(int page = 1)
        {
            var keyword = Request["tukhoa"];
            if (string.IsNullOrEmpty(keyword))
            {
                return RedirectToAction("Index");
            }
            ViewBag.check = false;
            var temp = db.products.Where(x =>
            x.name.ToLower().Contains(keyword.ToLower().Trim()) ||
            x.category.name.ToLower().Contains(keyword.ToLower().Trim()) ||
            x.id.ToString().ToLower().Equals(keyword.ToLower().Trim()) ||
            x.price.ToString().ToLower().Equals(keyword.ToLower().Trim()) ||
            x.promationprice.ToString().ToLower().Equals(keyword.ToLower().Trim()) ||
            x.quantity.ToString().ToLower().Equals(keyword.ToLower().Trim())
            ).ToList();
            var products = temp.ToPagedList(page, pageSize);
            ViewBagNoti(temp, page);
            return View("Index", products);
        }
        private string UploadFile()
        {
            var file = Request.Files["file"];
            if (file != null)
            {
                try
                {
                    string fileName = "assets/client/img/" + file.FileName;
                    string path = Server.MapPath("~/" + fileName);
                    file.SaveAs(path);
                    return fileName;
                }
                catch (Exception)
                {
                }
            }
            return "";
        }
        [HttpPost]
        public JsonResult delete_product(int id)
        {
            try
            {
                var product = db.products.Find(id);
                db.products.Remove(product);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    status = 0,
                    message = "Có lỗi trong quá trình xoá.Vui lòng thử lại."
                });
            }

            return Json(new
            {
                status = 1,
                message = "Xoá thành công."
            });
        }
        public ActionResult Create()
        {
            ViewBag.idcategory = new SelectList(db.category, "id", "name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "id,name,price,promationprice,description,quantity,idcategory,newproduct")] products products)
        {
            if (ModelState.IsValid)
            {

                if (db.products.SingleOrDefault(x => x.name.ToLower().Equals(products.name.ToLower())) == null)
                {
                    products.image = UploadFile();
                    products.alias = Libary.Instances.convertToUnSign3(products.name);
                    db.products.Add(products);
                    db.SaveChanges();
                    TempData["status"] = "Thêm mới sản phẩm thành công!!";

                    return Redirect("/admin/san-pham");
                }
                else
                {
                    TempData["status"] = "Trùng tên sản phẩm!!";
                }
            }

            ViewBag.idcategory = new SelectList(db.category, "id", "name", products.idcategory);
            return View(products);
        }
        // GET: admin/products/Edit/5
        public ActionResult Edit(string alias)
        {
            if (string.IsNullOrEmpty(alias))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            products products = db.products.SingleOrDefault(x => x.alias.Equals(alias));
            if (products == null)
            {
                return HttpNotFound();
            }
            ViewBag.idcategory = new SelectList(db.category, "id", "name", products.idcategory);
            return View(products);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "id,name,alias,quantity,price,promationprice,description,image,newproduct,idcategory")] products products)
        {
            if (ModelState.IsValid)
            {
                var temp = db.products.FirstOrDefault(x => x.id != products.id && x.name.ToLower().Equals(products.name.ToLower()));
                if (temp == null)
                {
                    var fileName = UploadFile();
                    if (!string.IsNullOrEmpty(fileName))
                        products.image = fileName;
                    else
                        try
                        {
                            products.image = products.image.Substring(1);
                        }
                        catch (Exception ex)
                        {

                        }
                    products.alias = Libary.Instances.convertToUnSign3(products.name);
                    db.Entry(products).State = EntityState.Modified;
                    db.SaveChanges();
                    TempData["status"] = "Sửa sản phẩm thành công!!";
                    return Redirect("/admin/san-pham");
                }
                else
                {
                    TempData["status"] = "Trùng tên sản phẩm!!";
                }
            }
            ViewBag.idcategory = new SelectList(db.category, "id", "name", products.idcategory);
            return View(products);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
