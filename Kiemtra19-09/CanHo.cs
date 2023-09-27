using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtra19_09
{
    internal class CanHo
    {
        string diachi,huongbancong,tinhtrang;
        int sophongngu, sowc;
        long gia;
        double trietkhau;

        public CanHo()
        {

        }

        public CanHo(string diachi, string huongbancong, string tinhtrang, int sophongngu, int sowc, long gia, double trietkhau)
        {
            this.diachi = diachi;
            this.huongbancong = huongbancong;
            this.tinhtrang = tinhtrang;
            this.sophongngu = sophongngu;
            this.sowc = sowc;
            this.gia = gia;
            this.trietkhau = 0.0;
        }

        public int Sophongngu { get => sophongngu; set => sophongngu = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Huongbancong { get => huongbancong; set => huongbancong = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public int Sowc { get => sowc; set => sowc = value; }
        public long Gia { get => gia; set => gia = value; }
        public double Trietkhau { get => trietkhau; set => trietkhau = value; }

        public override string ToString()
        { 
            return "Địa chỉ: "+ diachi + "" + "Hướng ban công: " + huongbancong + "" + "Tình trạng: " + tinhtrang + "" + "Số phòng ngủ:" +  sophongngu + "" + "Số nhà vệ sinh: " +  sowc + "" + "Giá: " +  gia + "" + "Triết khấu: "  + trietkhau + "";
        }

    }
}
