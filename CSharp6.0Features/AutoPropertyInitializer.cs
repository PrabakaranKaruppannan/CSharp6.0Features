using System;

namespace CSharp6._0Features
{
    class AutoPropertyInitializer
    {
        static void Main(string[] args)
        {
            AutoPropertyCustomer customer = new AutoPropertyCustomer();
            
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
            Console.WriteLine(customer.FullName);
            Console.ReadLine();
        }
    }

    class AutoPropertyCustomer
    {
        // Before 6.0, We can initializte value for the property in either two ways. 1. Private Varible 2. Constructor
        private string _firstName = "TestFirstName";

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName { get; set; }

        public AutoPropertyCustomer()
        {
            LastName = "TestLastName";
        }

        // In C# 6.0, We can initialize where the property declare by following way.
        public string FullName { get; set; } = "TestFirstNameLastName";
    }

}
