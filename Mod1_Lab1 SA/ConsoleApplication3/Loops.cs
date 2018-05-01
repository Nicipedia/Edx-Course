using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Loops
    {
        static void Main(string[] args)
        {
            #region Repetition Statement
            int whileCounter = 0;
            int doCounter = 0;

            Console.WriteLine("for loop");
            Console.WriteLine();

            for (int forCounter = 0; forCounter < 10; forCounter++)
            {
                Console.WriteLine("forCouter is at " + forCounter);

            }

            Console.WriteLine();
            Console.WriteLine("while loop");
            Console.WriteLine();

            while (whileCounter < 5)
            {
                Console.WriteLine("whileCounter is at " + whileCounter);
                whileCounter++;
            }

            Console.WriteLine();
            Console.WriteLine("do loop");
            Console.WriteLine();

            do
            {
                Console.WriteLine("whileCounter is at " + doCounter);
                doCounter++;
            } while (doCounter < 5);

            Console.WriteLine();
            Console.WriteLine("recursion");
            Console.WriteLine();

            long value = Factorial(10);
            Console.WriteLine(value);


            #endregion
        }
        static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
