using System;
using System.Numerics;

namespace HW6Inheritance
{
    public class People
    {
        private string name;
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }

    public class Student : People
    {
        private string idNumber;
        public int[] grades;
        private int numGrades;

        public Student(string name, string idNumber)
        {
            this.Name = name;
            this.IdNumber = idNumber;
            grades = new int[10];
        }

        public void AddGrade(int grade)
        {
            grades[numGrades] = grade;
            this.numGrades++;
        }

        public float CalcGPA()
        {
            float num = 0;
            foreach (int i in grades)
            {
                num += i;
            }
            return num / numGrades;
        }

        public string IdNumber
        {
            get { return this.idNumber; }
            set { this.idNumber = value; }
        }
        
        
        
    }

    public class Teacher : People
    {
        public string[] classes;
        public int numClasses;
        public Teacher(string name)
        {
            this.Name = name;
            classes = new string[10];
        }
        
        public void AddClass(string c)
        {
            classes[numClasses] = c;
            numClasses++;
        }

        public void PrintClasses()
        {
            Console.WriteLine($"Classlist of {this.Name}:");
            foreach (string c in classes)
            {
                if (c != null)
                {
                    Console.WriteLine($"{c}");
                }
            }
        }
        
        
    }
    
    public class HW6Inheritance
    {
        static void Main(string[] args)
        {

            //Student class
            Student s1 = new Student("Jack", "1");
            Console.WriteLine($"Name: {s1.Name}, ID: {s1.IdNumber}");
            s1.AddGrade(3);
            s1.AddGrade(4);
            s1.AddGrade(4);
            s1.AddGrade(4);
            s1.AddGrade(2);
            Console.WriteLine($"Student 1's GPA is: {s1.CalcGPA()}");

            //Teacher class
            Teacher t1 = new Teacher("Bob");
            Console.WriteLine($"Original teacher name: {t1.Name}");
            t1.Name = "Ben";
            Console.WriteLine($"Changed teacher name to: {t1.Name}");
            
            t1.AddClass("Biology");
            t1.AddClass("Computer Science");
            t1.AddClass("History");
            t1.PrintClasses();
        }
    }
}
