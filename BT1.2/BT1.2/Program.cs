//Bai 1: Tinh tong cac so chan trong mang
//using System;

//class Program
//{
//    static int TongSoChan(int[] arr)
//    {
//        int tong = 0;
//        foreach (int so in arr)
//        {
//            if (so % 2 == 0)
//                tong += so;
//        }
//        return tong;
//    }

//    static void Main()
//    {
//        int[] mang = { 1, 2, 3, 4, 5, 6 };
//        Console.WriteLine("Tong cac so chan la: " + TongSoChan(mang));
//    }
//}

// Bai 2: Tim cac so nguyen to trong mang
//using System;

//class Program
//{
//    static bool LaSoNguyenTo(int n)
//    {
//        if (n < 2) return false;
//        for (int i = 2; i <= Math.Sqrt(n); i++)
//        {
//            if (n % i == 0)
//                return false;
//        }
//        return true;
//    }

//    static void Main()
//    {
//        Console.Write("Nhap so phan tu cua mang: ");
//        int n = int.Parse(Console.ReadLine());
//        int[] mang = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write("Nhap phan tu thu " + i + ": ");
//            mang[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Cac so nguyen to trong mang:");
//        for (int i = 0; i < n; i++)
//        {
//            if (LaSoNguyenTo(mang[i]))
//                Console.WriteLine("Chi so: " + i + ", Gia tri: " + mang[i]);
//        }
//    }
//}

// Bai 3: Dem so luong so am va so duong
//using System;

//class Program
//{
//    static void DemSoAmDuong(int[] arr, out int demAm, out int demDuong)
//    {
//        demAm = 0;
//        demDuong = 0;

//        foreach (int so in arr)
//        {
//            if (so < 0) demAm++;
//            else if (so > 0) demDuong++;
//        }
//    }

//    static void Main()
//    {
//        Console.Write("Nhap so phan tu cua mang: ");
//        int n = int.Parse(Console.ReadLine());
//        int[] mang = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write("Nhap phan tu thu " + i + ": ");
//            mang[i] = int.Parse(Console.ReadLine());
//        }

//        DemSoAmDuong(mang, out int am, out int duong);
//        Console.WriteLine("So am: " + am);
//        Console.WriteLine("So duong: " + duong);
//    }
//}

//Bai 4: Tim so lon thu hai trong mang
//using System;

//class Program
//{
//    static int TimSoLonThuHai(int[] arr)
//    {
//        int max1 = int.MinValue;
//        int max2 = int.MinValue;

//        foreach (int so in arr)
//        {
//            if (so > max1)
//            {
//                max2 = max1;
//                max1 = so;
//            }
//            else if (so > max2 && so != max1)
//            {
//                max2 = so;
//            }
//        }

//        return max2;
//    }

//    static void Main()
//    {
//        int[] mang = { 5, 1, 9, 3, 7 };
//        int soLon2 = TimSoLonThuHai(mang);
//        Console.WriteLine("So lon thu hai trong mang la: " + soLon2);
//    }
//}

//Bai 5: Ham hoan vi 2 so nguyen
//using System;

//class Program
//{
//    static void HoanVi(ref int a, ref int b)
//    {
//        int temp = a;
//        a = b;
//        b = temp;
//    }

//    static void Main()
//    {
//        Console.Write("Nhap so a: ");
//        int a = int.Parse(Console.ReadLine());
//        Console.Write("Nhap so b: ");
//        int b = int.Parse(Console.ReadLine());

//        Console.WriteLine("Truoc khi hoan vi: a = " + a + ", b = " + b);
//        HoanVi(ref a, ref b);
//        Console.WriteLine("Sau khi hoan vi: a = " + a + ", b = " + b);
//    }
//}

//Bai 6: Sap xep mang so thuc tang dan
using System;

class Program
{
    static void SapXepTangDan(double[] arr)
    {
        Array.Sort(arr);
    }

    static void Main()
    {
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        double[] mang = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap phan tu thu " + i + ": ");
            mang[i] = double.Parse(Console.ReadLine());
        }

        SapXepTangDan(mang);

        Console.WriteLine("Mang sau khi sap xep tang dan:");
        foreach (double so in mang)
        {
            Console.Write(so + " ");
        }
    }
}