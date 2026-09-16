using System;

class Bai_4
{
    static void Main()
    {
        Console.Write("Moi ban nhap thang: ");
        int thang = int.Parse(Console.ReadLine());

        if (thang >= 1 && thang <= 12)
        {
            int qui = (thang - 1) / 3 + 1;
            Console.WriteLine($"Thang {thang} thuoc qui {qui}.");
        }
        else
        {
            Console.WriteLine("Thang khong hop le!");
        }
    }
}