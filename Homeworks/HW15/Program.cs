using System;

namespace HW15Linq
{
    public class HW15Linq
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Using Lamda expressions:");
            Func<int, int> cube = x => x * x * x;
            Console.WriteLine($"The cube of 3 is {cube(3)}");

            Func<string, string, string> ConcatString = (x, y) => x + y;
            Console.WriteLine($"Concatonate mountain and bike: {ConcatString("mountain", "bike")}");

            Func<int, bool> IsTeen = x => x > 12 && x < 20;
            Console.WriteLine($"23 is a teen: {IsTeen(23)}");
            Console.WriteLine($"13 is a teen: {IsTeen(13)}");

            Console.WriteLine("Using LINQ");
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> subNums =
                from num in nums
                where num % 2 == 0
                select num;
            Console.WriteLine("The even nums from 1 to 10 are:");
            foreach (var i in subNums)
            {
                Console.Write($"{i} ");
            }

            List<string> myWords = new List<string>() { "Hello", "Cool", "anna", "Forty-Two", "Deep Thought", "racecar" };
            IEnumerable<string> subStr =
                from word in myWords
                where new string(word.Reverse().ToArray()).Equals(word, StringComparison.OrdinalIgnoreCase)
                select word;
            Console.WriteLine("The palindromes in that list are: ");
            foreach (var word in subStr)
            {
                Console.Write($"{word} ");
            }

        }
    }
}