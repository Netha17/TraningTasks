using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMProject
{
    //THis is a factory class, which has GetAtm method, which returns the instance of the 
    //desired ATM machine (sbi or axis) 
    internal class AtmFactory
    {
        public IAtm GetAtm(int atmId)
        {
            if(atmId==1)
            {
                return new SbiAtm();
            }
            else if(atmId==2)
            {
                return new AxisAtm();
            }
            else
            {
                Console.WriteLine("No ATM found");
                return null;
            }
        }
    }
}
