using System.Web.Mvc;

namespace Do_An_KDCLPM.Areas.admin
{
    public class adminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            #region quyền
            context.MapRoute(
              "role_search",
              "admin/tim-kiem-quyen",
              new { controller = "Role_admin", action = "Search", id = UrlParameter.Optional, Area = "Admin" },
              namespaces: new string[] { "Do_An_KDCLPM.Areas.admin.Controllers" }
          );
            context.MapRoute(
             "role",
             "admin/quyen",
             new { controller = "Role_admin", action = "Index", id = UrlParameter.Optional, Area = "Admin" },
             namespaces: new string[] { "Do_An_KDCLPM.Areas.admin.Controllers" }
         );
            #endregion
            #region hoá đơn
            context.MapRoute(
        "order_search",
        "admin/tim-kiem-hoa-don",
        new { controller = "Order_admin", action = "Search", id = UrlParameter.Optional, Area = "Admin" },
        namespaces: new string[] { "Do_An_KDCLPM.Areas.admin.Controllers" }
    );       
            context.MapRoute(
             "order",
             "admin/hoa-don",
             new { controller = "Order_admin", action = "Index", id = UrlParameter.Optional, Area = "Admin" },
             namespaces: new string[] { "Do_An_KDCLPM.Areas.admin.Controllers" }
         );
            #endregion
            #region loại sản phẩm
            context.MapRoute(
        "Category_search",
        "admin/tim-kiem-loai-san-pham",
        new { controller = "Category_admin", action = "Search", id = UrlParameter.Optional, Area = "Admin" },
        namespaces: new string[] { "Do_An_KDCLPM.Areas.admin.Controllers" }
    );
            context.MapRoute(
         "category_edit",
         "admin/sua-loai-san-pham/{alias}",
         new { controller = "Category_admin", action = "Edit", id = UrlParameter.Optional, Area = "Admin" },
         namespaces: new string[] { "Do_An_KDCLPM.Areas.admin.Controllers" }
     );
            context.MapRoute(
           "category_create",
           "admin/them-loai-san-pham",
           new { controller = "Category_admin", action = "Create", id = UrlParameter.Optional, Area = "Admin" },
           namespaces: new string[] { "Do_An_KDCLPM.Areas.admin.Controllers" }
       );
            context.MapRoute(
             "category",
             "admin/loai-san-pham",
             new { controller = "Category_admin", action = "Index", id = UrlParameter.Optional, Area = "Admin" },
             namespaces: new string[] { "Do_An_KDCLPM.Areas.admin.Controllers" }
         );
            #endregion
            #region sản phẩm
            context.MapRoute(
        "product_search",
        "admin/tim-kiem-san-pham",
        new { controller = "Product_admin", action = "Search", id = UrlParameter.Optional, Area = "Admin" },
        namespaces: new string[] { "Do_An_KDCLPM.Areas.admin.Controllers" }
    );
            context.MapRoute(
         "product_edit",
         "admin/sua-san-pham/{alias}",
         new { controller = "Product_admin", action = "Edit", id = UrlParameter.Optional, Area = "Admin" },
         namespaces: new string[] { "Do_An_KDCLPM.Areas.admin.Controllers" }
     );
            context.MapRoute(
           "product_create",
           "admin/them-san-pham",
           new { controller = "Product_admin", action = "Create", id = UrlParameter.Optional, Area = "Admin" },
           namespaces: new string[] { "Do_An_KDCLPM.Areas.admin.Controllers" }
       );
            context.MapRoute(
             "product",
             "admin/san-pham",
             new { controller = "Product_admin", action = "Index", id = UrlParameter.Optional, Area = "Admin" },
             namespaces: new string[] { "Do_An_KDCLPM.Areas.admin.Controllers" }
         );
            #endregion
            #region tài khoản
            context.MapRoute(
        "account_search",
        "admin/tim-kiem-tai-khoan",
        new { controller = "Account_admin", action = "Search", id = UrlParameter.Optional, Area = "Admin" },
        namespaces: new string[] { "Do_An_KDCLPM.Areas.admin.Controllers" }
    );
            context.MapRoute(
         "account_edit",
         "admin/sua-tai-khoan/{username}",
         new { controller = "Account_admin", action = "Edit", id = UrlParameter.Optional, Area = "Admin" },
         namespaces: new string[] { "Do_An_KDCLPM.Areas.admin.Controllers" }
     );
            context.MapRoute(
           "account_create",
           "admin/them-tai-khoan",
           new { controller = "Account_admin", action = "Create", id = UrlParameter.Optional, Area = "Admin" },
           namespaces: new string[] { "Do_An_KDCLPM.Areas.admin.Controllers" }
       );
            context.MapRoute(
             "account",
             "admin/tai-khoan",
             new { controller = "Account_admin", action = "Index", id = UrlParameter.Optional, Area = "Admin" },
             namespaces: new string[] { "Do_An_KDCLPM.Areas.admin.Controllers" }
         );
            #endregion
            #region login
            context.MapRoute(
              "admin_login",
              "admin/dang-nhap",
              new { controller = "Login", action = "Index", id = UrlParameter.Optional, Area = "Admin" },
              namespaces: new string[] { "Do_An_KDCLPM.Areas.admin.Controllers" }
          );
            #endregion
            #region default
            context.MapRoute(
                "admin_default",
                "admin/{controller}/{action}/{id}",
                new { controller = "Dashboard", action = "Index", id = UrlParameter.Optional, Area = "Admin" },
               namespaces: new string[] { "Do_An_KDCLPM.Areas.admin.Controllers" }
            );
            #endregion
        }
    }
}