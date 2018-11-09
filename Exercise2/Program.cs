using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods Akems = new Methods("Akem", 200);

            //Menu
            Console.WriteLine("Welcome to Brar Bank");
            Console.WriteLine("1. Check Balance\n" +
                "2. Deposit\n" +
                "3. Withdraw");
            int initialAnswer = int.Parse(Console.ReadLine());

            if (initialAnswer == 1)
            {
                Console.WriteLine("Do you wish to check your Account balance (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine(Akems.Name + " your remaining balance is: " + Akems.Balance);
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Thank You!");
                }
                Console.ReadLine();
            }

            else if (initialAnswer == 2)
            {
                //Deposit
                Console.WriteLine("Do you wish to deposit (yes/no)");
                string depoAnswer = Console.ReadLine();
                if (depoAnswer == "yes")
                {
                    Console.WriteLine("Enter an ammount");
                    double enteredAmmount = double.Parse(Console.ReadLine());
                    Console.WriteLine("Your Balance: " + Akems.Deposit(enteredAmmount));
                }
                else if (depoAnswer == "n")
                {
                    Console.WriteLine("Thank You");
                }

                Console.ReadLine();
            }

            else if ( initialAnswer == 3)
            {
                //Withdraw
                Console.WriteLine("Enter a ammount you want to withdraw: ");
                double ammount = double.Parse(Console.ReadLine());
                Console.WriteLine("After this withdraw your remaining ammount is: " + Akems.Withdraw(ammount));
                Console.ReadLine();
            }
        }
    }
}
