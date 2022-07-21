using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_WHILE_LOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year was Queen Elizabeth born?");
            int age = Convert.ToInt32(Console.ReadLine());
            bool theanswer = false;

            do
            {
                switch (age)
                {
                    case 1970:
                        Console.WriteLine("You guessed 1970. Try again");
                        Console.WriteLine("What year was Queen Elizabeth born?");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1955:
                        Console.WriteLine("You guessed 1955. Try again");
                        Console.WriteLine("What year was Queen Elizabeth born?");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1926:
                        Console.WriteLine("Yes! She was born on April 21, 1926");
                        theanswer = true;
                        break;
                    default:
                        Console.WriteLine("Try again.");
                        Console.WriteLine("What year was Queen Elizabeth born?");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!theanswer);
            Console.Read();
        }
    }
}
