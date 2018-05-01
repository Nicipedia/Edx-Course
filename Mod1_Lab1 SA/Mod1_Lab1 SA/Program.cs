using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1_SA
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

            string tfirstName;
            string tlastName;
            DateTime tbirthDate;
            string taddressLine1;
            string taddressLine2;
            string tCity;
            string tState;
            int tpostalCode;
            string tCountry;

            string programName;
            string departHead;
            string degrees;

            string degreeName;
            int creditsReq;

            string courseName;
            int credits;
            int durationInWeeks;
            string teachers;

            sfirstName = "Peter";
            slastName = "Parker";
            sbirthDate = new DateTime(1991, 8, 9);
            saddressLine1 = "56 Fire Street";
            saddressLine2 = "cnr Water Ave";
            sCity = "Earth Town";
            sState = "Windness";
            spostalCode = 4563;
            sCountry = "Elementala";

            tfirstName = "Tony";
            tlastName = "Stark";
            tbirthDate = new DateTime(1984, 3, 24);
            taddressLine1 = "Jarvis Manor";
            taddressLine2 = "Reactor Lane";
            tCity = "Metropolis";
            tState = "Technolica";
            tpostalCode = 3457;
            tCountry = "Elementala";

            programName = "Advance Innovation and Technology";
            departHead = "Dr T Stark";
            degrees = "Quantum Entanglement," + " Mechatronics and Advanced Robotics";

            degreeName = " Mechatronics and Advanced Robotics";
            creditsReq = 24;

            courseName = "Intro to Mechanincal Structures";
            credits = 6;
            durationInWeeks = 12;
            teachers = "Dr T Stark";

            Console.WriteLine("Student information:\n First Name: {0} \n Last Name:{1} \n Age:{2} ", sfirstName, slastName, sbirthDate);
            Console.WriteLine("Student Address information:\n {0} \n {1} \n {2} \n {3} \n {4} \n {5}", saddressLine1, saddressLine2, sCity, sState, spostalCode, sCountry);
            Console.WriteLine("Teacher information:\n First Name: {0} \n Last Name:{1} \n Age:{2} ", tfirstName, tlastName, tbirthDate);
            Console.WriteLine("Teacher Address information:\n {0} \n {1} \n {2} \n {3} \n {4} \n {5}", taddressLine1, taddressLine2, tCity, tState, tpostalCode, tCountry);
            Console.WriteLine("");
            Console.WriteLine("Program Name: " + programName);
            Console.WriteLine("Department Head: " + departHead);
            Console.WriteLine("Degrees Offered: " + degrees);
            Console.WriteLine("");
            Console.WriteLine("Degree Name: " + degreeName);
            Console.WriteLine("Credits Required: " + creditsReq);
            Console.WriteLine("");
            Console.WriteLine("Course Info:\n Name: {0} \n Credits: {1} \n Duration in Weeks: {2} \n Presented By: {3} ", courseName, credits, durationInWeeks, teachers);

        }
    }
}
