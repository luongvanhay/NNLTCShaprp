using System;

class Bai_1
{
    static void Main()
    {
        Console.Write("Moi ban nhap so a, b: ");
        string[] input = Console.ReadLine().Split();
        
        long a = long.Parse(input[0]);
        long b = long.Parse(input[1]);

        long tong = 0;
        for (long i = a; i <= b; i++)
        {
            tong += i;
        }

        Console.WriteLine($"Tong cua cac so trong doan[{a}, {b}] la {tong}.");
    }
}