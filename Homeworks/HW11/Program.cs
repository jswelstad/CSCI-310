using System;

namespace HW11Collections
{
    public class HW11Collections
    {
        
        static Dictionary<string, int> myDict = new Dictionary<string, int>();
        static Queue<int> myQueue = new Queue<int>();
        static Stack<int> myStack = new Stack<int>();
        
        static void PrintQueue<T>(Queue<T> myQueue)
        {
            Console.WriteLine("Printing Queue");
            foreach (var i in myQueue)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        
        static void PrintStack<T>(Stack<T> myStack)
        {
            Console.WriteLine("Printing Stack");
            foreach (var i in myStack)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static void PushUnique(int value)
        {
            if (!myStack.Contains(value))
            {
                myStack.Push(value);
            }
            else
            {
                Console.WriteLine("Cannot add value to stack because it already exists in the stack");
            }
        }

        static void EnqueueUnique(int value)
        {
            if (!myQueue.Contains(value))
            {
                myQueue.Enqueue(value);
            }
            else
            {
                Console.WriteLine("Cannot add value to queue because it already exists in the queue");
            }
            Console.WriteLine();
        }
        
        
        static void DictionaryAddUnique(string key, int value)
        {
            if (!myDict.ContainsValue(value))
            {
                myDict.Add(key, value);
            }
            else
            {
                Console.WriteLine("Cannot add that value because it already exists in the dictionary");
            }
            Console.WriteLine();
        }

        static void PrintDictionary<TTkey, TValue>(Dictionary<TTkey, TValue> myDictionary)
        {
            Console.WriteLine("Printing Dictionary");
            foreach (var kvp in myDictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            Console.WriteLine();
        }
            
        
        static void Main(string[] args)
        {
            //Dictionary
            DictionaryAddUnique("Car", 22);
            DictionaryAddUnique("Truck", 25);
            DictionaryAddUnique("Smart car", 25);
            
            PrintDictionary(myDict);
            
            //Queue
            EnqueueUnique(42);
            EnqueueUnique(35);
            EnqueueUnique(100);
            EnqueueUnique(42);
            
            PrintQueue(myQueue);
            
            //Stack
            PushUnique(42);
            PushUnique(101);
            PushUnique(72);
            PushUnique(42);
            
            PrintStack(myStack);
            
        }
    }
}