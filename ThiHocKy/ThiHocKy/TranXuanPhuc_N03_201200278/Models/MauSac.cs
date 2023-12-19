using System;
using System.Collections.Generic;

namespace TranXuanPhuc_N03_201200278.Models
{
    public partial class MauSac
    {
        public MauSac()
        {
            SptheoMaus = new HashSet<SptheoMau>();
        }

        public string MaMau { get; set; } = null!;
        public string TenMau { get; set; } = null!;

        public virtual ICollection<SptheoMau> SptheoMaus { get; set; }
    }
}
