using System;

namespace NMLT.Buoi12
{
    class TongChanLeMang2C
    {
        public static void Main(string[] args)
        {
            // Khai báo biến
            int n, m;
            int tongChan = 0, tongLe = 0;

            // Nhập dữ liệu
            Console.Write("Moi ban nhap so dong n: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Moi ban nhap so cot m: ");
            m = int.Parse(Console.ReadLine());

            int[,] A = new int[n, m];

            // Nhập A
            Console.WriteLine("Moi ban nhap ma tran A:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Tính tổng số chẵn, số lẻ
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (A[i, j] % 2 == 0)
                        tongChan = tongChan + A[i, j];
                    else
                        tongLe = tongLe + A[i, j];
                }
            }

            // Xuất kết quả
            Console.WriteLine("Tong cac so chan la {0} va tong so le la {1}.",
                tongChan, tongLe);
        }
    }
}