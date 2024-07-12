using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("กรุณาใส่ค่าอุณหภูมิ: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        Console.Write("กรุณาใส่หน่วย (C/F/K): ");
        char unit = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (unit)
        {
            case 'C':
                Console.WriteLine("ฟาเรนไฮต์: " + CelsiusToFahrenheit(temp));
                Console.WriteLine("เคลวิน: " + CelsiusToKelvin(temp));
                break;
            case 'F':
                Console.WriteLine("เซลเซียส: " + FahrenheitToCelsius(temp));
                Console.WriteLine("เคลวิน: " + FahrenheitToKelvin(temp));
                break;
            case 'K':
                Console.WriteLine("เซลเซียส: " + KelvinToCelsius(temp));
                Console.WriteLine("ฟาเรนไฮต์: " + KelvinToFahrenheit(temp));
                break;
            default:
                Console.WriteLine("หน่วยไม่ถูกต้อง");
                break;
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
}
