using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Thiết lập chuẩn định dạng toàn cầu để nhập/xuất số thực dùng dấu chấm (.)
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Nhap ban kinh R: ");
        string? input = Console.ReadLine();

        // Kiểm tra tính hợp lệ về kiểu dữ liệu (phải là số thực)
        if (!double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out do0uble r))
        {
            Console.WriteLine("Loi: Du lieu nhap vao khong phai la so hop le.");
            return;
        }

        // Ràng buộc logic hình học: Bán kính phải là số dương (R > 0)
        if (r <= 0)
        {
            Console.WriteLine("Loi: Ban kinh R phai la mot so duong lon hon 0.");
            return;
        }

        // Ràng buộc chống tràn số nếu nhập giá trị quá lớn
        if (double.IsInfinity(r * r))
        {
            Console.WriteLine("Loi: Ban kinh qua lon gay tran so khi tinh dien tich.");
            return;
        }

        // Tính toán chu vi và diện tích
        // Dùng hằng số 3.14 de han che sai so khi tinh toan va lan tron ketv qua
        const double pi = 3.14;
        double s = pi * r * r;
        double p = 2 * pi * r;

        // Xuất kết quả với định dạng làm tròn 1 chữ số thập phân
        Console.WriteLine($"Dien tich S = {s:F1}");
        Console.WriteLine($"Chu vi P = {p:F1}");
    }
}
