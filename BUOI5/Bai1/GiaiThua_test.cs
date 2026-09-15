using System;

namespace NMLT.Buoi05
{
    class GiaiThua
    {
        public static void Main(string[] args)
        {
            // Test case 1
            TinhGiaiThua(5);

            // Test case 2
            TinhGiaiThua(1);

            // Test case 3
            TinhGiaiThua(10);
        }

        // Tính giai thừa
        public static void TinhGiaiThua(int n)
        {
            int i;
            long giaiThua = 1;

            // Tính giai thừa
            for (i = 1; i <= n; i++)
            {
                giaiThua = giaiThua * i;
            }

            // Xuất kết quả
            Console.Write("{0}! = ", n);
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0}", i);
                if (i < n)
                    Console.Write(".");
            }
            Console.WriteLine(" = {0}", giaiThua);
        }
    }
}