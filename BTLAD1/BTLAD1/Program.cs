//using System;

//class Program
//{
//    static void Main()
//    {
//        // Nhập tên
//        Console.Write("Nhap ten cua ban : ");
//        string ten = Console.ReadLine();

//        // Nhập tuổi
//        Console.Write("Nhap tuoi cau ban: ");
//        string tuoi = Console.ReadLine();

//        // In ra màn hình lời chào
//        Console.WriteLine($"Xin chao {ten}, ban {tuoi} tuoi");
//    }
//}
//bai2 Tinh dien tich hinh chu nhat
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhap chieu dai: ");
//        double dai = double.Parse(Console.ReadLine());

//        Console.Write("Nhap chieu rong: ");
//        double rong = double.Parse(Console.ReadLine());

//        double dienTich = dai * rong;
//        Console.WriteLine("Dien tich hinh chu nhat la: " + dienTich);
//    }
//}

//Bai 3: Chuyen doi do C sang do F
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhap nhiet do (do C): ");
//        double c = double.Parse(Console.ReadLine());

//        double f = (c * 9 / 5) + 32;
//        Console.WriteLine("Nhiet do F tuong ung: " + f);
//    }
//}

//Bai 4: Kiem tra so chan hay le
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhap mot so nguyen: ");
//        int so = int.Parse(Console.ReadLine());

//        if (so % 2 == 0)
//            Console.WriteLine("Day la so chan.");
//        else
//            Console.WriteLine("Day la so le.");
//    }
//}

//Bai 5: Tinh tong va tich cua hai so
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhap so thu nhat: ");
//        double a = double.Parse(Console.ReadLine());

//        Console.Write("Nhap so thu hai: ");
//        double b = double.Parse(Console.ReadLine());

//        Console.WriteLine("Tong: " + (a + b));
//        Console.WriteLine("Tich: " + (a * b));
//    }
//}

//Bai 6: Kiem tra am, duong, hay bang 0
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhap mot so: ");
//        double so = double.Parse(Console.ReadLine());

//        if (so > 0)
//            Console.WriteLine("Day la so duong.");
//        else if (so < 0)
//            Console.WriteLine("Day la so am.");
//        else
//            Console.WriteLine("Day la so 0.");
//    }
//}
//Bai 7: Kiem tra nam nhuan
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhap mot nam: ");
//        int nam = int.Parse(Console.ReadLine());

//        if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
//            Console.WriteLine(nam + " la nam nhuan.");
//        else
//            Console.WriteLine(nam + " khong phai la nam nhuan.");
//    }
//}

//Bai 8: In bang cuu chuong tu 1 den 10
//using System;

//class Program
//{
//    static void Main()
//    {
//        for (int i = 1; i <= 10; i++)
//        {
//            Console.WriteLine("--- Bang cuu chuong " + i + " ---");
//            for (int j = 1; j <= 10; j++)
//            {
//                Console.WriteLine(i + " x " + j + " = " + (i * j));
//            }
//            Console.WriteLine();
//        }
//    }
//}

//Bai 9: Tinh giai thua
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhap so nguyen duong n: ");
//        int n = int.Parse(Console.ReadLine());

//        long giaiThua = 1;
//        for (int i = 1; i <= n; i++)
//        {
//            giaiThua *= i;
//        }

//        Console.WriteLine("Giai thua cua " + n + " la: " + giaiThua);
//    }
//}

//Bai 10: Kiem tra so nguyen to
using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap mot so nguyen: ");
        int n = int.Parse(Console.ReadLine());

        bool laNguyenTo = true;

        if (n < 2)
            laNguyenTo = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    laNguyenTo = false;
                    break;
                }
            }
        }

        if (laNguyenTo)
            Console.WriteLine(n + " la so nguyen to.");
        else
            Console.WriteLine(n + " khong phai la so nguyen to.");
    }
}
