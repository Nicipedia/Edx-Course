using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Mod3
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Create a new Hashtable collection.
            //Hashtable ingredients = new Hashtable();


            //// Add some key/value pairs to the collection.
            //ingredients.Add("Café au Lait", "Coffee, Milk");
            //ingredients.Add("Café Mocha", "Coffee, Milk, Chocolate");
            //ingredients.Add("Cappuccino", "Coffee, Milk, Foam");
            //ingredients.Add("Irish Coffee", "Coffee, Whiskey, Cream, Sugar");
            //ingredients.Add("Macchiato", "Coffee, Milk, Foam");


            //// Check whether a key exists.
            //if (ingredients.ContainsKey("Café Mocha"))
            //{
            //    // Retrieve the value associated with a key.
            //    Console.WriteLine("The ingredients of a Café Mocha are: {0}", ingredients["Café Mocha"]);
            //}

            //// Iterating Over a Dictionary Collection
            //foreach (string key in ingredients.Keys)
            //{
            //    // For each key in turn, retrieve the value associated with the key.  
            //    Console.WriteLine("The ingredients of a {0} are {1}", key, ingredients[key]);
            //}

       
            List<Employee> employees = new List<Employee>()
            {
            new Employee() { empID = 001, Name = "Tom", Department= "Sales"},
            new Employee() { empID = 024, Name = "Joan", Department= "HR"},
            new Employee() { empID = 023, Name = "Fred", Department= "Accounting" },
            new Employee() { empID = 040, Name = "Mike", Department= "Sales" },
            };


            // Find the member of the list that has an employee id of 023
            Employee match = employees.Find((Employee p) => { return p.empID == 023; });
            Console.WriteLine("empID: {0}\nName: {1}\nDepartment: {2}", match.empID, match.Name, match.Department);
        }
    }
}
