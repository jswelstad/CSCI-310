using System;

namespace HW7Polymorphism
{
    public class Truck : Vehicle
    {
        private int cargoCapacity;

        public Truck(string make, string model, int year, int miles, int cargoCapacity)
            : base(make, model, year, miles)
        {
            this.cargoCapacity = cargoCapacity;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Cargo Capacity: {cargoCapacity}");
        }

        public override void Start()
        {
            Console.WriteLine("The truck has been started");
        }

        public override void Stop()
        {
            Console.WriteLine("The truck has been stopped");
        }

        public void Load(int weight)
        {
            Console.WriteLine($"{weight} lbs has been loaded onto the truck");
        }
    }
    
    
    public class Vehicle
    {
        private int year;
        private int miles;
        private string model;
        private string make;
        
        //Getters and Setters
        public int Year
        {   
            get { return this.year; }
            set { this.year = value; }
        }

        public int Miles
        {
            get { return this.miles; }
            set { this.miles = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        //Constructor
        public Vehicle(string make, string model, int year, int miles)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.miles = miles;
        }

        public Vehicle()
        {
            this.make = "Default";
            this.model = "Default";
            this.year = 0;
            this.miles = 0;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Make: {make}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Miles: {miles}");
        }

        public virtual void Start()
        {
            Console.WriteLine("Vehicle has started");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicle has stopped");
        }
        
        
        
    }

    public class Car : Vehicle
    {
        private int price;

        public Car(string make, string model, int year, int miles, int price)
            : base(make, model, year, miles)
        {
            this.price  = price;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Price: ${price}");
        }

        public override void Start()
        {
            Console.WriteLine("The car has been started");
        }

        public override void Stop()
        {
            Console.WriteLine("The car has been stopped");
        }

        public void Sell()
        {
            Console.WriteLine($"The car has been sold for {price}");
        }
    }
    
    
    public class HW7Polymorphism
    {
        static void Main(string[] args)
        {
            
            //Base class
            Console.WriteLine("Base Vehicle:");
            Vehicle vehicle = new Vehicle("Nissan", "Xterra", 2010, 15000);
            vehicle.ShowInfo();
            vehicle.Start();
            vehicle.Stop();
            Console.WriteLine();

            //Truck
            Console.WriteLine("Truck:");
            Truck truck = new Truck("Toyota", "Tacoma", 2000, 45000, 10000);
            truck.ShowInfo();
            truck.Load(3000);
            truck.Start();
            truck.Stop();
            Console.WriteLine();
            
            //Car
            Console.WriteLine("Car:");
            Car car = new Car("Corvette", "Something", 2000, 10000, 1);
            car.ShowInfo();
            car.Start();
            car.Stop();
            Console.WriteLine();

        }
    }
}
