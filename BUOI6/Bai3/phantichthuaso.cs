using System;

namespace NMLT.Buoi06
{
    public class PhanTichThuaSo1
    {
        public static void Main(string[] args)
        {
            // Khai báo biến
            int n, i;

            // Nhập dữ liệu
            Console.Write("Moi ban nhap so nguyen n: ");
            n = int.Parse(Console.ReadLine());

            // Xử lý và xuất kết quả dạng lũy thừa
            Console.Write("{0} = ", n);

            i = 2; // Xét các thừa số nguyên tố từ 2, 3, ...
            bool first = true; // Dùng để kiểm soát việc in dấu " x " giữa các thừa số

            while (n != 1)
            {
                int dem = 0; // Đếm số mũ của thừa số i

                // Trong khi i còn là ước của n
                while (n % i == 0)
                {
                    dem++;
                    n = n / i;
                }

                // Nếu i là thừa số nguyên tố của n (số mũ > 0)
                if (dem > 0)
                {
                    if (!first)
                    {
                        Console.Write(" x ");
                    }

                    // In ra dạng cơ số và số mũ
                    if (dem == 1)
                    {
                        Console.Write("{0}", i);
                    }
                    else
                    {
                        Console.Write("{0}^{1}", i, dem);
                    }

                    first = false; // Đã in ít nhất một thừa số
                }

                i++; // Tăng i lên để xét thừa số tiếp theo
            }

            Console.WriteLine(); // Xuống dòng sau khi in xong
        }
    }
}