using System;
using System.Collections.Generic;

class TaiLieu
{
    public string MaTaiLieu;
    public string TenNhaXuatBan;
    public int SoBanPhatHanh;

    public virtual void Nhap()
    {
        Console.Write("Nhap ma tai lieu: ");
        MaTaiLieu = Console.ReadLine();
        Console.Write("Nhap ten nha xuat ban: ");
        TenNhaXuatBan = Console.ReadLine();
        Console.Write("Nhap so ban phat hanh: ");
        SoBanPhatHanh = int.Parse(Console.ReadLine());
    }

    public virtual void HienThi()
    {
        Console.WriteLine($"Ma: {MaTaiLieu}, NXB: {TenNhaXuatBan}, So ban: {SoBanPhatHanh}");
    }
}

class Sach : TaiLieu
{
    public string TacGia;
    public int SoTrang;

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap ten tac gia: ");
        TacGia = Console.ReadLine();
        Console.Write("Nhap so trang: ");
        SoTrang = int.Parse(Console.ReadLine());
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Tac gia: {TacGia}, So trang: {SoTrang}");
    }
}

class TapChi : TaiLieu
{
    public int SoPhatHanh;
    public int ThangPhatHanh;

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap so phat hanh: ");
        SoPhatHanh = int.Parse(Console.ReadLine());
        Console.Write("Nhap thang phat hanh: ");
        ThangPhatHanh = int.Parse(Console.ReadLine());
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"So phat hanh: {SoPhatHanh}, Thang: {ThangPhatHanh}");
    }
}

class Bao : TaiLieu
{
    public string NgayPhatHanh;

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap ngay phat hanh (dd/MM/yyyy): ");
        NgayPhatHanh = Console.ReadLine();
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Ngay phat hanh: {NgayPhatHanh}");
    }
}