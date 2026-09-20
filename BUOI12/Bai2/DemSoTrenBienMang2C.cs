using System;

namespace NMLT.Buoi12
{
    class DemSoTrenBienMang2C
    {
        public static void Main(string[] args)
        {
            // Khai báo biến
            int n, m;
            int soDuong = 0, soAm = 0, soKhong = 0;

            // Nhập dữ liệu
            Console.Write("Moi ban nhap so dong n: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Moi ban nhap so cot m: ");
            m = int.Parse(Console.ReadLine());

            double[,] A = new double[n, m];

            // Nhập ma trận A
            Console.WriteLine("Moi ban nhap ma tran A:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = double.Parse(Console.ReadLine());
                }
            }

            // Đếm số trên biên
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // Kiểm tra phần tử có nằm trên biên
                    if (i == 0 || i == n - 1 || j == 0 || j == m - 1)
                    {
                        if (A[i, j] > 0)
                            soDuong++;
                        else if (A[i, j] < 0)
                            soAm++;
                        else
                            soKhong++;
                    }
                }
            }

            // Xuất kết quả
            Console.WriteLine(
                "Tren duong bien co {0} so duong, {1} so am va {2} so khong.",
                soDuong, soAm, soKhong);
        }
    }
}