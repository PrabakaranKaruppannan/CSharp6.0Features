using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6._0Features
{
    class NullOperator
    {
        static void Main(string[] args)
        {
            // Before C# 6.0, in order get the FirstName, we make NullOperatorCustomer is null or not. 
            // If not null then only we can get first name as below
            NullOperatorCustomer customer = new NullOperatorCustomer();
            if (customer != null)
            {
                Console.WriteLine(customer.FirstName);
            }

            // In C# 6.0, we can simplify syntax as below. if customer not null, then ?. will get firstname. if null nothing returns.
            Console.WriteLine(customer?.FirstName);
            Console.Read();
        }

    }

    class NullOperatorCustomer
    {
        public string FirstName { get; set; }
    }
}
