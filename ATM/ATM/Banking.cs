using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Banking
    {
        public static void deposit(Customer c)
        {
            Console.WriteLine("Enter amount to deposit");
            int amount=Convert.ToInt32(Console.ReadLine());
            c.balance += amount;
            Console.WriteLine("Your amount has successfully deposited into your account");
            c.transactions.Push("Amount credited: " + amount);
        }
        public static void withdraw(Customer c) 
        {
            Console.WriteLine("Enter the amount");
            while(true)
            {
                   
                int amount=Convert.ToInt32(Console.ReadLine());
                

                if (amount % 100 != 0)
                {
                    Console.WriteLine("Enter the amount in multiples of 100");
                    continue;
                }

                else if (amount <= 100 && amount >= 25000)
                {

                    Console.WriteLine("Enter amount in range of Rs 100 - Rs 25000");
                    continue;
                }


                else if (c.balance < amount)
                {
                    Console.WriteLine("SORRY!, You do not have sufficient balance in account");
                    break;
                }
                c.balance -= amount;
                Console.WriteLine("Your amount has successfully been withdrawn");
                c.transactions.Push("Amount debited: " + amount);
                break;


                
              

                  

            }
         
            
        }
        public static void Balance(Customer c)
        {
            Console.WriteLine("Your account balance is "+c.balance);
        }
        public static void MiniStatement(Customer c)
        {
            Console.WriteLine("MINI-STATEMENT");
            int count = 1;
            foreach(var item in c.transactions)
            {
                Console.WriteLine(count+": "+item.ToString());
            }

        }
    }
}
