﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please follow instructions: Basic Calculator");
            Console.Write("Enter a number, we will multiply it by 50: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = 50;
            int product1 = num1 * num2;
            Console.WriteLine("The answer is:" + product1);
            Console.ReadLine();

            Console.WriteLine("Addition");
            Console.Write("Enter a number, we will add 25: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = 25;
            int total = num3 + num4;
            Console.WriteLine("The answer is:" + total);
            Console.ReadLine();

            Console.WriteLine("Division");
            Console.Write("Enter a number, we will divide to 12.5: ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            float num6 = 12.5f;
            float quotient = num5 / num6;
            Console.WriteLine("The answer is:" + quotient);
            Console.ReadLine();

            Console.Write("Enter a number: ");
            int num7 = Convert.ToInt32(Console.ReadLine());
            int num8 = 50;

            bool TrueOrFalse = num7 > num8;
            Console.WriteLine("Is your number greater than 50?: " + TrueOrFalse);
            Console.ReadLine();

            Console.WriteLine("Remainder");
            Console.Write("Enter a number: ");
            int num9 = Convert.ToInt32(Console.ReadLine());
            int num10 = 7;
            float remainder = num9 % num10;
            Console.WriteLine("The remainder is:" + remainder);
            Console.ReadLine();

        }
    }
}
