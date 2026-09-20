using System;

namespace NNLT.Buoi07
{
    public class NgayTruoc
    {
        // Kiểm tra năm nhuận
        public static bool LaNamNhuan(int nam)
        {
            if (nam % 400 == 0)
                return true;

            if (nam % 100 == 0)
                return false;

            return nam % 4 == 0;
        }

        // Tìm số ngày của một tháng
        public static int SoNgayTrongThang(int thang, int nam)
        {
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;

                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;

                case 2:
                    if (LaNamNhuan(nam))
                        return 29;
                    else
                        return 28;

                default:
                    return 0;
            }
        }

        // Tìm ngày trước đó
        public static void TimNgayTruoc(
            int ngay, int thang, int nam,
            out int ngayTruoc, out int thangTruoc, out int namTruoc)
        {
            if (ngay > 1)
            {
                ngayTruoc = ngay - 1;
                thangTruoc = thang;
                namTruoc = nam;
            }
            else
            {
                if (thang > 1)
                {
                    thangTruoc = thang - 1;
                    namTruoc = nam;
                }
                else
                {
                    thangTruoc = 12;
                    namTruoc = nam - 1;
                }

                ngayTruoc = SoNgayTrongThang(thangTruoc, namTruoc);
            }
        }

        public static void Main(string[] args)
        {
            int ngay, thang, nam;
            int ngayTruoc, thangTruoc, namTruoc;

            // Nhập dữ liệu
            Console.Write("Moi ban nhap ngay: ");
            ngay = int.Parse(Console.ReadLine()!);

            Console.Write("Moi ban nhap thang: ");
            thang = int.Parse(Console.ReadLine()!);

            Console.Write("Moi ban nhap nam: ");
            nam = int.Parse(Console.ReadLine()!);

            // Xử lý
            TimNgayTruoc(
                ngay, thang, nam,
                out ngayTruoc, out thangTruoc, out namTruoc
            );

            // Xuất kết quả
            Console.WriteLine(
                "Ngay truoc {0}/{1}/{2} la ngay {3}/{4}/{5}.",
                ngay, thang, nam,
                ngayTruoc, thangTruoc, namTruoc
            );
        }
    }
}