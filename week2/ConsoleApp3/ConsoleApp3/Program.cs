using System;
using System.Linq;

namespace ConsoleApplication3
{
    class Program
    {
        static void CheckPassword()
        {
            string password;
            bool upper = false;
            bool lower = false;
            bool digit = false;
            bool hasSpecialChar = false;
            char[] specialChars = { '!', '@', '#', '$', '%', '^', '&', '*' };

            Console.Write("Enter your password: ");
            password = Console.ReadLine();

            if (password.Length >= 8)
            {
                upper = password.Any(char.IsUpper);
                lower = password.Any(char.IsLower);
                digit = password.Any(char.IsDigit);

                foreach (char c in password)
                {
                    if (specialChars.Contains(c))
                    {
                        hasSpecialChar = true;
                        break;
                    }
                }

                if (upper && lower && digit && hasSpecialChar)
                {
                    Console.WriteLine("รหัสของคุณผ่าน");
                }
                else
                {
                    Console.WriteLine("รหัสของคุณไม่ผ่าน กรุณากรอกใหม่");
                }
            }
            else
            {
                Console.WriteLine("รหัสของคุณไม่ผ่าน กรุณากรอกใหม่ รหัสอย่างน้องต้อง8ตัว");
            }
        }

        static void Main(string[] args)
        {
            CheckPassword();
        }
    }
}
