using System;
using System.Collections.Generic;

namespace TranXuanPhuc_N03_201200278.Models
{
    public partial class NguoiDung
    {
        public NguoiDung()
        {
            DonHangs = new HashSet<DonHang>();
        }

        public string MaNguoiDung { get; set; } = null!;
        public string? TenDangNhap { get; set; }
        public string? TenNguoiDung { get; set; }
        public string? SoDienThoai { get; set; }
        public string? Email { get; set; }
        public string? MatKhau { get; set; }
        public string? DiaChi { get; set; }

        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}
