using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TranXuanPhuc_N03_201200278.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            SptheoMaus = new HashSet<SptheoMau>();
        }

        public string MaSanPham { get; set; } = null!;
        public string TenSanPham { get; set; } = null!;
        public string? MaPhanLoai { get; set; }

        [RegularExpression(@"^[0-9]+$")]
        public long? GiaNhap { get; set; }

        [RegularExpression(@"^[0-9]+$")]
        public long? DonGiaBanNhoNhat { get; set; }

        [RegularExpression(@"^[0-9]+$")]
        public long? DonGiaBanLonNhat { get; set; }
        public bool? TrangThai { get; set; }

        [RegularExpression(@"^[A-Za-z]+[a-zA-Z0-9._%+-]$")]
        public string? MoTaNgan { get; set; }
        public string? AnhDaiDien { get; set; }
        public bool? NoiBat { get; set; }
        public string? MaPhanLoaiPhu { get; set; }

        public virtual PhanLoai? MaPhanLoaiNavigation { get; set; }
        public virtual PhanLoaiPhu? MaPhanLoaiPhuNavigation { get; set; }
        public virtual ICollection<SptheoMau> SptheoMaus { get; set; }
    }
}
