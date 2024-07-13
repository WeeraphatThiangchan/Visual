using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your sentence: ");
        string input = Console.ReadLine();
        Console.WriteLine(); // เพื่อขึ้นบรรทัดใหม่หลังจากการรับอักษร

        if (IsPalindrome(input))
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }

    static bool IsPalindrome(string s)
    {
        // ลบช่องว่างและเครื่องหมายวรรคตอน และทำให้เป็นตัวพิมพ์เล็ก
        string cleaned = new string(s.Where(c => char.IsLetterOrDigit(c)).ToArray()).ToLower();

        int length = cleaned.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (cleaned[i] != cleaned[length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}
