using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    static void Main(string[] args)
    {
        Console.Write("กรุณาใส่ค่าอุณหภูมิ: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        Console.Write("กรุณาใส่หน่วย (C/F/K): ");
        char unit = Convert.ToChar(Console.ReadLine().ToUpper());

        Console.Write("กรุณาใส่หน่วยที่ต้องการแปลง (C/F/K): ");
        char convert1 = Convert.ToChar(Console.ReadLine().ToUpper());

        if (unit == 'C' && convert1 == 'C')
        {
            Console.WriteLine($"เซลเซียส : {temp}");
        }
        else if (unit == 'C' && convert1 == 'F')
        {
            Console.WriteLine("ฟาเรนไฮต์: " + CelsiusToFahrenheit(temp));
        }
        else if (unit == 'C' && convert1 == 'K')
        {
            Console.WriteLine("เคลวิน: " + CelsiusToKelvin(temp));
        }
        else if (unit == 'F' && convert1 == 'C')
        {
            Console.WriteLine("เซลเซียส: " + FahrenheitToCelsius(temp));
        }
        else if (unit == 'F' && convert1 == 'F')
        {
            Console.WriteLine($"ฟาเรนไฮต์ : {temp}");
        }
        else if (unit == 'F' && convert1 == 'K')
        {
            Console.WriteLine("เคลวิน: " + FahrenheitToKelvin(temp));
        }
        else if (unit == 'K' && convert1 == 'C')
        {
            Console.WriteLine("เซลเซียส: " + KelvinToCelsius(temp));
        }
        else if (unit == 'K' && convert1 == 'F')
        {
            Console.WriteLine("ฟาเรนไฮต์: " + KelvinToFahrenheit(temp));
        }
        else if (unit == 'K' && convert1 == 'K')
        {
            Console.WriteLine($"เคลวิน : {temp}");
        }
        else
        {
            Console.WriteLine("กรุณากรอกใหม่");
        }
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double CelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static double FahrenheitToKelvin(double fahrenheit)
    {
        return (fahrenheit + 459.67) * 5 / 9;
    }

    static double KelvinToCelsius(double kelvin)
    {
        return kelvin - 273.15;
    }

    static double KelvinToFahrenheit(double kelvin)
    {
        return (kelvin * 9 / 5) - 459.67;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
