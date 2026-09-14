using System;

namespace DienTichTamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập độ dài 3 cạnh a, b, c
            Console.Write("Nhap do dai canh a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap do dai canh b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhap do dai canh c: ");
            double c = double.Parse(Console.ReadLine());

            // Kiểm tra điều kiện để tạo thành tam giác
            if (a + b > c && a + c > b && b + c > a)
            {
                // Tính nửa chu vi p
                double p = (a + b + c) / 2;

                // Tính diện tích S theo công thức Heron
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                // In kết quả lấy 2 chữ số thập phân (:F2)
                Console.WriteLine($"Dien tich tam giac S = {s:F2}");
            }
            else
            {
                Console.WriteLine("Ba canh tren khong tao thanh mot tam giac hop le!");
            }
        }
    }
}