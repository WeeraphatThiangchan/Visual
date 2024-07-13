using System;

public class SimpleCalculator
{
    public static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Enter operation (+, -, *, /): ");
        char operation = Console.ReadKey().KeyChar; // รับตัวอักษรจากคีย์บอร์ด

        Console.WriteLine(); // เพื่อขึ้นบรรทัดใหม่หลังจากการรับอักษร

        double result = PerformOperation(num1, num2, operation); // เรียกใช้ฟังก์ชัน PerformOperation เพื่อทำการคำนวณ

        Console.WriteLine($"The result is: {result}"); // แสดงผลลัพธ์
    }

    // ฟังก์ชันที่ใช้ในการทำการคำนวณ
    static double PerformOperation(double num1, double num2, char operation)
    {
        double result = 0;
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                // ตรวจสอบเงื่อนไขหารด้วย 0
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero!");
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operation!");
                break;
        }
        return result;
    }
}
