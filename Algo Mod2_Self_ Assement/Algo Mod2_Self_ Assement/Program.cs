using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Mod2_Self__Assement
{
    class Program
    {
       
        static void Main(string[] args)
        {
            student myStudent1 = new student();
            myStudent1.firstName = "Joe";
            myStudent1.lastName = "Santagoto";
            myStudent1.studentNumber = 567432;
            myStudent1.Study();

            student myStudent2 = new student();
            myStudent2.firstName = "Mark";
            myStudent2.lastName = "Hamil";
            myStudent2.studentNumber = 876234;
            myStudent2.Study();

            student myStudent3 = new student();
            myStudent3.firstName = "Paul";
            myStudent3.lastName = "Smith";
            myStudent3.studentNumber = 987645;
            myStudent3.Study();

            student myStudent4 = new student();
            myStudent4.firstName = "Sarah";
            myStudent4.lastName = "Joe";
            myStudent4.studentNumber = 123678;
            myStudent4.Study();

            student myStudent5 = new student();
            myStudent4.firstName = "Joel";
            myStudent4.lastName = "Stuart";
            myStudent4.studentNumber = 234765;
            myStudent4.Study();

            string[] studentArray = new string[5];
            studentArray[0] = myStudent1.firstName;
            studentArray[1] = myStudent2.firstName;
            studentArray[2] = myStudent3.firstName;
            studentArray[3] = myStudent4.firstName;
            studentArray[4] = myStudent5.firstName;

            Console.WriteLine("The following students are in this class {0}, {1}, {2}, {3}, {4}", studentArray[0], studentArray[1], studentArray[2], studentArray[3], studentArray[4]);

            string forEachTotal = "";
            foreach (string stu in studentArray)
            {
                forEachTotal = forEachTotal + stu + " ";
            }
            Console.WriteLine(forEachTotal); 
        }
        struct student
        {
            public string firstName;
            public string lastName;
            public int studentNumber;

            public void Study()
            {
                Console.WriteLine("Student {0} is studying", firstName);
            }
        }

        struct teacher
        {
            public string firstName;
            public string lastName;
            public int studentNumber;

            public void GradeAssigment()
            {
                Console.WriteLine("Teacher {0} is marking", firstName);
            }
        }
    }
}
