using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_Self_Assement
{
    class Program
    {
        static void Main(string[] args)
        {
            string sfirstName;
            string slastName;
            DateTime sbirthDate;
            string saddressLine1;
            string saddressLine2;
            string sCity;
            string sState;
            int spostalCode;
            string sCountry;

            GetStudentInformation();
            GetTeacherInformation();
            GetProgramInformation();
            GetDegreeInformation();
            GetCourseInformation();

        }
        #region Methods

        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthdate (DD/MM/YY): ");
            string date = Console.ReadLine();
            DateTime birthday = Convert.ToDateTime(date);


            PrintStudentDetails(firstName, lastName, birthday);
        }
        static void PrintStudentDetails(string isThisAStudent, int count, string firstName, string lastName, DateTime birthDate)
        {
            Console.WriteLine("\r\n{0} Name: {1} {2}\r\nID number: {3}\r\nwas born in {4}.\r\n", isThisAStudent, firstName, lastName, count, birthDate.Year);
        }
        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teachers's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's birthdate (DD/MM/YY): ");
            string date = Console.ReadLine();
            DateTime birthday = Convert.ToDateTime(date);
            bool isStudent = false;
            string isThisAStudent;
            if (isStudent)
            {
                isThisAStudent = "Student";
            }
            else
            {
                isThisAStudent = "Teacher";
            }
            PrintTeacherDetails(firstName, lastName, birthday);
        }

        static void PrintTeacherDetails(string first, string last, DateTime birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }
        static void GetProgramInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
        }
        #endregion Methods
    }
}