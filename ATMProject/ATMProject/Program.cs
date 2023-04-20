using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMProject
{
    internal class Program
    {
        static AtmFactory factory;
        static IAtm atm;
        static int atmId;
        static  Customer c;
        static void Main(string[] args)
        {
            int choice, enteredAtmPin;

            //creating the customer object with demo details
            c = new Customer(77230001000211, "Nithin", 1729);
            factory = new AtmFactory();

            //Displaying the available ATM machines and prompting the user to select the ATM Machine
            Console.WriteLine("1 - SBI \n2- AXIS");
            Console.WriteLine("Select the ATM and enter the corresponding number");


            //This loop gets executed as long as user the selects the available ATM only
            while(true)
            {
                atmId = Convert.ToInt32(Console.ReadLine());
                atm=factory.GetAtm(atmId);
                if(atm == null )
                {
                    Console.WriteLine("Enter valid option");
                }
                else
                {
                    break;
                }
            }
             
             // Prompting the user to enter atm pin provided
            Console.WriteLine(c.ToString());
            Console.WriteLine("Enter the ATM Pin");
            
            //This loop gets executed as long as user enters correct ATM Pin
            while(true)
            {
                enteredAtmPin = Convert.ToInt32(Console.ReadLine());
                if (enteredAtmPin != 0)
                {
                   
                   bool status= atm.ValidateCard(enteredAtmPin, c);
                    if(status)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Pin\nEnter the correct pin again");
                    }
                }
                else
                {
                    Console.WriteLine("Enter valid pin");
                }
                
            }
            DisplayOperations();
            Console.WriteLine("Select the service");
             choice=Convert.ToInt32(Console.ReadLine());
            while (choice != 0)
            {
                
                    switch(choice)
                    {
                    case 1:
                        atm.WithdrawMoney(c);
                        break;
                    case 2:
                        atm.CheckBalance(c);
                        break;
                    case 3:
                        atm.MiniStatement(c);
                        break;
                    case 4:
                        atm.BankTransfer();
                        break;
                    case 5:
                        atm.Deposit(c);
                        break;
                    case 6:choice = 0;
                        
                        continue;
                        

                    default:
                        Console.WriteLine("Invalid Option");
                        break;

                    }
                    DisplayOperations();
                    choice= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Thankyou");
            Console.ReadLine();


        }
        static void DisplayOperations()
        {
            Console.WriteLine("1 - Withdraw");
            Console.WriteLine("2 - CheckBalance");
            Console.WriteLine("3 - MiniStatement");
            Console.WriteLine("4 - BankTransfer");
            Console.WriteLine("5 - Deposit");
            Console.WriteLine("6 - Exit");
        }
    }
}
