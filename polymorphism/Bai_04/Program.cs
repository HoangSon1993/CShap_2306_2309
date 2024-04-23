// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

using System.Text;
using Bai_04;


internal class Program()
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        CongTy d = new CongTy();
        d.Xuat();
        Console.WriteLine($"Tổng tiền điện: {d.TongTienDien}");
        Console.WriteLine($"Tiêu thu ít nhất: {d.TieuThuItNhat()}");
    }
}