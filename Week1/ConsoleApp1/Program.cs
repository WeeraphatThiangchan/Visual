// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;
 
 namespace ConsoleApplication1
 {
   
    class Program
    {
       
        static void Main(string[] args)
        {
            double FNumber,SNumber;
            //double SNumber1 = SNumber;
            Console.Write("Enter your FirstNumber = ");
            FNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your SecondNumber = ");
            SNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The Sum(+) of {FNumber} and {SNumber} is " + $"{FNumber + SNumber}.");
            Console.WriteLine($"The result of minus(-) is " + $"{FNumber - SNumber}.");
            Console.WriteLine($"The result of star(*) is " + $"{FNumber * SNumber}.");
            Console.WriteLine($"The result of divine(/) is " + $"{FNumber / SNumber}.");
            Console.WriteLine($"The result of Percent(%) is " + $"{FNumber % SNumber}.");
            //Console.WriteLine($"The result of minus of {FNumber} and {SNumber} is " + $"{FNumber *= SNumber}.");
            Console.WriteLine($"The result of star equal (**) is " + $"{ FNumber *= SNumber}.");
            Console.WriteLine($"The result of plusplus (++) is " + $"{FNumber = SNumber++}.");
            Console.WriteLine($"The result of minus minus (--)  is " + $"{FNumber = --SNumber}.");
            Console.ReadKey();
        }    
    }
 }