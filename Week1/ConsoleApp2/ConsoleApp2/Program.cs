using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, years;
            int degree = 0;
            string degreeInput;

            Console.Write("กรุณากรอกอายุ (ตัวเลข): ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("กรุณากรอกวุฒิเป็นภาษาอังกฤษ (เช่น Bachelor degree, Master degree, Doctoral degree, Other): ");
            degreeInput = Console.ReadLine().ToLower().Trim();

            // แปลงวุฒิการศึกษาเป็นตัวเลข
            if (degreeInput == "bachelor degree")
            {
                degree = 1;
            }
            else if (degreeInput == "master degree")
            {
                degree = 2;
            }
            else if (degreeInput == "doctoral degree")
            {
                degree = 3;
            }
            else
            {
                degree = 0; // วุฒิไม่ตรงกับเงื่อนไขใดๆ กำหนดเป็น 0
            }

            Console.Write("กรุณากรอกอายุการทำงาน (ตัวเลข): ");
            years = Convert.ToInt32(Console.ReadLine());

            // ตรวจสอบเกณฑ์
            if (age >= 22 && age <= 35)
            {
                if (degree == 1 && years >= 0)
                {
                    Console.WriteLine("ไม่ผ่านเกณฑ์");
                }
                else if ((degree == 2 || degree == 3) && years >= 0)
                {
                    Console.WriteLine("ผ่านเกณฑ์");
                }
                else
                {
                    Console.WriteLine("ไม่ผ่านเกณฑ์");
                }
            }
            else if (age > 35)
            {
                if (years > 5)
                {
                    Console.WriteLine("ผ่านเกณฑ์");
                }
                else
                {
                    Console.WriteLine("ไม่ผ่านเกณฑ์");
                }
            }
            else
            {
                Console.WriteLine("ไม่ผ่านเกณฑ์");
            }

            Console.ReadKey();
        }
    }
}
