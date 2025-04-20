using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1._3._2
{
    class QuanLyTaiLieu
    {
        private List<TaiLieu> danhSach = new List<TaiLieu>();

        public void ThemTaiLieu()
        {
            Console.WriteLine("Chon loai tai lieu (1: Sach, 2: Tap chi, 3: Bao): ");
            int loai = int.Parse(Console.ReadLine());

            TaiLieu tl = null;

            switch (loai)
            {
                case 1:
                    tl = new Sach();
                    break;
                case 2:
                    tl = new TapChi();
                    break;
                case 3:
                    tl = new Bao();
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    return;
            }

            tl.Nhap();
            danhSach.Add(tl);
            Console.WriteLine("Da them tai lieu thanh cong.\n");
        }

        public void HienThiTatCa()
        {
            Console.WriteLine("\n--- Danh sach tai lieu ---");
            foreach (var tl in danhSach)
            {
                tl.HienThi();
                Console.WriteLine("------------------------");
            }
        }

        public void TimTheoLoai()
        {
            Console.WriteLine("Chon loai can tim (1: Sach, 2: Tap chi, 3: Bao): ");
            int loai = int.Parse(Console.ReadLine());

            foreach (var tl in danhSach)
            {
                if ((loai == 1 && tl is Sach) ||
                    (loai == 2 && tl is TapChi) ||
                    (loai == 3 && tl is Bao))
                {
                    tl.HienThi();
                    Console.WriteLine("------------------------");
                }
            }
        }
    }
}
