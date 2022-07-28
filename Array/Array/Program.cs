using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Please select a number from 0 to 6, digits will be assigned to you.");
            int answer = Convert.ToInt32(Console.ReadLine());
            int[] intList = new int[] { 55, 100, 65, 98, 16, 57, 63 };

                Console.WriteLine("Your assigned digit is: " + intList[answer]);
                Console.ReadLine();


            

            Console.WriteLine("Select a Letter from 0 to 4 for a message");
            int answerString = Convert.ToInt32(Console.ReadLine());
            string[] message = { "Hello!", "You are amazing!", "Stay Strong!", "You can do it!", "Take care!" };

            Console.WriteLine(message[answerString]);
            Console.Read();

        }
    }
}
