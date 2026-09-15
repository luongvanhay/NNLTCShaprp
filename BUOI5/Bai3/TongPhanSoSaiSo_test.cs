using System;

namespace NMLT.Buoi05
{
    class TongPhanSoSaiSo
    {
        public static void Main(string[] args)
        {
            // Test case 1
            TinhTong(1, 0.1);

            // Test case 2
            TinhTong(2, 0.05);

            // Test case 3
            TinhTong(5, 0.01);
        }

        // Tính tổng phân số
        public static void TinhTong(double a, double epsilon)
        {
            // Khai báo biến
            double s = 0;
            int n;

            // Tính tổng
            for (n = 0; 1.0 / (a + n) >= epsilon; n++)
            {
                s = s + 1.0 / (a + n);
            }

            // Xuất kết quả
            Console.WriteLine(
                "Gia tri cua bieu thuc S(a = {0}, epsilon = {1}) = {2:F4}.",
                a, epsilon, s);
        }
    }
}