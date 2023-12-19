using System;
using System.Collections.Generic;

namespace TranXuanPhuc_N03_201200278.Models
{
    public partial class SptheoMau
    {
        public SptheoMau()
        {
            AnhChiTietSps = new HashSet<AnhChiTietSp>();
            ChiTietSpbans = new HashSet<ChiTietSpban>();
        }

        public string MaSptheoMau { get; set; } = null!;
        public string MaSanPham { get; set; } = null!;
        public string MaMau { get; set; } = null!;

        public virtual MauSac MaMauNavigation { get; set; } = null!;
        public virtual SanPham MaSanPhamNavigation { get; set; } = null!;
        public virtual ICollection<AnhChiTietSp> AnhChiTietSps { get; set; }
        public virtual ICollection<ChiTietSpban> ChiTietSpbans { get; set; }
    }
}
