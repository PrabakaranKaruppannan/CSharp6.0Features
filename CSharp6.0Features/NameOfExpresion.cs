using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6._0Features
{
    class NameOfExpresion
    {
        static void Main(string[] args)
        {
            NameOfExpresionCustomer customer = new NameOfExpresionCustomer();
            customer.GetFullName("testFirstName", "testLastName");
        }
    }

    class NameOfExpresionCustomer
    {
        public string GetFullName(string firstName, string lastName)
        {
            // Before C# 6.0, If we validate parameter we used below way.
            // If we change parameter firstName to full name, developer forgot to change the message.
            if (string.IsNullOrEmpty(firstName))
            {
                throw new Exception("firstName is not null");
            }

            // In C# 6.0, If we can use nameof expression in below way.
            // If we change parameter firstName to full name, developer must change the message as well. Otherwise compiler error.
            if (string.IsNullOrEmpty(firstName))
            {
                throw new Exception(nameof(firstName) +" is not null");
            }

            return firstName + lastName;
        }
    }
}
