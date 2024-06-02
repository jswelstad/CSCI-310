using System;
using System.Collections.Immutable;

namespace HW3Arrays
{
    public class HW3Arrays
    {
        static void Main(string[] args)
        {

            int[] nums = new int[10];
            
            for (int i = 0; i < 10; i++)
            {
                Random rand = new Random();
                nums[i] = rand.Next(0, 100);
            }
            
            //Print random array
            Console.WriteLine("Unsorted Array:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{nums[i]} ");
            }
            Console.WriteLine();
            
            //Sorting array
            Console.WriteLine("Sorted Array:");
            Array.Sort(nums);
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{nums[i]} ");
            }
            Console.WriteLine();
            
            //Reversing array
            Console.WriteLine("Reversed Array:");
            Array.Reverse(nums);
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{nums[i]} ");
            }
            Console.WriteLine();
            
            
            //Rectangular array
            Console.WriteLine("Randomly generated 3x3 rectangular array:");
            int[,] recArray = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < 3; j++)
                {
                    Random rand = new Random();
                    recArray[i, j] = rand.Next(0, 10);
                    Console.Write($"{recArray[i, j]} ");
                }
                Console.WriteLine("]");
            }
            
            //Jagged array
            Console.WriteLine("Randomly generated jagged array:");
            int[][] jaggedArray = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("[ ");
                Random rand = new Random();
                jaggedArray[i] = new int[rand.Next(1, 10)];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = rand.Next(0, 10);
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine("]");
            }

        }
    }
}