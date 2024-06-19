using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.FileIO;

namespace CustomerManagement
{

    interface ICustomers
    {
        void DisplayInfo();
        void UpdateInfo(string fName, string lName, string cID, string bName, string pNum);

    }
    public class Customers : ICustomers, IComparer<Customers>
    {
        private string firstName;
        private string lastName;
        private string customerID;
        private string businessName;
        private string phoneNumber;

        public Customers()
        {
            this.firstName = " ";
            this.lastName = " ";
            this.customerID = " ";
            this.businessName = " ";
            this.phoneNumber = " ";
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Full Name: {this.firstName} {this.lastName}");
            Console.WriteLine($"ID: {this.customerID}");
            Console.WriteLine($"Business: {this.businessName}");
            Console.WriteLine($"Phone Number: {this.phoneNumber}");
        }

        public void UpdateInfo(string fName, string lName, string cID, string bName, string pNum)
        {
            if (!string.IsNullOrWhiteSpace(fName))
            {
                this.firstName = fName;
            }

            if (!string.IsNullOrWhiteSpace(lName))
            {
                this.lastName = lName;
            }

            if (!string.IsNullOrWhiteSpace(cID))
            {
                this.customerID = cID;
            }

            if (!string.IsNullOrWhiteSpace(bName))
            {
                this.businessName = bName;
            }

            if (!string.IsNullOrWhiteSpace(pNum))
            {
                this.phoneNumber = pNum;
            }
            
            Console.WriteLine("Updated customer information successfully");
        }
        
        public override string ToString()
        {
            return $"Last Name: {this.lastName}\nFirst Name: {this.firstName}\nID: {this.customerID}\nBusiness: {this.businessName}\nPhone Number: {this.phoneNumber}\n";
        }

        public int Compare(Customers c1, Customers c2)
        {
            int lNameCompare = string.Compare(c1.lastName, c2.lastName);

            if (lNameCompare != 0)
            {
                return lNameCompare;
            }

            return string.Compare(c1.FirstName, c2.FirstName);
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string CustomerID
        {
            get { return this.customerID; }
            set { this.customerID = value; }
        }

        public string BusinessName
        {
            get { return this.businessName; }
            set { this.businessName = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }
        
    }
    public class CustomerManagement
    {
        static List<Customers> myList = new List<Customers>(100);

        static void PrintList(List<Customers> myList)
        {
            foreach (var i in myList)
            {
                i.DisplayInfo();
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void WriteCustomers()
        {
            string outputName = @"../../../output.txt";
            
            if (!File.Exists(outputName))
            {
                Console.WriteLine($"The file {outputName} does not exist");
                File.Create(outputName);
            }
            Console.WriteLine("Writing to output file");
            using (StreamWriter sw = new StreamWriter(outputName))
            {
                foreach (var c in myList)
                {
                    sw.WriteLine(c.ToString());
                }
            }
        }
        static void ReadCustomers()
        {
            string inputName = @"../../../input.txt";
            
            
            if (!File.Exists(inputName))
            {
                Console.WriteLine($"The file {inputName} does not exist");
                File.Create(inputName);
            }
            
            using (TextFieldParser parser = new TextFieldParser(inputName))
            {
                string[]? fields = new string[5];
                Console.WriteLine("From input file:");
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    fields = parser.ReadFields();
                    Customers c = new Customers();
                    c.LastName = fields[0];
                    c.FirstName = fields[1];
                    c.CustomerID = fields[2];
                    c.BusinessName = fields[3];
                    c.PhoneNumber = fields[4];
                    
                    myList.Add(c);
                }
            }
        }
        
        static void Main(string[] args)
        {
            ReadCustomers();
            PrintList(myList);
            WriteCustomers();
            
            Console.WriteLine($"Comparing {myList[0].LastName} with {myList[3].LastName} with compare function:");
            int comparison = myList[0].Compare(myList[0], myList[3]);
            Console.WriteLine($"Comparison result: {comparison}");
            Console.WriteLine($"The 1 tells you that {myList[3].LastName} preceeds {myList[0].LastName} in the sort order");

        }
    }
}

