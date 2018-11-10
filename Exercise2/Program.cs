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
            Methods Loves = new Methods("Love", 500);

            ////Menu

            Console.WriteLine("Welcome to Brar Bank");
            Console.WriteLine("1. Check Balance\n" +
                "2. Deposit\n" +
                "3. Withdraw\n" +
                "4. Transfer");
            int initialAnswer = int.Parse(Console.ReadLine());

            if (initialAnswer == 1)
            {
                Console.WriteLine("Do you wish to check your Account balance (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine(Akems.Name + " your remaining balance is: " + Akems.Balance);
                    Console.WriteLine(Loves.Name + " your balance is: " + Loves.Balance);
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Thank You!");
                    Console.ReadLine();
                }
            }
            else if (initialAnswer == 2)
            {
                //Deposit
                Console.WriteLine("Do you wish to deposit (yes/no)");
                string depoAnswer = Console.ReadLine();
                if (depoAnswer == "yes")
                {
                    Console.WriteLine("Choose an account: \n" +
                        "1. Akem\n" +
                        "2. Love");
                    int ans = int.Parse(Console.ReadLine());
                    if (ans == 1)
                    {
                        Console.WriteLine("Enter an ammount");
                        double enteredAmmount = double.Parse(Console.ReadLine());
                        Console.WriteLine("Your Balance: " + Akems.Deposit(enteredAmmount));
                    }

                    else if (ans == 2)
                    {
                        Console.WriteLine("Enter an amount");
                        double enteredAmmount = double.Parse(Console.ReadLine());
                        Console.WriteLine("Your Balance: " + Loves.Deposit(enteredAmmount));
                    }

                }
                else if (depoAnswer == "n")
                {
                    Console.WriteLine("Thank You");
                }
                Console.ReadLine();
            }

            else if (initialAnswer == 3)
            {
                //Withdraw
                Console.WriteLine("Choose an account: \n" +
                        "1. Akem\n" +
                        "2. Love");
                int ans = int.Parse(Console.ReadLine());
                if (ans == 1)
                {
                    Console.WriteLine("Enter a ammount you want to withdraw: ");
                    double ammount = double.Parse(Console.ReadLine());
                    Console.WriteLine(Akems.Name + " after this withdraw your remaining ammount is: " + Akems.Withdraw(ammount));
                }
                else if (ans == 2)
                {
                    Console.WriteLine("Enter a ammount you want to withdraw: ");
                    double ammount = double.Parse(Console.ReadLine());
                    Console.WriteLine(Loves.Name + " After this withdraw your remaining ammount is: " + Loves.Withdraw(ammount));
                }
                Console.ReadLine();
            }

            else if (initialAnswer == 4)
            {
                //transaction
                Console.WriteLine("Do you want to transfer (y/n)");
                string transAns = Console.ReadLine();
                if (transAns == "y")
                {
                    Console.WriteLine("Choose an account you want to transfer from: \n" +
                        "1. Akem\n" +
                        "2. Love");
                    int ans = int.Parse(Console.ReadLine());
                    if (ans == 1)
                    {
                        Console.WriteLine("How much do you want to transfer?");
                        double transAmm = double.Parse(Console.ReadLine());
                        Console.WriteLine(Akems.Name + " Your Remaining balance is: " + Akems.SubtractAmmount(transAmm));
                        Loves.Transaction(transAmm);


                        Console.WriteLine("love do you want to see your balance (y/n)");
                        string answer = Console.ReadLine();
                        if (answer == "y")
                        {
                            Console.WriteLine(Loves.Name + " Your Balance is: " + Loves.Balance);
                        }
                        else if (answer == "n")
                        {
                            Console.WriteLine("Thank you!");
                        }
                    }

                    if (ans == 2)
                    {
                        Console.WriteLine("How much do you want to transfer?");
                        double transAmm = double.Parse(Console.ReadLine());
                        Console.WriteLine(Loves.Name + " Your Remaining balance is: " + Loves.SubtractAmmount(transAmm));
                        Akems.Transaction(transAmm);


                        Console.WriteLine("akem do you want to see your balance (y/n)");
                        string answer = Console.ReadLine();
                        if (answer == "y")
                        {
                            Console.WriteLine(Akems.Name + " Your Balance is: " + Akems.Balance);
                        }
                        else if (answer == "n")
                        {
                            Console.WriteLine("Thank you!");
                        }
                    }

                    Console.ReadLine();
                }
            }
                Console.ReadLine();
        }
    }
}
