using System;

namespace HW2Conditionals
{
    public class HW2Conditionals
    {
        static void Main(string[] args)
        {
            //Tax stuff
             float income = 0.0f;
             income = Single.Parse(Console.ReadLine());
             Console.WriteLine($"Your income is: {income.ToString("0.00")}");
            
             float tax = 0;
            
             if (income < 10000)
             {
                 tax = .05f;
                 Console.WriteLine($"You will pay 5% tax on your {income}$ which is {income * tax}$");
             }
             else if (income >= 10000 && income < 100000)
             {
                 tax = .097f;
                 Console.WriteLine($"You will pay 9.7% tax on your {income}$ which is {income * tax}$");
             }
             else
             {
                 tax = .14f;
                 Console.WriteLine($"You will pay 14% tax on your {income}$ which is {income * tax}$");
             }

             //Shape stuff
            
            Console.WriteLine("Please enter the size of your shape");
            int column = Int32.Parse(Console.ReadLine());
            int row = 1;
            
            //Triangle
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write("*");
                }
                row++;
                Console.WriteLine();
            }
            
            //Flipped Triangle
            Console.WriteLine();
            row = column;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write("*");
                }
                row--;
                Console.WriteLine();
            }
            
            //Square
            Console.WriteLine();
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            

        }
    }
}