using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("กรุณาใส่ค่าของ n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("คู่ของจำนวนเฉพาะคู่แฝดที่พบ:");
        int count = 0;
        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i) && IsPrime(i + 2) && (i + 2) <= n)
            {
                Console.WriteLine($"({i}, {i + 2})");
                count++;
            }
        }
        Console.WriteLine($"จำนวนคู่แฝดทั้งหมดที่พบ: {count}");
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}
