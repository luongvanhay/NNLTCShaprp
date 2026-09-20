using System;

namespace NMLT.Buoi06
{
    class MaTranToanLe
    {
        public static void Main(string[] args)
        {
            // Khai báo biến
            int n, m;
            bool toanLe = true;

            // Nhập dữ liệu
            Console.Write("Moi ban nhap so dong n: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Moi ban nhap so cot m: ");
            m = int.Parse(Console.ReadLine());

            int[,] A = new int[n, m];

            // Nhập ma trận A
            Console.WriteLine("Moi ban nhap ma tran A:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Kiểm tra ma trận toàn lẻ
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (A[i, j] % 2 == 0)
                    {
                        toanLe = false;
                    }
                }
            }

            // Xuất kết quả
            if (toanLe)
                Console.WriteLine("Mang A toan le!");
            else
                Console.WriteLine("Mang A khong toan le!");
        }
    }
}