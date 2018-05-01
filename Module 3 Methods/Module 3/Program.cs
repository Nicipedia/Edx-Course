using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsToTest
{
    class Program
    {
        private static string sValue;

        static void Main(string[] args)
        {
            #region Exception Handling

            double a = 98, b = 0;
            double result = 0;

            try
            {
                result = SafeDivision(a, b);
                Console.WriteLine("{0} divided by {1} = {2}", a, b, a / b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Attempted to divide by zero.");
            }
            #endregion Exception Handling

            #region Methods
            //First Method returns nothing and accepts no parameters
            PrintSomething();

            // Create some variables for use in a method call
            int first = 10;
            int second = 2;
            string sValue;

            // This method call will expect a single value returned
            // So the return value must be asssigned to something 
            // We also pass in two arguments to the method
            //int result = Sum(first, second);
            //Console.WriteLine("The sum of {0} and {1} is: {2}", first, second, result);

            // C# methos typically only return a single value
            // You can use out or ref as a way of returning multiple items from a method
            // Using out
            ReturnMultiOut(out first, out sValue);
            Console.WriteLine("{0}, {1}", first.ToString(), sValue);

            // USing ref requires that the varibles be initialized first
            sValue = "";
            ReturnMultiRef(ref first, ref sValue);
            Console.WriteLine("{0}, {1}", first.ToString(), sValue);

            //Using Named Parameters 
            Area(length: 30, width: 50);

            //Using optional parameters
            OptionalParams(10, 20);

            #endregion Methods
        }


        #region Called Methods
        static void PrintSomething()
        {
            Console.WriteLine("PrintSomething() method was called.");
        }
        static int Sum(int value1, int value2)
        {
            return value1 + value2;
        }
        static void ReturnMultiOut(out int i, out string s)
        {
            i = 25;
            s = "using out";
        }
        static void ReturnMultiRef(ref int i, ref string s)
        {
            i = 25;
            s = "using ref";
        }
        static void Area(int length, int width)
        {
            Console.WriteLine("The area is {0}", length * width);
        }
        static void OptionalParams(int one, int two, string s = "default text")
        {
            Console.WriteLine("{0}, {1}, {2}", one, two, s);
        }

        static double SafeDivision (double x, double y)
        {
            if (y == 0)
                throw new System.DivideByZeroException();
            return x / y;
        }
        #endregion Called Methods



    }
}

