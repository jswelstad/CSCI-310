using System;

namespace HW9Interfaces
{
    interface IBike
    {
        void Ride(int miles);
        void Service();
        void Clean();

    }
    
    
    public class Bike : IBike
    {
        private int miles;

        public Bike()
        {
            miles = 0;
        }

        public void Ride(int miles)
        {
            if (this.miles < 250)
            {
                this.miles += miles;
            }
            else
            {
                Console.WriteLine($"You went to ride your bike but you have {this.miles} miles on it and it needs service");
            }
        }

        public void Service()
        {
            this.miles = 0;
            Console.WriteLine("Your bike has been serviced and will be good for another 250 miles");
        }

        public void Clean()
        {
            this.miles -= 20;
            Console.WriteLine("You cleaned your bike and it will now last an extra 20 miles");
        }
        

    }
    
    
    public class HW9Interfaces
    {
        static void Main(string[] args)
        {
            Bike Nomad = new Bike();
            
            //Ride
            Console.WriteLine("Riding 50 miles");
            Nomad.Ride(50);
            Console.WriteLine("Riding 300 miles");
            Nomad.Ride(300);
            Console.WriteLine("Attempting to ride more");
            Nomad.Ride(50);
            
            //Clean
            Console.WriteLine("I don't want to service it, I am just going to clean it...");
            Nomad.Clean();
            
            Nomad.Ride(20);
            
            //Serivce
            Console.WriteLine("Fine I will service it");
            Nomad.Service();
            Nomad.Ride(25);
            
            Console.WriteLine("Yay I can ride it again");
            

        }
    }
}

