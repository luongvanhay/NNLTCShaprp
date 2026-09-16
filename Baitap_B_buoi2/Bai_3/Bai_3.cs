using System;

class Bai_3
{
    static void Main()
    {
        Console.Write("Moi ban nhap so thuc x: ");
        double x = double.Parse(Console.ReadLine());

        // Tách ra tính từng lũy thừa (vẫn đảm bảo không vượt quá 8 phép toán)
        double x2 = x * x;         // Phép 1: x^2
        double x3 = x2 * x;        // Phép 2: x^3

        // Tính kết quả
        double fx = 1 + 2 * x + 3 * x2 - 4 * x3; // Phép 3,4,5,6,7,8

        Console.WriteLine($"f({x}) = {fx}");
    }
}