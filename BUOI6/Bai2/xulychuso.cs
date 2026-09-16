using System;

namespace NMLT.Buoi06
{
    public class XuLyChuSo1
    {
        public static void Main(string[] args)
        {
            // Khai báo biến
            int n, n1, k;
            int chuso_k = 0, tong_le = 0;
            int min_le = -1, max_le = -1;

            // Nhập dữ liệu
            Console.Write("Moi ban nhap so nguyen n: ");
            n = int.Parse(Console.ReadLine());
            
            Console.Write("Moi ban nhap vi tri k: ");
            k = int.Parse(Console.ReadLine());

            // Xử lý tìm chữ số ở vị trí k (tính từ trái sang)
            // Cách làm: Chuyển n thành chuỗi để dễ đếm và lấy vị trí k từ trái qua
            string s = n.ToString();
            if (k >= 1 && k <= s.Length)
            {
                // Chuyển ký tự tại vị trí k-1 về số nguyên
                chuso_k = int.Parse(s[k - 1].ToString());
            }

            // Xử lý các chữ số lẻ (tổng, nhỏ nhất, lớn nhất) bằng cách duyệt từ phải qua trái giống bài mẫu
            n1 = n;
            // Xử lý trường hợp số âm nếu có (để lấy giá trị tuyệt đối khi tách chữ số)
            if (n1 < 0) n1 = -n1;

            // Trường hợp đặc biệt nếu n = 0
            if (n1 == 0)
            {
                // 0 là số chẵn, không có chữ số lẻ
            }

            while (n1 != 0)
            {
                int cs = n1 % 10; // Chữ số ở vị trí cuối

                // Kiểm tra chữ số lẻ
                if (cs % 2 != 0)
                {
                    tong_le += cs;

                    // Tìm chữ số lẻ nhỏ nhất và lớn nhất
                    if (min_le == -1) // Nếu chưa có chữ số lẻ nào được gán
                    {
                        min_le = cs;
                        max_le = cs;
                    }
                    else
                    {
                        if (min_le > cs) min_le = cs;
                        if (max_le < cs) max_le = cs;
                    }
                }

                n1 = n1 / 10; // Dịch n qua phải
            }

            // Xuất kết quả
            Console.WriteLine("Chu so o vi tri {0} (tinh tu trai) cua {1} la {2}.", k, n, chuso_k);
            Console.WriteLine("Tong cac chu so le cua {0} la {1}.", n, tong_le);
            
            if (min_le == -1)
            {
                Console.WriteLine("{0} khong co chu so le nao.", n);
            }
            else
            {
                Console.WriteLine("{0} co chu so le nho nhat la {1} va lon nhat la {2}.", n, min_le, max_le);
            }
        }
    }
}