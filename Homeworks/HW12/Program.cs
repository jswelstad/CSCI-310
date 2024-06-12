using System;

namespace HW12Exceptions
{

    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
            
        }
    }
    
    public class HW12Exceptions
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Trying");
                Console.WriteLine("Please enter the word Rick");

                string word = Console.ReadLine();
                
                CustomException e = new CustomException("Haha I trolled you... Exception thrown");
                e.HelpLink = "https://cl.gy/XWop";

                if (word == "Rick")
                {
                    throw e;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception caught: {e}");
                Console.WriteLine($"Follow this link for help: {e.HelpLink}");
            }
            
        }
    }
}