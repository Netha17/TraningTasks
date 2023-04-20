using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMProject
{
    internal interface IAtm
    {
        // IAtm interface provides the following services and this interface will be 
        // implemented by the two ATM machines i.e SBI &  AXIS 
        bool ValidateCard(int pin,Customer c);
        void WithdrawMoney(Customer c);
        void CheckBalance(Customer c);
        void MiniStatement(Customer c);
        void Deposit(Customer c);
        void BankTransfer();

    }
}
