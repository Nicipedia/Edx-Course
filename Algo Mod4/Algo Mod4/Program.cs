using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Mod4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Generic Class
            public class CustomList<T>
        {
            public T this[int index] { get; set; }
            public void Add(T item)
            {
                // Method logic goes here.
            }
            public void Remove(T item)
            {
                // Method logic goes here.
            }
        }
        // Type Safety Limitations for Non-Generic Collections
        var coffee1 = new Coffee();
            var coffee2 = new Coffee();
            var tea1 = new Tea();
            var arrayList1 = new ArrayList();
            arrayList1.Add(coffee1);
            arrayList1.Add(coffee2);
            arrayList1.Add(tea1);
            // The Sort method throws a runtime exception because the collection is not homogenous.
            arrayList1.Sort();
            // The cast throws a runtime exception because you cannot cast a Tea instance to a Coffee instance.
            Coffee coffee3 = (Coffee)arrayList1[2];
        

            // Type Safety in Generic Collections
            var coffee1 = new Coffee();
            var coffee2 = new Coffee();
            var tea1 = new Tea();
            var genericList1 = new List<Coffee>();
            genericList1.Add(coffee1);
            genericList1.Add(coffee2);
            // This line causes a build error, as the argument is not of type Coffee.
            genericList1.Add(tea1);
            // The Sort method will work because the collection is guaranteed to be homogenous.
            genericList1.Sort();
            // The indexer returns objects of type Coffee, so there is no need to cast the return value.
            Coffee coffee3 = genericList[1];


            // Boxing and Unboxing: Generic vs. Non-Generic Collections
            int number1 = 1;
            var arrayList1 = new ArrayList();
            // This statement boxes the Int32 value as a System.Object.
            arrayList1.Add(number1);
            // This statement unboxes the Int32 value.
            int number2 = (int)arrayList1[0];
            var genericList1 = new List<Int32>();
            //This statement adds an Int32 value without boxing.
            genericList1.Add(number1);
            //This statement retrieves the Int32 value without unboxing.
            int number3 = genericList1[0];

            // Using the List<T> Class
            string s1 = "Latte";
            string s2 = "Espresso";
            string s3 = "Americano";
            string s4 = "Cappuccino";
            string s5 = "Mocha";
            // Add the items to a strongly-typed collection.
            var coffeeBeverages = new List<String>();
            coffeeBeverages.Add(s1);
            coffeeBeverages.Add(s2);
            coffeeBeverages.Add(s3);
            coffeeBeverages.Add(s4);
            coffeeBeverages.Add(s5);
            // Sort the items using the default comparer. 
            // For objects of type String, the default comparer sorts the items alphabetically.
            coffeeBeverages.Sort();
            // Write the collection to a console window.
            foreach(String coffeeBeverage in coffeeBeverages)
                {
               Console.WriteLine(coffeeBeverage);
                }

    // Default and Alternative Enumerators
    class CustomCollection<T> : IEnumerable<T>
    {
        public IEnumerator<T> Backwards()
        {
            // This method returns an alternative enumerator.
            // The implementation details are not shown.
        }
        #region IEnumerable<T> Members
        public IEnumerator<T> GetEnumerator()
        {
            // This method returns the default enumerator.
            // The implementation details are not shown.
        }
        #endregion
        #region IEnumerable Members
        IEnumerator IEnumerable.GetEnumerator()
        {
            // This method is required because IEnumerable<T> inherits from IEnumerable
            throw new NotImplementedException();
        }
        #endregion
    }

        // Enumerating a Collection
        CustomCollection<Int32> numbers = new CustomCollection<Int32>();
        // Add some items to the collection.
        // Use the default enumerator to iterate through the collection:
        foreach (int number in numbers)
        {
           // …
        }
        // Use the alternative enumerator to iterate through the collection:
        foreach(int number in numbers.Backwards())
        {
           // …
        }
}
    }

