using System;

class Bai_2
{
    static void Main()
    {
        Console.Write("Moi ban nhap so thuc a: ");
        double a = double.Parse(Console.ReadLine());

        // 6 phep nhan
        double a2 = a * a;       // 1: a^2
        double a4 = a2 * a2;     // 2: a^4
        double a5 = a4 * a;      // 3: a^5
        double a8 = a4 * a4;     // 4: a^8
        double a16 = a8 * a8;    // 5: a^16
        double a17 = a16 * a;    // 6: a^17

        Console.WriteLine($"Ket qua: {a}^2={a2:F2}, {a}^5={a5:F2}, {a}^17={a17:F2}.");
    }
}