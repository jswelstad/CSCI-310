using System;

namespace HW16Async
{
    public class HW16Async
    {
        static void Say10Hello()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello");
                Task.Delay(100).Wait();
            }
        }

        static void Say10Goodbye()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Goodbye");
                Task.Delay(100).Wait();
            }
        }

        static Task Bye()
        {
            return Task.Run(() => Say10Goodbye());
        }

        static async void SayBye()
        {
            await Bye();
        }

        static Task Hi()
        {
            return Task.Run(() => Say10Hello());
        }

        static async void SayHi()
        {
            await Hi();
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Functions running asynchronously");
            SayHi();
            Say10Goodbye();
        }
    }
}