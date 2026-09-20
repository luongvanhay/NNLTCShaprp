using System;

namespace NNLT.Buoi07
{
    public class TinhSoPi
    {
        /// <summary>
        /// Tính số Pi
        /// </summary>
        /// <param name="epsilon">Sai số cho phép</param>
        /// <returns>Giá trị gần đúng của số Pi</returns>
        public static double tinhSoPi(double epsilon)
        {
            double pi = 0;
            int i = 0;
            double soHang;

            do
            {
                soHang = 4.0 / (2 * i + 1);

                if (i % 2 == 0)
                {
                    pi += soHang;
                }
                else
                {
                    pi -= soHang;
                }

                i++;

            } while (soHang >= epsilon);

            return pi;
        }

        public static void Main(string[] args)
        {
            double epsilon;
            double pi;
            double saiSo;

            // Nhập sai số
            Console.Write("Moi ban nhap do sai so epsilon: ");
            epsilon = double.Parse(Console.ReadLine()!);

            // Tính Pi
            pi = tinhSoPi(epsilon);

            // Tính sai số thực tế
            saiSo = Math.Abs(Math.PI - pi);

            // Xuất kết quả
            Console.WriteLine("So pi tinh duoc la {0}", pi);
            Console.WriteLine("Do sai so thuc te la {0}", saiSo);
        }
    }
}