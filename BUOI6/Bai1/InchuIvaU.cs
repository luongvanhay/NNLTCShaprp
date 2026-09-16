using System;

namespace NNLT.Buoi06
{
    public class InchuIvaU
    {
        public static void Main(string[] args)
        {
            // Khai báo biến
            int h, i, j;

            // Nhập dữ liệu
            Console.Write("Moi ban nhap chieu cao h: ");
            h = int.Parse(Console.ReadLine()!);

            Console.Write("Chu I va U ung voi h = " + h + " la:");

            // Xuống dòng
            Console.WriteLine();

            // Thiết lập màu chữ
            Console.ForegroundColor = ConsoleColor.Red;

            // In chữ I
            for (i = 1; i <= h; i++)
            {
                if (i == 1 || i == h)
                {
                    // Nếu là dòng đầu hoặc dòng cuối
                    // thì in toàn bộ các cột
                    for (j = 1; j <= h; j++)
                    {
                        Console.Write("* ");
                    }
                }
                else
                {
                    // Các dòng ở giữa chỉ in * ở cột giữa
                    for (j = 1; j <= h; j++)
                    {
                        if (j == (h + 1) / 2)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                }

                // Khoảng cách giữa I và U
                Console.Write("   ");

                // In chữ U
                for (j = 1; j <= h; j++)
                {
                    if (j == 1 || j == h || i == h)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }

                // Xuống dòng
                Console.WriteLine();
            }

            // Trả lại màu chữ mặc định
            Console.ResetColor();
        }
    }
}