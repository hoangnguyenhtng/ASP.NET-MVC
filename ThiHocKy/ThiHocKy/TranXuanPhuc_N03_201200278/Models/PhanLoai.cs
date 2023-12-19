using System;
using System.Collections.Generic;

namespace TranXuanPhuc_N03_201200278.Models
{
    public partial class PhanLoai
    {
        public PhanLoai()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public string MaPhanLoai { get; set; } = null!;
        public string? PhanLoaiChinh { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
