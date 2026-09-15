using System;

namespace NMLT.Buoi05
{
    class GiaTriBieuThuc
    {
        public static void Main(string[] args)
        {
            // Test case 1
            TinhBieuThuc(1);

            // Test case 2
            TinhBieuThuc(5);

            // Test case 3
            TinhBieuThuc(10);
        }

        // Tính giá trị biểu thức
        public static void TinhBieuThuc(int n)
        {
            // Khai báo biến
            int i;
            double s1 = 0, s2 = 0;

            // Tính S1
            for (i = 1; i <= n; i++)
            {
                s1 = s1 + 1.0 / i;
            }

            // Tính S2
            for (i = n; i >= 1; i--)
            {
                if ((n - i) % 2 == 0)
                    s2 = s2 + 1.0 / i;
                else
                    s2 = s2 - 1.0 / i;
            }

            // Xuất kết quả
            Console.WriteLine("S1(n={0}) = {1:F2}", n, s1);
            Console.WriteLine("S2(n={0}) = {1:F2}", n, s2);
            Console.WriteLine();
        }
    }
}