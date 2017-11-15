using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6._0Features
{
    class DictionaryInitializer
    {
        static void Main(string[] args)
        {
            // Before C# 6.0, We use below way to initialize dictionary
            Dictionary<int, string> freeCustomerList = new Dictionary<int, string>
            {
                {1, "Praba"},
                {2, "Shidi"},
                {3, "Khoo"}
            };

            // IN C# 6.0, We use below way to initialize dictionary. Its easiery read. Left side is key, right side is value
            Dictionary<int, string> paidCustomerList = new Dictionary<int, string>
            {
                [1] = "Praba",
                [2] = "Shidi",
                [3] = "Khoo"
            };


        }
    }
}
