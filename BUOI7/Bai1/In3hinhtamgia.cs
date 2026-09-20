using System;

namespace NNLT.Buoi07
{
    class In3HinhTamGiac
    {
        static void InHinhTamGiac(int h)
        {
            for (int i = 1; i <= h; i++)
            {
                // In khoảng trắng
                for (int j = 1; j <= h - i; j++)
                {
                    Console.Write("  ");
                }

                // In dấu *
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Moi ban nhap chieu cao h: ");
            int h = int.Parse(Console.ReadLine()!);

            Console.WriteLine();
            Console.WriteLine("h = " + h);
            InHinhTamGiac(h);

            Console.WriteLine();
            Console.WriteLine("h = " + (h + 2));
            InHinhTamGiac(h + 2);

            Console.WriteLine();
            Console.WriteLine("h = " + (h + 4));
            InHinhTamGiac(h + 4);
        }
    }
}