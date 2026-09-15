using System;

namespace NMLT.Buoi04
{
    public class TienNuoc
    {
        // Hằng số của chương trình
        const int GIA4 = 4400, GIA6 = 8300, GIA_TREN_6 = 10500;
        const double VAT = 0.05, PHI_MOI_TRUONG = 0.1;

        public static void Main(string[] args)
        {
            // Test case 1
            TinhTienNuoc(10, 15, 2);

            // Test case 2
            TinhTienNuoc(10, 20, 2);

            // Test case 3
            TinhTienNuoc(10, 30, 2);
        }

        // Hàm tính tiền nước
        public static void TinhTienNuoc(int chiSoCu, int chiSoMoi, int soNguoi)
        {
            int m3;
            double soTien;

            // Tính số m3 nước tiêu thụ
            m3 = chiSoMoi - chiSoCu;

            // Tính tiền nước
            if (m3 <= 4 * soNguoi)
                soTien = m3 * GIA4;
            else if (m3 <= 6 * soNguoi)
                soTien = 4 * soNguoi * GIA4
                       + (m3 - 4 * soNguoi) * GIA6;
            else
                soTien = 4 * soNguoi * GIA4
                       + 2 * soNguoi * GIA6
                       + (m3 - 6 * soNguoi) * GIA_TREN_6;

            // Tính VAT và phí môi trường
            soTien = soTien * (1 + VAT + PHI_MOI_TRUONG);

            // Xuất kết quả
            Console.WriteLine("Chi so cu: {0}, Chi so moi: {1}, So nguoi: {2}", 
                chiSoCu, chiSoMoi, soNguoi);
            Console.WriteLine("So tien phai tra cho {0} m3 la {1:#,#} Đ.", m3, soTien);
            Console.WriteLine();
        }
    }
}