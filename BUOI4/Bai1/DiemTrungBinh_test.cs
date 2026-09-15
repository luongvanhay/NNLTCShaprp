using System;

namespace NMLT.Buoi04
{
    public class DiemTrungBinh
    {
        // Hằng số của chương trình
        const double GIOI = 8, KHA = 6.5, TRUNG_BINH = 5;

        public static void Main(string[] args)
        {
            // Test case 1
            double toan = 9, ly = 8, hoa = 9;
            TinhDiem(toan, ly, hoa);

            // Test case 2
            toan = 7; ly = 6; hoa = 8;
            TinhDiem(toan, ly, hoa);

            // Test case 3
            toan = 4; ly = 5; hoa = 3;
            TinhDiem(toan, ly, hoa);
        }

        // Hàm tính và xếp loại
        public static void TinhDiem(double toan, double ly, double hoa)
        {
            double dtb;
            string xepLoai;

            // Tính điểm trung bình
            dtb = (toan * 2 + ly * 3 + hoa) / 6;

            // Xếp loại
            if (dtb >= GIOI)
                xepLoai = "Gioi";
            else if (dtb >= KHA)
                xepLoai = "Kha";
            else if (dtb >= TRUNG_BINH)
                xepLoai = "Trung binh";
            else
                xepLoai = "Yeu";

            // Xuất kết quả
            Console.WriteLine("Diem: {0} {1} {2} -> DTB = {3:F2}, Xep loai: {4}",
                toan, ly, hoa, dtb, xepLoai);
        }
    }
}