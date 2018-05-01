using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Module_1
{
     public class DrinksMachine
    {
       public DrinksMachine(string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Model = model;
        }
       
        private string _location;
        public string Location
        {
            get
            {
                return _location;
            }

            set
            {
                _location = value;
            }
        
    }
        private string _model;
        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
            }
        }
        private string _make;
        public string Make
        {
            get
            {
                return _make;
            }

            set
            {
                _make = value;
            }
        }


        // encapulated example
        private int age;
        private string make;


        // public properties
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        //public string Make
        //{
        //    get
        //    {
        //        return make;
        //    }
        //    set
        //    {
        //        make = value;
        //    }
        //}

        //auto-implemented property
        //public string Model { get; set; }

        // Static Classes
        public static class Conversions
        {
            public static double PoundsToKilos(double pounds)
            {
                // Convert argument from pounds to kilograms
                double kilos = pounds * 0.4536;
                return kilos;
            }
            public static double KilosToPounds(double kilos)
            {
                // Convert argument from kilograms to pounds
                double pounds = kilos * 2.205;
                return pounds;
            }
        }

        ////Calling Methods on a Static Class
        //double weightInKilos = 80;
        //double weightInPounds = Conversions.KilosToPounds(weightInKilos);

        //// Constructors
        public DrinksMachine(int age)
        {
            this.Age = age;
        }
        public DrinksMachine(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }
        public DrinksMachine(int age, string make, string model)
        {
            this.Age = age;
            this.Make = make;
            this.Model = model;
        }

        // Auto-implemented properties 
        public double TotalPurchases { get; set; }
        public string Name { get; set; }
        public int CustomerID { get; set; }

       

        public void MakeCappuccino()
        {
            Console.WriteLine("Cappuccino is made");
        }
        // Calling Constructors
        
        //    public void MakeEspresso()
        //    {
        //        // Method logic goes here.
        //    }
        //    // The following statement defines an event. The delegate definition is not shown.
        //    public event OutOfBeansHandler OutOfBeans;

        // private member variables
    }
}
