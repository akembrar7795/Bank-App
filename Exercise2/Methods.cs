using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Methods
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        
        //constructor
        public Methods(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }


        public double Withdraw(double withdrawAmmount)
        {
            double remaining = Balance - withdrawAmmount;
            return remaining;
        }

        public double Deposit( double AmmountDeposit)
        {
            double newBalance = Balance + AmmountDeposit;
            return newBalance;
        }
    }
}
