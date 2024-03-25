using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinhCongMinh_KiemTraGiuaKy_223LTC01
{
    class DanhMuc
    {
        public int CateId { get; set; }
        public string CategoryName { get; set; }
        public int maSach { get; set; }
        public int maBao { get; set; }
        public int maTapChi { get; set; }

        public DanhMuc(int id, string categoryname, int masach, int mabao, int matapchi)
        {
            CateId = id;
            CategoryName = categoryname;
            this.maSach = masach;
            this.maBao = mabao;
            this.maTapChi = matapchi;
        }
    }
}
