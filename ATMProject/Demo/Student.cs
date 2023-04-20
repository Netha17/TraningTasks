using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Student
    {
        public Student() {
            Console.WriteLine("Constructor called");
        }


        static void Main(string[] args)
        {
            Student student = new Student();
            Console.ReadLine();
        }
    }
}

