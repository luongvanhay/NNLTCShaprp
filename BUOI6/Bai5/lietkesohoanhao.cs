using System;
namespace NMLT.Buoi06
{
    public class LietKeSoHoanHao
    {
        public static void Main (string[] args)
        {
            // Khai báo biến
            int n;
            // Nhập dữ liệu
            Console.Write("Moi ban nhap so n: ");
            n = int.Parse(Console.ReadLine());
            // Tìm và liệt kê các số hoàn hảo trong đoạn [1,n] 
            Console.Write("Cac so hoan hao trong doan [1, {0}]: ", n);
            bool first = true;

            // Duyệt theo thứ tự giảm dần
            for (int i = n; i>=1; i--)
            {
                // Kiểm tra xem i có phải là số hoàn hảo không
                int tonguoc = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        tonguoc += j;
                    }
                }
                // Nếu i là số hoàn hảo (tổng các ước thực sự bằng chính nó)
             if (tonguoc == i && i > 0)
                {
                    if (first)
                    {
                        Console.Write("{0}", i);
                        first = false;
                    }
                    else
                    {
                        Console.Write(" {0}", i); // Hoặc điều chỉnh định dạng khoảng cách/dấu phẩy nếu cần
                    }
                }
            }
            Console.WriteLine(); // Xuống dòng kết thúc chương trình
        }
    }
}