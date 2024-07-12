using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("กรุณาใส่จำนวนสถานีที่เดินทาง: ");
        int stations = Convert.ToInt32(Console.ReadLine());

        int fare;

        if (stations >= 1 && stations <= 3)
        {
            fare = 16;
        }
        else if (stations >= 4 && stations <= 8)
        {
            fare = 23;
        }
        else if (stations >= 9)
        {
            fare = 31;
        }
        else
        {
            Console.WriteLine("จำนวนสถานีไม่ถูกต้อง");
            return;
        }

        Console.WriteLine("ค่าโดยสารคือ: " + fare + " บาท");
    }
}
