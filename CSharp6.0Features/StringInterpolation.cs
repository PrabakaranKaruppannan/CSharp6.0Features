using System;

namespace CSharp6._0Features
{
    class StringInterpolation
    {
        static void Main(string[] args)
        {
            StringInterpolationCustomer customer = new StringInterpolationCustomer();
            customer.FirstName = "TestFirstName";
            customer.LastName = "TestLastName";

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
            Console.WriteLine(customer.GetWelcomeMessage());
            Console.WriteLine(customer.GetNewWelcomeMessage());
            Console.ReadLine();
        }
    }

    class StringInterpolationCustomer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        // Before C# 6.0, We use below way to append two strings.  you need to remember which item goes in first index {0} and which one is in {1}
        public string GetWelcomeMessage()
        {
            return string.Format("Welcome back {0} {1}", FirstName, LastName);
        }

        // Before 6.0, We use below way to append two strings. Its easier to read and write.
        public string GetNewWelcomeMessage()
        {
            return $"Welcome {FirstName} {LastName}";
        }
    }
}
