using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Module_1
{
   class Program
    {
        static void Main(string[] args)
        {
            DrinksMachine myMachine = new DrinksMachine("Kitchen", "Brand", "DM1000");
            //myMachine.Location = "kitchen";
            //myMachine.Model = "DM1000";
            var dm1 = new DrinksMachine(2);
            var dm2 = new DrinksMachine("Fourth Coffee", "BeanCrusher 3000");
            var dm3 = new DrinksMachine(3, "Fourth Coffee", "BeanToaster Turbo");
            

            Console.WriteLine(myMachine.Location);
            Console.WriteLine(myMachine.Make);
            Console.WriteLine(myMachine.Model);
            myMachine.MakeCappuccino();

            Console.WriteLine(Math.Pow(2, 8));


        }
    }
}
