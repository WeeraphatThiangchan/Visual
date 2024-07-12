using System;

class Program
{
    static void Main()
    {
        Console.Write("กรุณาใส่น้ำหนักของสินค้า (กิโลกรัม): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        double shippingCost = CalculateShippingCost(weight);

        Console.WriteLine($"ค่าส่งสำหรับน้ำหนัก {weight} กก. คือ {shippingCost} บาท");
    }

    static double CalculateShippingCost(double weight)
    {
        if (weight >= 0 && weight <= 1)
        {
            return 50;
        }
        else if (weight > 1 && weight <= 5)
        {
            return 100;
        }
        else if (weight > 5 && weight <= 10)
        {
            return 200;
        }
        else if (weight > 10)
        {
            return 250;
        }
        else
        {
            throw new ArgumentOutOfRangeException("น้ำหนักไม่ถูกต้อง");
        }
    }
}
