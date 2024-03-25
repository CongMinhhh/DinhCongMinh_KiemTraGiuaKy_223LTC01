using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinhCongMinh_KiemTraGiuaKy_223LTC01
{
    class Sach:TaiLieu
    {
        public string TenTacGia { get; set; }
        public int SoTrang { get; set; }

        public Sach(int maxb, string tentl, string nhaphathanh, int madanhmuc, string tentacgia, int sotrang) : base(maxb, tentl, nhaphathanh, madanhmuc)
        {
            TenTacGia = tentacgia;
            SoTrang = sotrang;
        }
    }
}
