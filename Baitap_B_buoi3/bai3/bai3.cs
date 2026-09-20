using System;

class bai3
{
    static void Main()
    {
        // 1. Nhập các hệ số a, b, c trên cùng một dòng
        Console.Write("Moi ban nhap he so a, b, c: ");
        string input = Console.ReadLine();
        string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        double a = double.Parse(tokens[0]);
        double b = double.Parse(tokens[1]);
        double c = double.Parse(tokens[2]);

        // 2. Xét trường hợp a = 0 (trở thành phương trình bậc 1: bx + c = 0)
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem.");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                }
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"Phuong trinh co 1 nghiem, x = {x:F2}");
            }
        }
        else
        {
            // 3. Giải phương trình bậc 2 với a != 0
            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine($"Phuong trinh bac 2 {a}x^2 + {b}x + {c} = 0 vo nghiem.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Phuong trinh bac 2 {a}x^2 + {b}x + {c} = 0 co nghiem kep, x1 = x2 = {x:F2}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                // In kết quả theo đúng định dạng mẫu trong hình
                Console.WriteLine($"Phuong trinh bac 2 {a}x^2 + {b}x + {c} = 0 co: 2  nghiem, x1 = {x1:F2},\nx2 = {x2:F2}.");
            }
        }
    }
}