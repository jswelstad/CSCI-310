using System;

namespace HW14Delegates
{
    public class HW14Delegates
    {
        public delegate void MultiDelegate(int n1);
        static void FindArea(int radius)
        {
            Console.WriteLine($"Area: {Math.PI * Math.Pow(radius, 2)}");
        }

        static void FindCircumference(int radius)
        {
            Console.WriteLine($"Circumference: {2 * Math.PI * radius}");
        }

        static int FuncCountString(string word)
        {
            return word.Length;
        }

        static void ActionCountString(string word)
        {
            Console.WriteLine($"The length of {word} is {word.Length}");
        }

        static bool IsCool(string word)
        {
            return word.Contains("cool");
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of the circle");
            int radius = int.Parse(Console.ReadLine());

            MultiDelegate myDelegate = FindArea;
            myDelegate += FindCircumference;

            Console.WriteLine("From multicast delegate");
            myDelegate(radius);

            Func<string, int> FCount = FuncCountString;
            Console.WriteLine($"From func delegate: The length of hello is {FCount("Hello")}");

            Action<string> ACount = ActionCountString;
            Console.Write("From Action delegate: ");
            ACount("cool");

            Predicate<string> Cool = IsCool;
            Console.WriteLine($"From predicate delegate: Does ohnicecool contain cool? {Cool("ohnicecool")}");
            
        }
    }
}

