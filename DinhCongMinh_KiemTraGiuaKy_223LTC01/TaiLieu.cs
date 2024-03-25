using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinhCongMinh_KiemTraGiuaKy_223LTC01
{
    class TaiLieu
    {
        public int MaXB { get; set; }
        public string TenTl { get; set; }
        public string NhaPhatHanh { get; set; }
        public int MaDanhMuc { get; set; }

        protected TaiLieu(int maxb, string tentl, string nhaphathanh, int madanhmuc)
        {
            MaXB = maxb;
            TenTl = tentl;
            NhaPhatHanh = nhaphathanh;
            MaDanhMuc = madanhmuc;
        }
    }
}
