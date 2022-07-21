using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Quote_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.Write("Please enter the package weight:");
            
            int numWeight = Convert.ToInt32(Console.ReadLine());
            int actualWeight = 50;

            if (numWeight > actualWeight)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
                Console.ReadLine();

                return;
                
            }
            
 
            Console.Write("Please enter the package width: ");
            int numwidth = Convert.ToInt32(Console.ReadLine());
     

            Console.Write("Please enter the package height: ");
            int numheight = Convert.ToInt32(Console.ReadLine());


            Console.Write("Please enter the package length: ");
            int numlength = Convert.ToInt32(Console.ReadLine());

            int total = numheight + numwidth + numlength;
            int TotalDimension = 50;

            if (total > TotalDimension)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
                Console.ReadLine();

                return;
            }

            
            int prduct = numheight * numwidth * numlength;
            int multiplyy = prduct * numWeight;
            int divideAns = 100;
            int final = multiplyy / divideAns;
            

            Console.Write("Your estimated total for shipping this package is: $" +final);
            
            Console.Read();
        }
    }
}
