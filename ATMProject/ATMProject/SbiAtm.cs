using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMProject
{
    internal class SbiAtm : IAtm
    {
        public string atmName = "SBI";
        public SbiAtm() 
        {
            Console.WriteLine("Welcome to SBI atm");
        }
        
        public void BankTransfer()
        {
            Console.WriteLine("Transfering funds");
        }

        public void CheckBalance(Customer c)
        {
            Console.WriteLine("Your balance is: " + c.getBalance());
        }

        public void MiniStatement(Customer c)
        {
            if(c.miniStatement.Count==0)
            {
                Console.WriteLine("NO TRANSACTIONS");
                return;
            }
            Console.WriteLine("MINI STATEMENT");
            foreach (var item in c.miniStatement)
            {
                Console.WriteLine(item);
            }
        }

        public bool ValidateCard(int pin, Customer c)
        {
            if(pin!=c.getAtmPin())
            {
                return false;
            }
            return true;
        }

        public void WithdrawMoney(Customer c)
        {
             Console.WriteLine("Enter the amount");
            int amount=Convert.ToInt32(Console.ReadLine());
            if(amount<c.getBalance())
            {
                c.setBalance(amount);
                c.miniStatement.Push("Amount Debited: "+ amount);
                Console.WriteLine("You have successfully been debited the amount");
            }
            else
            {
                Console.WriteLine("No sufficient funds in account");
            }

        }
        public void Deposit(Customer c)
        {
            Console.WriteLine("Ente the amount to deposit");
            int amount = Convert.ToInt32(Console.ReadLine());
            c.setBalance(amount);
            c.miniStatement.Push("Amount Credited: " + amount);
            Console.WriteLine("Your amount credited successfully");
        }
    }
}
