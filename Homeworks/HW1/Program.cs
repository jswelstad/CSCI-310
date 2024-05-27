using System;

namespace HW1Types
{
    public class HW1Types
    {
        static void Main(string[] args)
        {
            int num = 42;
            double num2 = 0.42;
            char character = 'c';
            string word = "Cool";
            
            Console.WriteLine("Before changing values:");
            Console.WriteLine($"int = {num}");
            Console.WriteLine($"double = {num2}");
            Console.WriteLine($"char = {character}");
            Console.WriteLine($"string = {word}");
            
            Console.WriteLine("After changing the values:");
            
            num = 505;
            num2 = 0.0001;
            character = 'z';
            word = "Beans";
            
            Console.WriteLine("After changing values:");
            Console.WriteLine($"int = {num}");
            Console.WriteLine($"double = {num2}");
            Console.WriteLine($"char = {character}");
            Console.WriteLine($"string = {word}");

            int a = 4;
            int b = 5;
            int c = 6;
            double s = (a + b + c) / 2.0;

            double area = Math.Sqrt(s * ((s - a) * (s - b) * (s - c)));
            
            Console.WriteLine($"Area of triangle with sides {a}, {b}, and {c} is {area}");
            




        }
    }
}

