using System;

namespace NMLT.Buoi04
{
    public class NgaySau
    {
        public static void Main(string[] args)
        {
            // Test case 1
            TinhNgaySau(31, 1, 2015);

            // Test case 2
            TinhNgaySau(28, 2, 2015);

            // Test case 3
            TinhNgaySau(31, 12, 2015);
        }

        // Tìm ngày sau
        public static void TinhNgaySau(int ngay, int thang, int nam)
        {
            int ngayCu = ngay;
            int thangCu = thang;
            int namCu = nam;
            int soNgay = 31;

            // Tìm số ngày trong tháng
            if (thang == 2)
            {
                if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0))
                    soNgay = 29;
                else
                    soNgay = 28;
            }
            else if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
                soNgay = 30;

            // Tìm ngày sau
            ngay++;

            if (ngay > soNgay)
            {
                ngay = 1;
                thang++;

                if (thang > 12)
                {
                    thang = 1;
                    nam++;
                }
            }

            // Xuất kết quả
            Console.WriteLine("Ngay sau ngay {0}/{1}/{2} la ngay {3}/{4}/{5}.",
                ngayCu, thangCu, namCu, ngay, thang, nam);
        }
    }
}