using System;

namespace HW5Classes
{
    public class Person
    {
        private int age;
        private string name;

        //Default constructor
        public Person()
        {
            this.age = 101;
            this.name = "John Doe";
        }

        public void ChangeAge(int years)
        {
            this.age += years;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Age: {this.age}");
        }

        public int GetAge()
        {
            return this.age;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetAge(int newAge)
        {
            this.age = newAge;
        }

        public void SetName(string newName)
        {
            this.name = newName;
        }
        
    }
    
    
    public class HW5Classes
    {
        static void Main(string[] args)
        {
            
            //Creating objects using default constructor
            Person obj1 = new Person();
            Person obj2 = new Person();
            Console.WriteLine($"Created two new instances of class\nPrinting their info");
            Console.WriteLine("Object 1: ");
            obj1.PrintInfo();
            Console.WriteLine("Object 2: ");
            obj2.PrintInfo();
            
            //Using getters and setters 
            Console.WriteLine("Using getters and setters");
            obj1.SetAge(20);
            obj1.SetName("Jack");
            Console.WriteLine($"Object 1 is now: {obj1.GetName()}, {obj1.GetAge()}");
            obj2.SetAge(42);
            obj2.SetName("Napoleon Dynamite");
            Console.WriteLine($"Object 2 is now: {obj2.GetName()}, {obj2.GetAge()}");
            
            //Using the change age method
            Console.WriteLine("Using the change age method");
            Console.WriteLine($"Old age of object 2: {obj2.GetAge()}");
            obj2.ChangeAge(35);
            Console.WriteLine($"New age of object 2: {obj2.GetAge()}");
            

        }
    }
}

