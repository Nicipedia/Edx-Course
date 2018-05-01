using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int counter = 0; counter < 9; counter++)
            //{
            //    if {

            //        Console.WriteLine("OXOXOXOX");
            //    }

            //}
            //int outer;
            //int inner;

            //for (outer = 2; outer < 100; outer++)
            //{
            //    for (inner = 2; inner <= (outer / inner); inner++)
            //        if ((outer % inner) == 0) break; // if factor found, not prime
            //    if (inner > (outer / inner))
            //        Console.WriteLine("{0} is prime", outer);
            //}
            //int n = 1;
            //while (n < 6)
            //{
            //    Console.WriteLine($"Current value of n is {n}");
            //    n++;
            //}
            //int x = 0;
            //do
            //{
            //    Console.WriteLine(x);
            //    x++;
            //} while (x < 5);

            for (int column = 0; column < 8; column++)  // will create 8 row x 8 column pattern
            {
                for (int row = 0; row < 8; row++)
                {
                    if ((row + column) % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else if ((row + column) % 2 == 1)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write("Neither X nor O");  // Built in unit test if logic for X and O fails
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
