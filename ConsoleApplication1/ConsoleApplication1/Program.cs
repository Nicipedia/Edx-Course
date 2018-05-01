using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables, Operators, and Expressions
            int myVar = 2;
            int secondVar;
            secondVar = 10;

            int sum = myVar + secondVar;
            int product = myVar * secondVar;
            int remainder = myVar % secondVar;
            double value = (double)myVar / (double)secondVar;
            int myInt = (int)value;

            Console.WriteLine(sum);
            Console.WriteLine(product);
            Console.WriteLine(remainder);
            Console.WriteLine(value);
            Console.WriteLine(myInt);

            string firstName = "Tom";
            string lastName = "Saywer";

            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            Console.WriteLine("{0} {1}", firstName, lastName);

            #endregion
        }
    }
}