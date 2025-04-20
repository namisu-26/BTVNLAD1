using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyTaiLieu qltl = new QuanLyTaiLieu();
            while (true)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Nhap tai lieu moi");
                Console.WriteLine("2. Hien thi danh sach tai lieu");
                Console.WriteLine("3. Tim tai lieu theo loai");
                Console.WriteLine("0. Thoat");
                Console.Write("Nhap lua chon: ");
                int chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        qltl.ThemTaiLieu();
                        break;
                    case 2:
                        qltl.HienThiTatCa();
                        break;
                    case 3:
                        qltl.TimTheoLoai();
                        break;
                    case 0:
                        Console.WriteLine("Thoat chuong trinh.");
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le.");
                        break;
                }
            }
        }
    }
}
