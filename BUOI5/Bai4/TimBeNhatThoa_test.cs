using System;

namespace NMLT.Buoi05
{
    class TimBeNhatThoa
    {
        public static void Main(string[] args)
        {
            // Test case 1
            TimN(1);

            // Test case 2
            TimN(2);

            // Test case 3
            TimN(3);
        }

        // Tìm n bé nhất
        public static void TimN(double a)
        {
            // Khai báo biến
            double s = 0;
            int n = 0;

            // Tìm n
            while (s <= a)
            {
                n++;
                s = s + 1.0 / n;
            }

            // Xuất kết quả
            Console.WriteLine("a = {0}: n be nhat = {1}, S = {2:F4}", a, n, s);
        }
    }
}