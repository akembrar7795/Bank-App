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

        //Methods

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

        public double AddAmmount ( double ammount)
        {
            double newBalance = Balance + ammount;
            return newBalance;
        }

        public double SubtractAmmount (double ammount)
        {
            double newBalance = Balance - ammount;
            return newBalance;
        }

        public void Transaction ( double transactionAmm)
        {
            Balance += transactionAmm;
            Methods name = new Methods(Name, Balance);
            name.AddAmmount(transactionAmm);
        }
    }
}
