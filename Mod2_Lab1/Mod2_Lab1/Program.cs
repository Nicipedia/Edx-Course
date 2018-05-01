using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter an integer value and press Enter.");

            //int input = Int32.Parse(Console.ReadLine());
            //if(input % 2 == 0)
            //{
            //    Console.WriteLine("The entered number was an even number.");
            //}
            //else
            //{
            //    Console.WriteLine("The enter number was not an even number.");
            //}
            Console.WriteLine("Coffee sizes: 1=small 2 medium 3 large");
            Console.WriteLine("Please enter your selection: ");
            string str = Console.ReadLine();
            int cost = 0;

            switch (str)
            {
                case "1":
                case "small":
                    cost += 25;
                    break;
                case "2":
                case "medium":
                    cost += 50;
                    break;
                case "3":
                case "large":
                    cost += 75;
                    break;
                default:
                    Console.WriteLine("Invaild Selection. Please select 1, 2, or 3.");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("Please insert {0} cents.", cost);
            }
            Console.WriteLine("Thank you for your business.");
        }
    }
}
