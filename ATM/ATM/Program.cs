using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Runtime.ExceptionServices;

namespace ATM
{
    internal class Customer
    {
        public  double balance;
        public  int pin;
        public string name;
        public   Stack transactions= new Stack();
        public Customer(string name,int pin)
        {
            this.name = name;
            this.pin = pin;


        }
        public static void Main(string[] args)
        {
            Dictionary<string,int> dic = new Dictionary<string,int>();
            dic.Add("nithin", 1245);dic.Add("Niraj", 8520);
            int flag_for_application = 1;
            Customer c = null;
                while(flag_for_application==1)
                {
                    foreach (string key in dic.Keys)
                    {
                        Console.WriteLine(key + ": " + dic[key]);
                    }
                    Console.WriteLine("Enter the customer name");
                    string name = Console.ReadLine();
                    try
                    {
                        int pin = dic[name];
                         c = new Customer(name, pin);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("No user found");
                    continue;
                    }
                  
                    Console.WriteLine("Enter the Atm pin");
                    while (true)
                    {
                        int EnteredPin = Convert.ToInt32(Console.ReadLine());
                        if (EnteredPin != c.pin)
                        {
                            Console.WriteLine("Incorrect Pin, Please enter again");


                        }
                        else
                        {
                            break;
                        }
                    }
                    int flag = 1;
                    while (flag == 1)
                    {
                        ShowOptions();
                        Console.WriteLine("Select option");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Banking.deposit(c);
                                break;
                            case 2:
                                Banking.withdraw(c);
                                break;
                            case 3:
                                NonBanking.PinChange(c);
                                break;
                            case 4:
                                NonBanking.GeneratePin(c);
                                break;
                            case 5:
                                    Banking.Balance(c);
                                break;
                            case 6:
                                Banking.MiniStatement(c);
                                break;
                            case 7:
                                flag = 0;
                            Console.WriteLine("Thank you for using");
                                break;
                            default:
                                Console.WriteLine("Please Enter valid option");
                                break;
                        }
                    Console.WriteLine("Enter 1 to continue and 0 to exit");
                    flag = Convert.ToInt32(Console.ReadLine());
                    if(flag==0)
                    {
                        Console.WriteLine("Thank you for using");
                    }
                }
                    Console.WriteLine("Enter 0 to terminate the application and 1 to continue");
                flag_for_application= Convert.ToInt32(Console.ReadLine());

            }




        }
        public static void ShowOptions()
        {
            Console.WriteLine("1 - Deposit");
            Console.WriteLine("2 - Withdraw");
            Console.WriteLine("3 - Pin change");
            Console.WriteLine("4 - Generate pin");
            Console.WriteLine("5 - Balance Enquiry");
            Console.WriteLine("6 - Mini Statement");
            Console.WriteLine("7 - Exit");
        }

    }
}
