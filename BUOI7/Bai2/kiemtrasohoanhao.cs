using System;

namespace NNLT.Buoi07
{
    public class KiemTraSoHoanHao
    {
        /// <summary>
        /// Đơn thể kiểm tra số hoàn hảo
        /// </summary>
        /// <param name="n">Đầu vào: số nguyên n cần kiểm tra</param>
        /// <returns>true (là số hoàn hảo), false (không phải số hoàn hảo)</returns>
        public static bool LaSoHoanHao(int n)
        {
            int i;
            int tong = 0;

            // Tính tổng các ước số thực sự của n
            for (i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    tong += i;
                }
            }

            // Kiểm tra tổng các ước có bằng n hay không
            if (tong == n)
                return true;
            else
                return false;
        }

        public static void Main(string[] args)
        {
            // Khai báo biến
            int n;
            bool kq;

            // Nhập dữ liệu
            Console.Write("Moi ban nhap n: ");
            n = int.Parse(Console.ReadLine()!);

            // Xử lý
            kq = LaSoHoanHao(n);

            // Xuất kết quả
            if (kq)
            {
                Console.Write(n + " = ");

                // In các ước số của n
                bool dauTien = true;

                for (int i = 1; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        if (!dauTien)
                            Console.Write(" + ");

                        Console.Write(i);
                        dauTien = false;
                    }
                }

                Console.WriteLine(" la so hoan hao.");
            }
            else
            {
                Console.WriteLine("{0} khong la so hoan hao.", n);
            }
        }
    }
}