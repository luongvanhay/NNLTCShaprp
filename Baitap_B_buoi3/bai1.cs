using System;

class bai1
{
    static void Main()
    {
        // 1. Khai báo mảng chứa 5 số nguyên
        int[] numbers = new int[5];

        Console.Write("Moi ban nhap 5 so a, b, c, d ,e: ");

        // 2. Nhập lần lượt từng số (hoặc nhập trên cùng 1 dòng cách nhau bằng khoảng trắng)
        string input = Console.ReadLine();
        string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(tokens[i]);
        }

        // 3. Giả sử số đầu tiên (index 0) là Max và Min
        int max = numbers[0];
        int min = numbers[0];

        // 4. Duyệt qua các số còn lại để tìm Max và Min thực sự
        for (int i = 1; i < 5; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }

            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        // 5. In kết quả theo đúng định dạng
        Console.WriteLine($"Gia tri lon nhat cua {numbers[0]}, {numbers[1]}, {numbers[2]}, {numbers[3]}, {numbers[4]} la {max}.");
        Console.WriteLine($"Gia tri nho nhat cua {numbers[0]}, {numbers[1]}, {numbers[2]}, {numbers[3]}, {numbers[4]} la {min}.");
    }
}