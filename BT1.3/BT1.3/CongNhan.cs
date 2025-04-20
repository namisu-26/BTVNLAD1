using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1._3
{
    class CongNhan : CanBo
    {
        public string Bac { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap bac (vi du: 3/7): ");
            Bac = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Chuc vu: Cong nhan, Bac: {Bac}");
        }
    }
}
