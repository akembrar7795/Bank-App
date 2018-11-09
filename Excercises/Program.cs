using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please Input Your Name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Welcome " + name);
            //Console.WriteLine("Have a nice day!");
            //Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of two numbers is: " + Sum(firstNumber, secondNumber));
            Console.ReadLine();
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

    }
}