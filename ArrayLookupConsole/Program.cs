using System;
using static System.Console;

/*
 *      This is a fairly simple array lookup
 *      program. 
 *      
 *      There will be 3 parallel arrays:
 *      
 *      -   One for first name. 
 *      -   One for last name. 
 *      -   One for grades.
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
        const string THERE    = " WAS FOUND";
        const string NOTTHERE = " WAS NOT FOUND";


        //  Global variables
        static string[] firstName = new string[NUMSTUDENTS];
        static string[] lastName  = new string[NUMSTUDENTS];
        static int[] stuGrades    = new int[NUMSTUDENTS];

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

        //  Input 5 students first names,
        //  last names, and grades (grade not used)
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
                stuGrades[lcv] = Convert.ToInt32(ReadLine());

            }

            WriteLine("\n\nHit <enter> to continue");
            ReadLine();
        }

        //  Display 5 students first names,
        //  last names, and grades
        static void verifyInfo()
        {
            Clear();
            WriteLine("This is the student info:\n");

            for (int lcv = 0; lcv < firstName.Length; ++lcv)
            {
                Write("Student " +
                     (lcv + 1) + " first name: " +
                     firstName[lcv]);
                Write("\nStudent " +
                     (lcv + 1) + " last name: " +
                     lastName[lcv]);
                Write("\nStudent " +
                     (lcv + 1) + " grade: " +
                     stuGrades[lcv] + "\n\n");
            }

            WriteLine("\n\nHit <enter> to continue");
            ReadLine();
        }

        //  Do a "table" lookup based on
        //  either student first name or
        //  student last name
        static void tableLookup()
        {
            bool found;         //  If true there was a match
            string name;        //  Name to search for
            string status;      //  Name found or name not found

            Clear();

            found = false;      //  Assuming name not in table

            Write("Enter Name To Search For: ");
            name = ReadLine();

            //  Looping through each array
            //  If the name is found, set the
            //  found flag to true.
            //
            //  Then, break out of loop
            for (int lcv = 0; lcv < NUMSTUDENTS; ++lcv)
            {
                if (name.ToUpper().Equals(firstName[lcv].ToUpper()))
                {
                    //  name found in firstNames array
                    found = true;
                    break;
                }
                else if (name.ToUpper().Equals(lastName[lcv].ToUpper()))
                {
                    //  name found in lastNames array
                    found = true;
                    break;
                }
            }

            if (found)
            {
                status = THERE;     //  Add WAS FOUND constant
            }
            else
            {
                status = NOTTHERE;  //  Add WAS NOT FOUND constant
            }

            WriteLine("The name: " + name + " " + status);

            ReadLine();
        }
    }
}
