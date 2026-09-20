using System;

namespace NMLT.Buoi12
{
    class DongTangDan
    {
        public static void Main(string[] args)
        {
            // Khai báo biến
            int n, m;
            bool tang;

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

            // Xuất các dòng tăng
            Console.Write("Cac dong tao thanh day tang: ");

            for (int i = 0; i < n; i++)
            {
                tang = true;

                // Kiểm tra từng dòng
                for (int j = 0; j < m - 1; j++)
                {
                    if (A[i, j] >= A[i, j + 1])
                    {
                        tang = false;
                    }
                }

                if (tang)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}