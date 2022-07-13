using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOLEAN_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qualifications for Car Insurance");
            Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? Please answer “true” or “false”");
            string DUItruefalse = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have? Please enter a number.");
            int ticket = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            bool Qualified = (age > 15 && DUItruefalse == "false" &&  ticket <= 3);
            Console.WriteLine("Are you Qualified? True/False: " + Qualified);
            Console.ReadLine();
        }
    }
}
