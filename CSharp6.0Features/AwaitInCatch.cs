using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6._0Features
{
    class AwaitInCatch
    {
        static void MainAsync(string[] args)
        {
            //Before C# 6.0, you cannot use await in catch block. In C# 6.0 you can use await in catch as below
            
            SomeOperationAsync();

            Console.Read();

        }

        static async Task SomeOperationAsync()
        {
            try
            {
                throw new Exception("400");
            }
            catch (Exception exception)
            {
                await SomeOperationAsync();
            }
        }
    }
}
