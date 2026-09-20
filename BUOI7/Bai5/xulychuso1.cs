using System;

namespace NNLT.Buoi07
{
    public class XuLyChuSo1
    {
        // Tìm chữ số thứ k tính từ trái sang
        public static int TimChuSoThuK(int n, int k)
        {
            string s = n.ToString();

            if (k < 1 || k > s.Length)
                return -1;

            return s[k - 1] - '0';
        }

        // Tính tổng các chữ số lẻ
        public static int TongChuSoLe(int n)
        {
            int tong = 0;

            n = Math.Abs(n);

            while (n > 0)
            {
                int chuSo = n % 10;

                if (chuSo % 2 != 0)
                {
                    tong += chuSo;
                }

                n /= 10;
            }

            return tong;
        }

        // Tìm chữ số nhỏ nhất
        public static int ChuSoNhoNhat(int n)
        {
            n = Math.Abs(n);

            if (n == 0)
                return 0;

            int min = 9;

            while (n > 0)
            {
                int chuSo = n % 10;

                if (chuSo < min)
                    min = chuSo;

                n /= 10;
            }

            return min;
        }

        // Tìm chữ số lớn nhất
        public static int ChuSoLonNhat(int n)
        {
            n = Math.Abs(n);

            int max = 0;

            while (n > 0)
            {
                int chuSo = n % 10;

                if (chuSo > max)
                    max = chuSo;

                n /= 10;
            }

            return max;
        }

        public static void Main(string[] args)
        {
            int n, k;

            // Nhập dữ liệu
            Console.Write("Moi ban nhap so nguyen n: ");
            n = int.Parse(Console.ReadLine()!);

            Console.Write("Moi ban nhap vi tri k: ");
            k = int.Parse(Console.ReadLine()!);

            // Chữ số thứ k
            int chuSoK = TimChuSoThuK(n, k);

            Console.WriteLine(
                "Chu so o vi tri thu {0} (tinh tu trai sang) cua {1} la {2}.",
                k, n, chuSoK
            );

            // Tổng các chữ số lẻ
            int tong = TongChuSoLe(n);

            Console.WriteLine(
                "Tong cac chu so le cua {0} la {1}.",
                n, tong
            );

            // Nhỏ nhất và lớn nhất
            int min = ChuSoNhoNhat(n);
            int max = ChuSoLonNhat(n);

            Console.WriteLine(
                "{0} co chu so nho nhat la {1} va lon nhat la {2}.",
                n, min, max
            );
        }
    }
}