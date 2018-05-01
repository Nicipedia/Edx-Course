using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class loops
    {
        static void Main(string[] args)
        {
            for ([initializers]; [condition]; [iterator])
             {
         // code to repeat goes here
             }
        }

        {//for Loop
            for (int i = 0; i< 10; i++)
            {
                // Code to execute.
            }
        }
       //foreach Loop
           { string[] names = new string[10];

            // Process each name in the array.
            foreach (string name in names)
            {
                // Code to execute.
            }
            //while Loop

        string response = promptuser();
        while (response != "quit")
        {
            // process the data.
            response = promptuser();
        }
        //do loop
           { do
            {
                // process the data.
                response = promptuser();
            } while (response != "quit");
    }
 }

