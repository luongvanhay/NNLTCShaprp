using System;

class Bai_5
{
    static void Main()
    {
        Console.Write("Moi ban nhap so nguyen n: ");
        int n = int.Parse(Console.ReadLine());

        long ketQua = 1;
        int coSo = n % 100; // Chỉ cần lấy 2 chữ số cuối của n

        for (int i = 0; i < 278; i++)
        {
            ketQua = (ketQua * coSo) % 100;
        }

        Console.WriteLine($"{n}^278 co 2 chu so cuoi cung la {ketQua:D2}.");
    }
}