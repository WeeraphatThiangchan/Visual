using System;

class Program
{
    static void Main()
    {
        // รับค่าอินพุตเป็นสตริงของตัวเลขที่คั่นด้วยช่องว่าง
        Console.Write("กรุณากรอกตัวเลขและเว้นช่องทีละตัว เช่น (1 2 3):");
        string input = Console.ReadLine();
        
        // แยกสตริงเป็นอาร์เรย์ของสตริงตามช่องว่าง
        string[] inputArray = input.Split(' ');
        
        // แปลงอาร์เรย์ของสตริงให้เป็นอาร์เรย์ของตัวเลข (int[])
        int[] numbers = Array.ConvertAll(inputArray, int.Parse);

        // หาผลรวมของตัวเลขที่เป็นจำนวนเฉพาะ
        int sumOfPrimes = SumOfPrimeNumbers(numbers);

        // แสดงผลรวมของจำนวนเฉพาะในอาร์เรย์
        Console.WriteLine("The sum of prime numbers in the array is: " + sumOfPrimes);
    }

    // ฟังก์ชันสำหรับหาผลรวมของจำนวนเฉพาะในอาร์เรย์
    static int SumOfPrimeNumbers(int[] numbers)
    {
        int sum = 0; // ตัวแปรสำหรับเก็บผลรวมของจำนวนเฉพาะ
        
        // วนลูปผ่านอาร์เรย์ของตัวเลข
        foreach (int number in numbers)
        {
            // ถ้าตัวเลขเป็นจำนวนเฉพาะ ให้เพิ่มค่าตัวเลขนั้นไปยังผลรวม
            if (IsPrime(number))
            {
                sum += number;
            }
        }
        
        return sum; // คืนค่าผลรวมของจำนวนเฉพาะ
    }

    // ฟังก์ชันสำหรับตรวจสอบว่าตัวเลขเป็นจำนวนเฉพาะหรือไม่
    static bool IsPrime(int number)
    {
        if (number <= 1) return false; // ถ้าตัวเลขน้อยกว่าหรือเท่ากับ 1 จะไม่เป็นจำนวนเฉพาะ
        if (number == 2) return true;  // ถ้าตัวเลขคือ 2 จะเป็นจำนวนเฉพาะ
        if (number % 2 == 0) return false; // ถ้าตัวเลขหารด้วย 2 ลงตัวจะไม่เป็นจำนวนเฉพาะ

        // ตรวจสอบตัวหารจาก 3 ถึงรากที่สองของตัวเลข
        int boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
        {
            // ถ้าตัวเลขหารด้วยจำนวนใดๆ ลงตัวจะไม่เป็นจำนวนเฉพาะ
            if (number % i == 0) return false;
        }

        return true; // ถ้าไม่เจอตัวหารใดๆ แสดงว่าเป็นจำนวนเฉพาะ
    }
}
