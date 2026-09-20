using System;
namespace NNLT.Buoi6
{
    public class kiemtrasohoanhao
    {
        public static void Main(string[] args)
        {
            // khai báo biến
            int n;
            int tonguoc = 0;
            // nhập dữ liệu
            Console.Write("Moi ban nhap n: ");
            n = int.Parse(Console.ReadLine());

            // Duyệt tìm các ước số thực sự của n 
            string chitietuoc = "";
            bool first = true;

            for (int i = 1; i<n; i++)
            {
                if(n % i ==0)
                {
                    tonguoc += i;
                    if(first)
                    {
                        chitietuoc += i;
                        first = false;
                    }
                    else
                    {
                        chitietuoc += "+" + i;
                    }
                }
            }
            // Kiểm tra và xuất kết quả
            if (tonguoc == n && n > 0)
            {
                Console.WriteLine("{0} = {1} la so hoan hao.", n, chitietuoc);
            }
            else
            {
                Console.WriteLine("{0} khong the la so hoan hao.", n);
            }
        }
    }
}