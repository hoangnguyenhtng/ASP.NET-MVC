using System;
using System.Collections.Generic;

namespace TranXuanPhuc_N03_201200278.Models
{
    public partial class PhanLoaiPhu
    {
        public PhanLoaiPhu()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public string MaPhanLoaiPhu { get; set; } = null!;
        public string? TenPhanLoaiPhu { get; set; }
        public string? MaPhanLoai { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
