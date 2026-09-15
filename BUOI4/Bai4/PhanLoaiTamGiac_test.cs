using System;

namespace NMLT.Buoi04
{
    public class PhanLoaiTamGiac
    {
        public static void Main(string[] args)
        {
            // Test case 1: Tam giác vuông
            PhanLoai(5, 3, 4);

            // Test case 2: Tam giác đều
            PhanLoai(5, 5, 5);

            // Test case 3: Không tạo thành tam giác
            PhanLoai(1, 2, 5);
        }

        // Phân loại tam giác
        public static void PhanLoai(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Ba so ({0}, {1}, {2}) tao thanh duoc tam giac.",
                    a, b, c);

                if (a == b && b == c)
                    Console.WriteLine("Tam giac deu.");
                else if (a == b || a == c || b == c)
                {
                    if (a * a + b * b == c * c ||
                        a * a + c * c == b * b ||
                        b * b + c * c == a * a)
                        Console.WriteLine("Tam giac vuong can.");
                    else
                        Console.WriteLine("Tam giac can.");
                }
                else if (a * a + b * b == c * c ||
                         a * a + c * c == b * b ||
                         b * b + c * c == a * a)
                    Console.WriteLine("Tam giac vuong.");
                else
                    Console.WriteLine("Tam giac thuong.");
            }
            else
                Console.WriteLine("Ba so ({0}, {1}, {2}) khong tao thanh duoc tam giac.",
                    a, b, c);

            Console.WriteLine();
        }
    }
}