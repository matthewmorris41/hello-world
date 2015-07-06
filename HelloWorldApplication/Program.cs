using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName = "Matthew";
            String lastName = "Morris";
            //Write to console Hello, Matthew, Morris
            Console.WriteLine("Hello, " + firstName + ", " + lastName);
            //Write to console Hello, Morris, Matthew
            Console.WriteLine(" " + lastName + ", " + firstName);
            Console.WriteLine("What is your first name?");
            
            firstName =Console.ReadLine();
            Console.WriteLine(firstName);
        }
    }
}
