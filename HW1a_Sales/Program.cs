// HW1a Sales Total

// Your Name: Peyton Turney
// Did you seek help ? If yes, specify the helper or web link here: No help from outside sources.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // What I need: product name, product #, product price, subtotal, sales tax = 8.5%, then total

            double num1;
            double num2;

            double sum;
            double sum2;

            const double multiplier = 0.085;

            string num1AsString;
            string productname;
            string num2AsString;

            Console.WriteLine("Welcome to Peyton's Store. What product would you like to purchase?");
            productname = Console.ReadLine();
            Console.WriteLine($"Sounds great. How many {productname}s?"); // String interpolation
            num1AsString = Console.ReadLine();
            Console.WriteLine("Sorry I don't have my glasses on. What's the price for that?");
            num2AsString = Console.ReadLine();

            num1 = Convert.ToDouble(num1AsString);
            num2 = Convert.ToDouble(num2AsString);

            sum = num1 * num2;
            Console.WriteLine($"Your total is {sum.ToString("C")}");

            sum2 = sum * multiplier;
            Console.WriteLine($"Your subtotal is {sum2.ToString("C")}");

            sum = sum2 + sum;
            Console.WriteLine($"Your total comes to {sum.ToString("C")}");

        }
    }
}
