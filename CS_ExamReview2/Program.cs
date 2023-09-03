using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ExamReview2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! My name is Kim, and I will be doing a few practice problems using C#!");
            Console.WriteLine();
            Console.WriteLine();

            // PRINTING AND VARDAT (DISPLAYING THE SUM, DIFFERENCE, PRODUCT, AND QUOTIENT OF ALL VALUES)

            Console.WriteLine("1. DECLARING VARIABLES");
            Console.WriteLine();

            Console.WriteLine("Displaying the sum, difference, product, and quotient of all values.");
            Console.WriteLine();

            int x, y, xyVal; // declare variables

            Console.Write("Input First Value: "); 
            x = Int32.Parse(Console.ReadLine()); // user to input

            Console.Write("Input Second Value: ");
            y = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("-------------------------");

            Console.WriteLine();

            xyVal = x + y;
            Console.WriteLine("The sum of " + x + " and " + y + " is: " + xyVal);
            Console.WriteLine();

            xyVal = x - y;
            Console.WriteLine("The difference of " + x + " and " + y + " is: " + xyVal);
            Console.WriteLine();

            xyVal = x * y;
            Console.WriteLine("The product of " + x + " and " + y + " is: " + xyVal);
            Console.WriteLine();

            float qVal = (float) x / (float) y;
            Console.WriteLine("The quotient of " + x + " and " + y + " is: " + String.Format("{0:0.00}", qVal));
            Console.WriteLine();

            Console.WriteLine();

            // IF ELSE (GETTING THE AVERAGE OF ALL VALUES)

            Console.WriteLine("2. IF ELSE STATEMENT");
            Console.WriteLine();

            Console.WriteLine("The average of all values + Speedometer");
            Console.WriteLine();

            int x1, x2, x3, x4, x5; // variables

            Console.Write("Input First Number: ");
            x1 = Int32.Parse(Console.ReadLine());

            Console.Write("Input Second Number: ");
            x2 = Int32.Parse(Console.ReadLine());

            Console.Write("Input Third Number: ");
            x3 = Int32.Parse(Console.ReadLine());

            Console.Write("Input Fourth Number: ");
            x4 = Int32.Parse(Console.ReadLine());

            Console.Write("Input Fifth Number: ");
            x5 = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("-------------------------");

            Console.WriteLine();

            float qAll = (float ) (x1 + x2 + x3 + x4 + x5) / (float) 5;
            Console.Write("The average of all values is: " + String.Format("{0:0.00}", qAll) + ". Therefore, the speed is: ");

            if (qAll >= 120)
            {
                Console.WriteLine("Overspeeding.");
            }

            else if (qAll >= 35)
            {
                Console.WriteLine("Fast.");
            }

            else if (qAll >= 20)
            {
                Console.WriteLine("Moderate Speed.");
            }

            else if (qAll >= 1)
            {
                Console.WriteLine("Slow.");
            }

            else
            {
                Console.WriteLine("At rest.");
            }

            Console.ReadKey();
        }
    }
}
