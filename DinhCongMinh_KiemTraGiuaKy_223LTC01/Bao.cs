using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinhCongMinh_KiemTraGiuaKy_223LTC01
{
    class Bao:TaiLieu
    {
        public DateTime NgayPH { get; set; }

        public Bao(int maxb, string tentl, string nhaphathanh, int madanhmuc, DateTime ngayph) : base(maxb, tentl, nhaphathanh, madanhmuc)
        {
            NgayPH = ngayph;
        }
    }
}
