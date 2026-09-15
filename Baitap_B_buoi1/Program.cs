using System;
class Program
{
    static void Main()
    {
        int t;

        Console.Write("Nhap vao tong so giay: ");
        t = int.Parse(Console.ReadLine());

        int gio = t / 3600;
        int phut = (t % 3600) / 60;
        int giay = t % 60;

        Console.WriteLine($"{t} giay co dang {gio:D2}:{phut:D2}:{giay:D2}");
    }
}