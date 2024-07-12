using System;

class Program
{
    static void Main()
    {
        // ตรวจสอบปีอธิกสุรทิน
        Console.Write("กรุณาใส่ปี ค.ศ.: ");
        int year = Convert.ToInt32(Console.ReadLine());
        bool isLeapYear = IsLeapYear(year);

        Console.WriteLine($"ปี {year} เป็นปีอธิกสุรทินหรือไม่: {isLeapYear}");

        // คำนวณภาษีรายได้
        Console.Write("กรุณาใส่รายได้ต่อปี (บาท): ");
        double income = Convert.ToDouble(Console.ReadLine());
        double tax = CalculateIncomeTax(income);

        Console.WriteLine($"ภาษีที่ต้องจ่ายสำหรับรายได้ {income} บาท คือ {tax} บาท");
    }

    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    static double CalculateIncomeTax(double income)
    {
        if (income <= 150000)
        {
            return 0;
        }
        else if (income > 150000 && income <= 300000)
        {
            return (income - 150000) * 0.05;
        }
        else if (income > 300000 && income <= 500000)
        {
            return (150000 * 0.05) + ((income - 300000) * 0.10);
        }
        else if (income > 500000)
        {
            return (150000 * 0.05) + (200000 * 0.10) + ((income - 500000) * 0.15);
        }
        else
        {
            throw new ArgumentOutOfRangeException("รายได้ไม่ถูกต้อง");
        }
    }
}
