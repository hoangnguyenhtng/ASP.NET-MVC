//hàm chuyển đổi tiền tệ
function number_format(number, decimals, dec_point, thousands_sep) {
  // *     example: number_format(1234.56, 2, ',', ' ');
  // *     return: '1 234,56'
  number = (number + "").replace(",", "").replace(" ", "");
  var n = !isFinite(+number) ? 0 : +number,
    prec = !isFinite(+decimals) ? 0 : Math.abs(decimals),
    sep = typeof thousands_sep === "undefined" ? "," : thousands_sep,
    dec = typeof dec_point === "undefined" ? "." : dec_point,
    s = "",
    toFixedFix = function (n, prec) {
      var k = Math.pow(10, prec);
      return "" + Math.round(n * k) / k;
    };
  // Fix for IE parseFloat(0.55).toFixed(0) = 0;
  s = (prec ? toFixedFix(n, prec) : "" + Math.round(n)).split(".");
  if (s[0].length > 3) {
    s[0] = s[0].replace(/\B(?=(?:\d{3})+(?!\d))/g, sep);
  }
  if ((s[1] || "").length < prec) {
    s[1] = s[1] || "";
    s[1] += new Array(prec - s[1].length + 1).join("0");
  }
  return s.join(dec);
}
/*Hàm disable button khi chờ server xử lý */
function disable(dom) {
  $(dom).attr("disabled", "true");
  $(dom).attr("data-text", $(dom).text());
  $(dom).html(
    `<span class="spinner-grow spinner-grow-sm" ></span> <span>Loading...</span>`
  );
}
/*Hàm disable button khi chờ server xử lý */
function enable(dom) {
  $(dom + " span").hide();
  $(dom).removeAttr("disabled");
  $(dom).html($(dom).data("text"));
}
$(function () {
  //slide bar đóng lại khi ở chế độ mobile
  if (
    !(
      $("#sidebar").css("display") == "none" ||
      $("#sidebar").css("visibility") == "hidden"
    )
  ) {
    $("#sidebarToggle").click();
  }

  //Đăng xuất khỏi hệ thống
  $("#btnlogout").click(function () {
    location.href = "/Login/Logout";
  });
  //hàm xử lý xoá 1 sản phẩm
  function delete_product(id, ele) {
    $.ajax({
      url: "/admin/Product_admin/delete_product/" + id,
      data: JSON.stringify(id),
      contentType: "application/json; charset=utf-8",
      dataType: "json",
      type: "POST",
      success: function (data) {
        if (data.status == 1) {
          iziToast.success({
            timeout: 1500,
            title: "Thành công",
            message: data.message,
            position: "topRight",
          });
          $(`#_product_${id}`).hide(200);

        } else
          iziToast.error({
            timeout: 1500,
            title: "Lỗi",
            message: data.message,
            position: "topRight",
          });
      },
      error: function (data) {
        iziToast.error({
          timeout: 1500,
          title: "Lỗi",
          message: "Lỗi chưa xác định.",
          position: "topRight",
        });
      },
    });
  }
  //Event gọi hàm xoá 1 sản phẩm
  $(".delete_product")
    .off("click")
    .click(function (e) {
      e.preventDefault();
      var id = Number($(this).data("id"));
      var ele = $(this);
      swal({
        title: "Bạn chắc chắn xoá sản phẩm này?",
        icon: "warning",
        buttons: true,
        dangerMode: true,
      }).then((willDelete) => {
        if (willDelete) {
          delete_product(id, ele);
        }
      });
    });

  //Hàm xử lý xoá 1 loại sản phẩm
  function delete_category(id, ele) {
    $.ajax({
      url: "/admin/Category_admin/delete_category/" + id,
      data: JSON.stringify(id),
      contentType: "application/json; charset=utf-8",
      dataType: "json",
      type: "POST",
      success: function (data) {
        if (data.status == 1) {
          iziToast.success({
            timeout: 1500,
            title: "Thành công",
            message: data.message,
            position: "topRight",
          });

          $(`#_category_${id}`).hide(200);

        } else
          iziToast.error({
            timeout: 1500,
            title: "Lỗi",
            message: data.message,
            position: "topRight",
          });
      },
      error: function (data) {
        iziToast.error({
          timeout: 1500,
          title: "Lỗi",
          message: "Lỗi chưa xác định.",
          position: "topRight",
        });
      },
    });
  }
  //Event gọi hàm xoá 1 loại sản phẩm
  $(".delete_category")
    .off("click")
    .click(function (e) {
      e.preventDefault();
      var id = Number($(this).data("id"));
      var ele = $(this);

      swal({
        title: "Bạn chắc chắn xoá loại sản phẩm này?",
        icon: "warning",
        buttons: true,
        dangerMode: true,
      }).then((willDelete) => {
        if (willDelete) {
          delete_category(id, ele);
        }
      });
    });
  //Hàm xoá quyền
  function delete_role(id) {
    $.ajax({
      url: "/Role_admin/delete_role/" + id,
      data: JSON.stringify(id),
      contentType: "application/json; charset=utf-8",
      dataType: "json",
      type: "POST",
      success: function (data) {
        if (data.status == 1) {
          iziToast.success({
            timeout: 1500,
            title: "Thành công",
            message: data.message,
            position: "topRight",
          });
          $(`#_role_${id}`).hide(200);
        } else
          iziToast.error({
            timeout: 1500,
            title: "Lỗi",
            message: data.message,
            position: "topRight",
          });
      },
      error: function (data) {
        iziToast.error({
          timeout: 1500,
          title: "Lỗi",
          message: "Lỗi chưa xác định.",
          position: "topRight",
        });
      },
    });
  }
  //Event gọi hàm xoá quyền
  $(".delete_role")
    .off("click")
    .click(function (e) {
      e.preventDefault();
      var id = Number($(this).data("id"));

      swal({
        title: "Bạn chắc chắn xoá quyền này?",
        icon: "warning",
        buttons: true,
        dangerMode: true,
      }).then((willDelete) => {
        if (willDelete) {
          delete_role(id);
        }
      });
    });
  //Hàm xử lý xoá 1 tài khoản
  function delete_account(id) {
    $.ajax({
      url: "/admin/Account_admin/delete_account/" + id,
      data: JSON.stringify(id),
      contentType: "application/json; charset=utf-8",
      dataType: "json",
      type: "POST",
      success: function (data) {
        if (data.status == 1 || data.status == 2) {
          iziToast.success({
            timeout: 1500,
            title: "Thành công",
            message: data.message,
            position: "topRight",
          });

          $(`#_account_${id}`).hide(200);
          if (data.status == 2) {
            location.href = "/Login/Logout";
          }
        } else
          iziToast.error({
            timeout: 1500,
            title: "Lỗi",
            message: data.message,
            position: "topRight",
          });
      },
      error: function (data) {
        iziToast.error({
          timeout: 1500,
          title: "Lỗi",
          message: "Lỗi chưa xác định.",
          position: "topRight",
        });
      },
    });
  }
  //Event gọi hàm xoá 1 tài khoản
  $(".delete_account")
    .off("click")
    .click(function (e) {
      e.preventDefault();
      var id = Number($(this).data("id"));
      swal({
        title: "Bạn chắc chắn xoá tài khoản này?",
        icon: "warning",
        buttons: true,
        dangerMode: true,
      }).then((willDelete) => {
        if (willDelete) {
          delete_account(id);
        }
      });
    });

  //Hàm reset password của user & admin
  function reset_password(id) {
    $.ajax({
      url: "/admin/Account_admin/resetPassword/" + id,
      data: JSON.stringify(id),
      contentType: "application/json; charset=utf-8",
      dataType: "json",
      type: "POST",
      success: function (data) {
        if (data.status == 1)
          iziToast.success({
            timeout: 1500,
            title: "Thành công",
            message: data.message,
            position: "topRight",
          });
        else
          iziToast.error({
            timeout: 1500,
            title: "Lỗi",
            message: data.message,
            position: "topRight",
          });
      },
      error: function (data) {
        iziToast.error({
          timeout: 1500,
          title: "Lỗi",
          message: "Lỗi chưa xác định.",
          position: "topRight",
        });
      },
    });
  }
  //Event gọi hàm reset password
  $(".reset-password")
    .off("click")
    .click(function (e) {
      e.preventDefault();
      var id = Number($(this).data("id"));
      swal({
        title: "Bạn chắc chắn reset mật khẩu tài khoản này?",
        icon: "warning",
        buttons: true,
        dangerMode: true,
      }).then((willDelete) => {
        if (willDelete) {
          reset_password(id);
        }
      });
    });         

});
