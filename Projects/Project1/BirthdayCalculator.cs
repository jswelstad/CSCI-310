using System;
using System.Data.Common;

namespace BirthdayCalculator
{
    public class BirthdayCalculator
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter the month you were born");
            Console.WriteLine("Example: 3, 12");
            int month = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter the day you were born");
            Console.WriteLine("Example: 14, 15");
            int day = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter the year you were born");
            Console.WriteLine("Example: 2003, 1969");
            int year = Int32.Parse(Console.ReadLine());
            
            DateTime bday = new DateTime(year, month, day);

            if (year > 2024 || year < 1900)
            {
                Console.WriteLine("You claim to be older than the oldest known human...");
                Console.WriteLine("Error Code: 101");
            }
            else
            {
                int age = DateTime.Now.Year - bday.Year - 1;
                int daysAliveThisYear = (DateTime.Now - new DateTime(DateTime.Now.Year, 1, 1)).Days;

                Console.WriteLine($"You are {age} years and {daysAliveThisYear} days old");

                if (bday.Month == DateTime.Now.Month && bday.Day == DateTime.Now.Day)
                {
                    Console.WriteLine("Happy Birthday!");
                }

                string westernSign = "";

                if (month == 1 && day >= 20 || month == 2 && day <= 18)
                    westernSign = "Aquarius";
                else if (month == 2 && day >= 19 || month == 3 && day <= 20)
                    westernSign = "Pisces";
                else if (month == 3 && day >= 21 || month == 4 && day <= 19)
                    westernSign = "Aries";
                else if (month == 4 && day >= 20 || month == 5 && day <= 20)
                    westernSign = "Taurus";
                else if (month == 5 && day >= 21 || month == 6 && day <= 20)
                    westernSign = "Gemini";
                else if (month == 6 && day >= 21 || month == 7 && day <= 22)
                    westernSign = "Cancer";
                else if (month == 7 && day >= 23 || month == 8 && day <= 22)
                    westernSign = "Leo";
                else if (month == 8 && day >= 23 || month == 9 && day <= 22)
                    westernSign = "Virgo";
                else if (month == 9 && day >= 23 || month == 10 && day <= 22)
                    westernSign = "Libra";
                else if (month == 10 && day >= 23 || month == 11 && day <= 21)
                    westernSign = "Scorpio";
                else if (month == 11 && day >= 22 || month == 12 && day <= 21)
                    westernSign = "Sagittarius";
                else
                    westernSign = "Capricorn";
                
                Console.WriteLine($"Your sun sign is {westernSign}");
            }
            
            //These signs differed depending on which website I checked so hopefully this is good
            //https://calendarlocal.us/wp-content/uploads/2019/12/chinese-zodiac-calculator-what-is-my-zodiac-sign-2019-10-21.jpg
            string[] chineseSigns = { "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Sheep", "Monkey", "Rooster", "Dog", "Pig" };
            Console.WriteLine($"Your Chinese Sign is {chineseSigns[(bday.Year - 1900) % 12]}");
        }
    }
}
