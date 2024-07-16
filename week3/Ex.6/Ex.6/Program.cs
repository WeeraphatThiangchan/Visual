using System;

class Program
{
    static void Main()
    {
        // รับสตริงจากผู้ใช้
        Console.Write("Enter a string:");
        string input = Console.ReadLine();
        
        // เรียกใช้ฟังก์ชันต่าง ๆ และแสดงผลลัพธ์
        string reversedString = ReverseString(input);
        int vowelCount = CountVowels(input);
        string upperCaseString = ConvertToUpperCase(input);

        Console.WriteLine("Reversed string: " + reversedString);
        Console.WriteLine("Number of vowels: " + vowelCount);
        Console.WriteLine("Uppercase string: " + upperCaseString);
    }

    // ฟังก์ชันสำหรับกลับด้านสตริง
    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // ฟังก์ชันสำหรับนับจำนวนสระในสตริง
    static int CountVowels(string input)
    {
        int count = 0;
        string vowels = "aeiouAEIOU";
        foreach (char c in input)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }
        return count;
    }

    // ฟังก์ชันสำหรับแปลงสตริงให้เป็นตัวพิมพ์ใหญ่
    static string ConvertToUpperCase(string input)
    {
        return input.ToUpper();
    }
}
