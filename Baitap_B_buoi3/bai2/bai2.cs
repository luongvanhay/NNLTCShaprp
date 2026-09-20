using System;

class bai2
{
    static void Main()
    {
        // 1. Nhập số thực x từ bàn phím
        Console.Write("Nhap x: ");
        double x = double.Parse(Console.ReadLine());

        // 2. Tính f1(x)
        double f1;
        if (x <= 0)
        {
            f1 = 0;
        }
        else if (x <= 1) // Do đã qua điều kiện x > 0 nên x <= 1 tương đương 0 < x <= 1
        {
            f1 = x;
        }
        else
        {
            f1 = Math.Pow(x, 4); // x^4
        }

        // 3. Tính f2(x)
        double f2;
        if (x <= 2)
        {
            f2 = x * x + 4 * x + 5;
        }
        else
        {
            f2 = 1.0 / (x * x + 4 * x + 5);
        }

        // 4. In kết quả ra màn hình
        Console.WriteLine($"f1({x}) = {f1}");
        Console.WriteLine($"f2({x}) = {f2}");
    }
}