﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Mod2_Lab1
{
    abstract class Employee
    {
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;
        public string Name
        {
            get
            {
                return employeeName;
            }

            set
            {
                employeeName = value;
            }
        }
        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }

            set
            {
                employeeBaseSalary = value;
            }
        }
        public int ID
        {
            get
            {
                return employeeId;
            }

            set
            {
                employeeId = value;
            }
        }

        // Constructor
        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }

        // This method returns the employee's base salary
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }

        // This method returns the employee's name
        public String getName()
        {
            return this.Name;
        }

        // This method returns the employee's ID
        public int getEmployeeID()
        {
            return this.ID;
        }

        // Creates inter variable called "employeeCount and assigns value to 1
        private static int employeeCount = 1;

       public string toString()
        {
            return this.ID + " " + this.Name;
        }

        //// This method returns the employee's ID and Name and confirms that the employee is in the system
        //public virtual String employeeStatus()
        //{
        //    return toString() + " is in the company's system";
        //}
        // Abstract method
        public abstract string employeeStatus();
    }
}
