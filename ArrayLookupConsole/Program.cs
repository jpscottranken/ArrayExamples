using System;
using static System.Console;

/*
 *      This is a fairly simple array lookup
 *      program. 
 *      
 *      There will be 3 parallel arrays:
 *      
 *      *   One for first name. 
 *      *   One for last name. 
 *      *   One for grades.
 *      
 *      The user can search for the presence
 *      or absence of a first name or a last
 *      name.
 */

namespace ArrayLookupConsole
{
    class Program
    {
        //  Program constants
        const int NUMSTUDENTS = 5;
        const string THERE = " WAS FOUND";
        const string NOTTHERE = " WAS NOT FOUND";


        //  Global variables
        static string[] firstName = new string[NUMSTUDENTS];
        static string[] lastName = new string[NUMSTUDENTS];
        static int[] studGrades = new int[NUMSTUDENTS];

        static void Main(string[] args)
        {
            //  Let user input 5 first names,
            //  5 last names, 5 grades
            inputInfo();

            //  Verify that 5 first names,
            //  5 last names, 5 grades were
            //  indeed inputted
            verifyInfo();

            //  Lookup student based on
            //  either first name or last name
            tableLookup();
        }

        static void inputInfo()
        {
            for (int lcv = 0; lcv < firstName.Length; ++lcv)
            {
                Write("\n\nEnter First Name Of Student " +
                     (lcv + 1) + ": ");
                firstName[lcv] = ReadLine();

                Write("Enter  Last Name Of Student " +
                     (lcv + 1) + ": ");
                lastName[lcv] = ReadLine();

                Write("Enter  The Grade For Student " +
                     (lcv + 1) + ": ");
                studGrades[lcv] = Convert.ToInt32(ReadLine());

            }

            WriteLine("\n\nHit <enter> to continue");
            ReadLine();
        }

        static void verifyInfo()
        {
            Clear();
            WriteLine("This is the student info:\n");

            for (int lcv = 0; lcv < firstName.Length; ++lcv)
            {
                Write("\n\nStudent " +
                     (lcv + 1) + " first name: " +
                     firstName[lcv]);
                Write("\nStudent " +
                     (lcv + 1) + " last name: " +
                     lastName[lcv]);
                Write("\nStudent " +
                     (lcv + 1) + " grade: " +
                     studGrades[lcv]);
            }

            WriteLine("\n\nHit <enter> to continue");
            ReadLine();
        }

        static void tableLookup()
        {
            bool found;
            string name;
            string status;

            Clear();

            found = false;

            Write("Enter Name To Search For: ");
            name = ReadLine();

            for (int lcv = 0; lcv < NUMSTUDENTS; ++lcv)
            {
                if (name.ToUpper().Equals(firstName[lcv].ToUpper()))
                {
                    found = true;
                    break;
                }
                else if (name.ToUpper().Equals(lastName[lcv].ToUpper()))
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                status = THERE;
            }
            else
            {
                status = NOTTHERE;
            }

            WriteLine("The name: " + name + " " + status);

            ReadLine();
        }
    }
}
