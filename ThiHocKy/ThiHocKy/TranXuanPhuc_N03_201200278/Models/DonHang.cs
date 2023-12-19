using System;
using System.Collections.Generic;

namespace TranXuanPhuc_N03_201200278.Models
{
    public partial class DonHang
    {
        public DonHang()
        {
            ChiTietDhs = new HashSet<ChiTietDh>();
        }

        public string MaDonHang { get; set; } = null!;
        public DateTime? NgayDatHang { get; set; }
        public string? MaNguoiDung { get; set; }
        public string? DiaChiGiaoHang { get; set; }
        public string? PtthanhToan { get; set; }
        public string? TinhTrang { get; set; }
        public string TenNguoiNhanHang { get; set; } = null!;
        public string SoDienThoaiNhanHang { get; set; } = null!;
        public long? TongTien { get; set; }
        public byte? GiamGia { get; set; }
        public string? GhiChu { get; set; }

        public virtual NguoiDung? MaNguoiDungNavigation { get; set; }
        public virtual ICollection<ChiTietDh> ChiTietDhs { get; set; }
    }
}
