using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6._0Features
{
    class ExceptionFilter
    {
        static void Main(string[] args)
        {
            //Before C# 6.0, Below method we can write diffrent message based on exception message. We use multiple if else
            try
            {
                throw new Exception("400");
            }
            catch (Exception exception)
            {
                if (exception.Message.Equals("400"))
                {
                    Console.WriteLine("Bad Request");
                }
                if (exception.Message.Equals("401"))
                {
                    Console.WriteLine("Not Authorized");
                }
                if (exception.Message.Equals("404"))
                {
                    Console.WriteLine("Not Found");
                }
                if (exception.Message.Equals("500"))
                {
                    Console.WriteLine("Internal Server Error");
                }
            }

            // In C# 6.0, the above example simplified as below: We can have multiple catch exception filter
            try
            {
                throw new Exception("400");
            }
            catch (Exception exception) when (exception.Message.Equals("400"))
            {
                Console.WriteLine("Bad Request");
            }
            catch (Exception exception) when (exception.Message.Equals("401"))
            {
                Console.WriteLine("Not Authorized");
            }
            catch (Exception exception) when (exception.Message.Equals("404"))
            {
                Console.WriteLine("Not Found");
            }
            catch (Exception exception) when (exception.Message.Equals("500"))
            {
                Console.WriteLine("Internal Server Error");
            }


            Console.Read();

        }
    }
}
