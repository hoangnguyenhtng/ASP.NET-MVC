using System;
using System.Collections.Generic;

namespace TranXuanPhuc_N03_201200278.Models
{
    public partial class ChiTietSpban
    {
        public ChiTietSpban()
        {
            ChiTietDhs = new HashSet<ChiTietDh>();
        }

        public string MaChiTietSp { get; set; } = null!;
        public string? MaSptheoMau { get; set; }
        public string? KichCo { get; set; }
        public int? SoLuong { get; set; }
        public long? DonGiaBan { get; set; }

        public virtual SptheoMau? MaSptheoMauNavigation { get; set; }
        public virtual ICollection<ChiTietDh> ChiTietDhs { get; set; }
    }
}
