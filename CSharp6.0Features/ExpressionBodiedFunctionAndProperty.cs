using System;

namespace CSharp6._0Features
{
    class ExpressionBodiedFunctionAndProperty
    {
        static void Main(string[] args)
        {
            ExpressionBodiedCustomer customer = new ExpressionBodiedCustomer();
            customer.FirstName = "TestFirstName";
            customer.LastName = "TestLastName";

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
            Console.WriteLine(customer.GetFullName());


            Console.WriteLine(customer.FullName);
            Console.WriteLine(customer.GetCustomerFullName());
            Console.ReadLine();
        }
    }

    class ExpressionBodiedCustomer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        // Before 6.0, We use below way to get the full name
        public string GetFullName()
        {
            return FirstName + LastName;
        }


        // IN C# 6.0, you can write one line to return full name.
        public string FullName => FirstName + LastName;

        public string GetCustomerFullName() => FirstName + LastName;
    }
}

