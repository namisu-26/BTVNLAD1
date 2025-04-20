using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1._3
{
    class KySu : CanBo
    {
        public string NganhDaoTao { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap nganh dao tao: ");
            NganhDaoTao = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Chuc vu: Ky su, Nganh dao tao: {NganhDaoTao}");
        }
    }
}
