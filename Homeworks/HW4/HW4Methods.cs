using System;

namespace HW4Methods
{
    public class HW4Methods
    {
        static void Main(string[] args)
        {
            //Output text from function
            OutputText("yo yo yo");
            
            //Output return value from function
            Console.WriteLine($"Printing from function: {ReturnData()}");
            
            //Swap nums by reference
            int num1 = 5;
            int num2 = 42;
            Console.WriteLine($"Num1: {num1}\nNum2: {num2}");
            SwapEm(ref num1, ref num2);
            Console.WriteLine($"After Swapping\nNum1: {num1}\nNum2: {num2}");
            
            //Fibonacci
            Console.WriteLine("Please enter the number you would like to find the fibonacci of");
            int n = int.Parse(Console.ReadLine());
            int result = Fibonacci(n);
            Console.WriteLine($"The fibonacci of {n} is: {result}");

            //Prime
            Console.WriteLine("Please enter a number you would like to check is prime");
            int num = int.Parse(Console.ReadLine());
            bool prime = IsPrime(num);
            if (prime)
            {
                Console.WriteLine($"{num} is a prime number");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime number");
            }

        }

        static bool IsPrime(int n)
        {
            bool prime = true;

            //1 and 0 are not prime
            if (n < 2)
            {
                return false;
            }
            
            //Must check and see if n can be divided by any number less then sqrt(n)
            //The sqrt is b/c no factor of a number can be greater than the sqrt of that number
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }

        static int Fibonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        static void OutputText(string word)
        {
            Console.WriteLine($"The parameter passed in is {word}");
        }

        static string ReturnData()
        {
            return "I returned this from a function";
        }

        static void SwapEm(ref int num1, ref int num2)
        {
            int temp = num2;
            num2 = num1;
            num1 = temp;
        }
    }
}