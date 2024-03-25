using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinhCongMinh_KiemTraGiuaKy_223LTC01
{
    class Program
    {
        private static List<Sach> sach334 = new List<Sach>
        {
            new Sach(1, "Lap trinh C", "Giao Duc", 1, "Cong Minh", 123),
            new Sach(2, "Chuyen de lap trinh", "Chuyen nganh", 2, "Khanh Binh", 200),
        };

        private static List<Bao> bao334 = new List<Bao>
        {
            new Bao(1, "Hoa hoc tro", "Kim Dong", 1, new DateTime(2024, 3, 20)),
            new Bao(2, "Kinh doanh", "Nha Nam", 2, new DateTime(2024, 2, 21)),
        };

        private static List<TapChi> tapChi334 = new List<TapChi>
        {
            new TapChi(1, "Hoc tro cuoi", "Kim Dong", 1, 1, "VNExpress"),
            new TapChi(2, "Phuong phap kinh te", "Jordan", 2, 2, "Chuyen dong 24h"),
        };

        private static List<DanhMuc> danhMuc334 = new List<DanhMuc>
        {
            new DanhMuc(1, "Hoc sinh sinh vien", 1, 1, 1),
            new DanhMuc(2, "Nguoi di lam", 2, 2, 2),
        };

        private static List<TaiLieu> taiLieu334 = new List<TaiLieu>
        {};

        static void Main(string[] args)
        {
            Console.WriteLine("Dinh Cong Minh - 21115053120334 - 223LTC01");
            Console.Write("\n");
            //Thêm mới dữ liệu Sách, báo, tạp chí
            taiLieu334.AddRange(sach334);
            taiLieu334.AddRange(bao334);
            taiLieu334.AddRange(tapChi334);

            //Tìm theo loại
            //Lọc sách
            var LocSach334 = taiLieu334.Where(tl => tl.GetType() == typeof(Sach));
            if (LocSach334.Any())
            {
                Console.WriteLine("Danh sach Sach:");
                Console.WriteLine();

                foreach (Sach s334 in LocSach334)
                {
                    Console.WriteLine("Ma xuat ban: " + s334.MaXB);
                    Console.WriteLine("Ten sach: " + s334.TenTl);
                    Console.WriteLine("Nha phat hanh: " + s334.NhaPhatHanh);
                    Console.WriteLine("Ten tac gia: " + s334.TenTacGia);
                    Console.WriteLine("So trang: " + s334.SoTrang);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Khong co sach nao duoc tim thay!");
            }

            //Lọc báo
            var LocBao334 = taiLieu334.Where(tl => tl.GetType() == typeof(Bao));
            if (LocBao334.Any())
            {
                Console.WriteLine("\n----------------------------------------------------------\n");
                Console.WriteLine("Danh sach bao:");
                Console.WriteLine();

                foreach (Bao b334 in LocBao334)
                {
                    Console.WriteLine("Ma xuat ban: " + b334.MaXB);
                    Console.WriteLine("Ten bao: " + b334.TenTl);
                    Console.WriteLine("Nha phat hanh: " + b334.NhaPhatHanh);
                    Console.WriteLine("Ngay phat hanh: " + b334.NgayPH.ToString("dd/MM/yyyy"));
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Khong co bao nao duoc tim thay!");
            }

            //Lọc tạp chí
            var LocTapChi334 = taiLieu334.Where(tl => tl.GetType() == typeof(TapChi));
            if (LocTapChi334.Any())
            {
                Console.WriteLine("\n----------------------------------------------------------\n");
                Console.WriteLine("Danh sach tap chi:");
                Console.WriteLine();

                foreach (TapChi tc334 in LocTapChi334)
                {
                    Console.WriteLine("Ma xuat ban: " + tc334.MaXB);
                    Console.WriteLine("Ten tap chi: " + tc334.TenTl);
                    Console.WriteLine("Nha phat hanh: " + tc334.NhaPhatHanh);
                    Console.WriteLine("So phat hanh: " + tc334.SoPhatHanh);
                    Console.WriteLine("Trang phat hanh: " + tc334.TrangPhatHanh);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Khong co bao nao duoc tim thay!");
            }
            //Tìm báo có ngày phát hành tháng 3
            var dauthang334 = new DateTime(2024, 3, 1);
            var cuoithang334 = new DateTime(2024, 3, 31);

            var baothangba334 = bao334.Where(b => b.NgayPH >= dauthang334 && b.NgayPH <= cuoithang334);

            Console.WriteLine("\n----------------------------------------------------------\n");
            Console.WriteLine("Bao duoc in ra vao thang 3 la:");
            foreach (Bao b in baothangba334)
            {
                Console.WriteLine("Ma xuat ban: " + b.MaXB);
                Console.WriteLine("Ten bao " + b.TenTl);
                Console.WriteLine("Nha phat hanh " + b.NhaPhatHanh);
                Console.WriteLine("Ngay phat hanh " + b.NgayPH.ToString("dd/MM/yyyy"));
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
