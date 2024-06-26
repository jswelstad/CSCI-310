using System;

namespace EventManager
{
    public interface ICustomer
    {
        string Name { get; set; }
    }

    public class Customer : ICustomer
    {
        private string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        
    }

    public interface IOrder
    {
        
        ICustomer Customer { get; set; }
        DateTime DateOrder { get; set;  }
        void PlaceOrder();
        
    }

    public class Order : IOrder
    {
        private ICustomer customer;
        private DateTime dateOrder;
        public event EventHandler e;

        public Order(ICustomer c)
        {
            this.customer = c;
            this.dateOrder = DateTime.Now;
        }
        
        public ICustomer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public DateTime DateOrder
        {
            get { return this.dateOrder; }
            set { this.dateOrder = value; }
        }
        
        protected virtual void OrderReady()
        {
            e?.Invoke(this, EventArgs.Empty);
        }

        public void PlaceOrder()
        {
            Console.WriteLine($"Order for {this.customer.Name} has been placed");
            Console.WriteLine($"Date: {this.dateOrder}");
            
           OrderReady();
        }
    }
    
    public class Subscriber
    {
        public void Subscribe(Order order)
        {
            order.e += OrderReadyToShip;
        }

        private void OrderReadyToShip(object sender, EventArgs e)
        {
            Console.WriteLine("Order is ready to ship: Event received.");
        }
    }
    
    public class EventManager
    {
        static void Main(string[]args)
        {
            List<ICustomer> customers = new List<ICustomer>();
            List<IOrder> orders = new List<IOrder>();
            
            for (int i = 0; i < 10; i++)
            {
                Customer customer = new Customer($"Customer {i}") ;
                customers.Add(customer);
            }

            foreach (var customer in customers)
            {
                Order order = new Order(customer);
                orders.Add(order);
                
                Subscriber subscriber = new Subscriber();
                subscriber.Subscribe(order);
                
                order.PlaceOrder();
            }

            Console.WriteLine("Query to search customer by name");
            IEnumerable<ICustomer> subCus =
                from customer in customers
                where customer.Name.Contains("5")
                select customer;
            Console.WriteLine($"Result of query for customer 5: ");
            foreach (var customer in subCus)
            {
                Console.WriteLine($"{customer.Name}");
            }
            
            Console.WriteLine("Query to search orders that were placed today");
            IEnumerable<IOrder> subOrder =
                from order in orders
                where order.DateOrder.Date == DateTime.Today
                select order;
            Console.WriteLine("Result of query for orders placed today:");
            foreach (var order in subOrder)
            {
                Console.WriteLine($"{order.Customer.Name}: {order.DateOrder}");
            }
        }
    }
}