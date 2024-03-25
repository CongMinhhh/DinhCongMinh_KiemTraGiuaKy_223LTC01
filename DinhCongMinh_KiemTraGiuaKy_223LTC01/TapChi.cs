using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinhCongMinh_KiemTraGiuaKy_223LTC01
{
    class TapChi:TaiLieu
    {
        public int SoPhatHanh { get; set; }
        public string TrangPhatHanh { get; set; }

        public TapChi(int maxb, string tentl, string nhaphathanh, int madanhmuc, int sophathanh, string trangphathanh) : base(maxb, tentl, nhaphathanh, madanhmuc)
        {
            SoPhatHanh = sophathanh;
            TrangPhatHanh = trangphathanh;
        }
    }
}
