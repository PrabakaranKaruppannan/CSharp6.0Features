using System;

namespace CSharp6._0Features
{
    class ReadOnlyProperty
    {
        static void Main(string[] args)
        {
            ReadOnlyCustomer customer = new ReadOnlyCustomer();
            customer.FirstName = "TestFirstName";

            customer.ChangeLastName("TestLastName");

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
            Console.ReadLine();
        }
    }

    class ReadOnlyCustomer
    {
        public string FirstName { get; set; }

        // Before 6.0. 
        // But it cannot give full read only access. 
        // You can modify the lastname using the below method "ChangeLastName";
        public string LastName { get; private set; }

        public void ChangeLastName(string lastName)
        {
            LastName = lastName;
        }


        // In 6.0. 
        // It gives full read only access. 
        // You cannot modify the fullname with the below method "ChangeFullName". It gives compile error when you uncomment the code inside that method.
        public string FullName { get; }


        public void ChangeFullName(string lastName)
        {
            //FullName = lastName;
        }
    }
}
