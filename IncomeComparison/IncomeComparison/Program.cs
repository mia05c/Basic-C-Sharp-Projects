﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine();
            Console.WriteLine("Person 1 \n  Hourly Rate: $15.00 \n  Hours worked per week: 40 hours ");
            Console.WriteLine();
            Console.WriteLine("Annual salary of Person 1: $31200");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Person 2 \n  Hourly Rate: $20.00 \n  Hours worked per week: 40 hours ");
            Console.WriteLine();
            Console.WriteLine("Annual salary of Person 2: $41600");
            Console.WriteLine();

            int person1 = 31200;
            int person2 = 41600;

            bool TrueOrFalse = person1 > person2;
            Console.WriteLine();
            Console.WriteLine("Person 1 makes more money than Person 2: " + TrueOrFalse);
            Console.ReadLine();
        }
    }
}
