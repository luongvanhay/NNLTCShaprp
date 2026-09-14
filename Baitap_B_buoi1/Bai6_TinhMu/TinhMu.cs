using System;

namespace TinhMu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập số thực a
            Console.Write("Nhap so thuc a: ");
            double a = double.Parse(Console.ReadLine());

            // Nhập số nguyên n
            Console.Write("Nhap so mu n: ");
            int n = int.Parse(Console.ReadLine());

            // Tính a^n bằng hàm Math.Pow
            double ketQua = Math.Pow(a, n);

            // In kết quả đúng dạng giao diện mẫu
            Console.WriteLine($"Ket qua {a}^{n} = {ketQua}");
        }
    }
}