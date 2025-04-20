using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1._3
{
    class QLCB
    {
        private List<CanBo> danhSach = new List<CanBo>();

        public void ThemCanBo()
        {
            Console.WriteLine("Chon loai can bo can nhap:");
            Console.WriteLine("1. Cong nhan");
            Console.WriteLine("2. Ky su");
            Console.WriteLine("3. Nhan vien");
            Console.Write("Lua chon (1/2/3): ");
            string luaChon = Console.ReadLine();

            CanBo cb = null;
            switch (luaChon)
            {
                case "1":
                    cb = new CongNhan();
                    break;
                case "2":
                    cb = new KySu();
                    break;
                case "3":
                    cb = new NhanVien();
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    return;
            }

            cb.Nhap();
            danhSach.Add(cb);
            Console.WriteLine("Da them can bo thanh cong.\n");
        }

        public void TimKiemTheoTen()
        {
            Console.Write("Nhap ho ten can tim: ");
            string ten = Console.ReadLine();

            bool timThay = false;
            foreach (var cb in danhSach)
            {
                if (cb.HoTen.ToLower().Contains(ten.ToLower()))
                {
                    cb.HienThi();
                    timThay = true;
                }
            }

            if (!timThay)
            {
                Console.WriteLine("Khong tim thay can bo co ten nhu vay.");
            }
        }

        public void HienThiDanhSach()
        {
            Console.WriteLine("\n--- Danh sach can bo ---");
            foreach (var cb in danhSach)
            {
                cb.HienThi();
                Console.WriteLine("----------------------");
            }
        }
    }

    // Main Program
    class Program
    {
        static void Main()
        {
            QLCB qlcb = new QLCB();

            while (true)
            {
                Console.WriteLine("\n=== MENU QUAN LY CAN BO ===");
                Console.WriteLine("1. Nhap thong tin can bo moi");
                Console.WriteLine("2. Tim kiem theo ho ten");
                Console.WriteLine("3. Hien thi danh sach can bo");
                Console.WriteLine("4. Thoat");
                Console.Write("Nhap lua chon cua ban: ");

                string chon = Console.ReadLine();
                switch (chon)
                {
                    case "1":
                        qlcb.ThemCanBo();
                        break;
                    case "2":
                        qlcb.TimKiemTheoTen();
                        break;
                    case "3":
                        qlcb.HienThiDanhSach();
                        break;
                    case "4":
                        Console.WriteLine("Tam biet!");
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }
        }
    }

}
