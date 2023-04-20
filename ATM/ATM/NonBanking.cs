using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class NonBanking
    {
        public static void PinChange(Customer c)
        {
            Console.WriteLine("Enter the old pin");
            int oldpin=Convert.ToInt32(Console.ReadLine());
            int count = 3;
            while(oldpin!=c.pin && count>0)
            {
                Console.WriteLine("Entered incorrect pin\nPlease enter the correct pin");
                 oldpin = Convert.ToInt32(Console.ReadLine());
                count--;
                if(count==0)
                {
                    Console.WriteLine("The maximum number of times have been reached ..Please try Later");
                    return;
                }
            }
         
            while(true)
            {
                int newPin, ConfirmPin;
                Console.WriteLine("Enter the New pin");
                 newPin = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the New pin again");
                 ConfirmPin = Convert.ToInt32(Console.ReadLine());
                if(newPin!=ConfirmPin)
                {
                    Console.WriteLine("Both pin numbers are mismatched");
                    continue;
                }
                else
                {
                    c.pin = newPin;
                    Console.WriteLine("Your pin has been set successfully");
                    break;
                }


            }


        }
        public static void GeneratePin(Customer c)
        {
            Random random= new Random();
            c.pin=random.Next(1111,9999);
            Console.WriteLine("Your pin has successfully been generated: " + c.pin);
        }
    }
}
