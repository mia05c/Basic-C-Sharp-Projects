using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter your name: ");
            string yourName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string yourAge = Console.ReadLine();
            Console.Write("Please enter your favorite Number: ");
            string yourFavoriteNumber = Console.ReadLine();

            yourName = yourName.ToUpper();

            Console.Write(" My Name is " + yourName + ". I am " + yourAge+ " years old. And my favorite number is " +yourFavoriteNumber+ ".");
            Console.ReadLine();

            

        }
    }
}
