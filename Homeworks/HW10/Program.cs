using System;

namespace HW10Lists
{
    public class HW10Lists
    {
        static void PrintList<T>(List<T> myList)
        {
            foreach (var i in myList)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static List<T> InsertItem<T>(List<T> myList, T element)
        {
            myList.Sort();

            int index = myList.BinarySearch(element);
            if (index < 0)
            {
                myList.Insert(~index, element);
            }
            else
            {
                myList.Insert(index, element);
            }

            return myList;
        }
        
        static void Main(string[] args)
        {
            Random rand = new Random();
            
            List<int> nums = new List<int>(100);
            List<String> words = new List<string>(100);

            for (int i = 0; i < 20; i++)
            {
                nums.Add(rand.Next(-20, 20));
            }
            
            words.Add("Apple");
            words.Add("Banana");
            words.Add("Cucumber");
            words.Add("Apricot");
            words.Add("Blueberry");
            words.Add("Pear");
            words.Add("Strawberry");
            words.Add("Cherry");
            
            //ints
            Console.WriteLine("Before inserting ints: ");
            PrintList(nums);
            
            Console.WriteLine("Inserting 42");
            nums = InsertItem(nums, 42);
            Console.WriteLine("Inserting 0");
            nums = InsertItem(nums, 0);
            
            Console.WriteLine("After inserting: ");
            PrintList(nums);
            
            //strings
            Console.WriteLine("Before inserting strings: ");
            PrintList(words);
            
            Console.WriteLine("Inserting avocado");
            words = InsertItem(words, "Avocado");
            Console.WriteLine("Inserting tomato");
            words = InsertItem(words, "Tomato");
            
            Console.WriteLine("After inserting: ");
            PrintList(words);

            






        }
    }
}