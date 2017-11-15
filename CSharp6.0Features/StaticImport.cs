using System;
using static System.Console;

namespace CSharp6._0Features
{
    class StaticImport
    {
        static void Main(string[] args)
        {
            // Before C# 6.0, We use below way to get the static methods inside class. Console is static class.
            Console.WriteLine("Hello World");

            // IN C# 6.0, You can import the static class in namespaces. "using static System.Console;" it will import Console into namespace. 
            // So you no need to write Console in your code. This is applicable for custom static class as well.
            WriteLine("Hello World");

        }
    }
}
