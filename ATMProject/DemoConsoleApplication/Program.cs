using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemoConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your name");
            string name=Console.ReadLine();
            DemoClass.TestMethod(name);
            Console.ReadLine();

        }
    }
}
