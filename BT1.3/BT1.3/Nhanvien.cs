using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1._3
{
    class NhanVien : CanBo
    {
        public string CongViec { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap cong viec: ");
            CongViec = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Chuc vu: Nhan vien, Cong viec: {CongViec}");
        }
    }
}
