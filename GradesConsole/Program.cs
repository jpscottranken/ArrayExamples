using System;
using static System.Console;

/*
 *	We will make this progrm as both first 
 *	a C# console app (GradesConsole) and
 *	then as a C# GUI app (GradesGUI).
 *	
 *	We will put both of these programs in
 *	a solution that will be called ArrayExamples.
 *	
 *	The requirements:
 *	
 *	1.	We have ten students who are taking a test.
 *	    Create an int array called grades size 10
 *	    int[] grades = new int[10];
 *	
 *	2.	The possible grades for the test are 0 - 100.
 *	    const int MINGRADE = 0; const int MAXGRADE = 100;
 *	
 *	3.	Grades cannot be empty (IsPresent()), non-numeric
 *		(IsInt32()), or out-of-range (IsWithinRange()).
 *	
 *	4.	After all grades have been inputted,
 *		determine/output the following:
 *		
 *		The total number of As (90 - 100)
 *		The total number of Bs (80 -  89)
 *		The total number of Cs (70 -  79)
 *		The total number of Ds (60 -  69)
 *		The total number of Fs ( 0 -  59)
 *		The highest test grade
 *		The lowest  test grade
 *		The average test grade (to 2 decimal points)
 */

namespace GradesConsole
{
    internal class Program
    {
        //  Create global constants
        const int MINGRADE = 0;
        const int MAXGRADE = 100;
        const int NUMSTUDS = 10;

        //  Global variable
        static int[] grades = new int[NUMSTUDS];

        static void Main(string[] args)
        {
            inputGrades();
            calculateNumberOfABCDFGrades();
            calculateHighestGrade();
            calculateLowestGrade();
            calculateAverageGrade();

            ReadLine();
        }

        //  This method inputs the 10 grades
        //  For each grade, checks are made to guarantee that:
        //  1.  The grade is not empty.
        //  2.  The grade is numeric.
        //  3.  The grade entered is between 0 - 100
        //  4.  Keep the user in a loop until they
        //      enter a valid grade for each of the
        //      10 grades.
        static void inputGrades()
        {
            bool result = false;        //  Result of Int32.TryParse()

            //  Input the 10 grades
            for (int lcv = 0; lcv < grades.Length; ++lcv)
            {
                result = false;         //  Resetting result variable

                while (!result)         //  while (result == false)
                {
                    Write("\nInput Grade #" + (lcv + 1).ToString() + "\t");

                    //grades[lcv] = Int32.Parse(Console.ReadLine());

                    //  Attempt to convert inputted grade from the
                    //  command line to an integers.
                    //
                    //  If successful: 1) Set result = true.
                    //  2) Put the grade into grades[lcv]
                    result = Int32.TryParse(ReadLine(), out grades[lcv]);

                    //  If result was true, an integer was inputted
                    //  for the current grade. Verify that the
                    //  grade inputted was between 0 - 100.
                    //  In other words between MINGRADE and MAXGRADE.
                    if (result)
                    {
                        //  Range Check
                        if ((grades[lcv] < MINGRADE) ||
                            (grades[lcv] > MAXGRADE))
                        {
                            //  If out of range grade inputted
                            //  set result to false, which will
                            //  force user to input grade again.
                            result = false;
                        }
                        else
                        {
                            //  If result is true, execute a
                            //  break statement to get out of 
                            //  while loop.
                            break;
                        }
                    }
                }
            }
        }

        //  This method calcuates the total number of
        //  A grades (grades 90 - 100), the total number of
        //  B grades (grades 80 -  89), the total number of
        //  C grades (grades 70 -  79), the total number of
        //  D grades (grades 60 -  69), and total number of
        //  F grades (grades  0 -  59).
        //  The value of each counter is then displayed.
        static void calculateNumberOfABCDFGrades()
        {
            int totalAs = 0;
            int totalBs = 0;
            int totalCs = 0;
            int totalDs = 0;
            int totalFs = 0;

            for (int lcv = 0; lcv < NUMSTUDS; ++lcv)
            {
                if (grades[lcv] >= 90)
                {
                    ++totalAs;
                }
                else if (grades[lcv] >= 80)
                {
                    ++totalBs;
                }
                else if (grades[lcv] >= 70)
                {
                    ++totalCs;
                }
                else if (grades[lcv] >= 60)
                {
                    ++totalDs;
                }
                else if (grades[lcv] >= 0)
                {
                    ++totalFs;
                }
            }

            Clear();
            WriteLine("\nTotal # A Grades: " + totalAs.ToString());
            WriteLine("\nTotal # B Grades: " + totalBs.ToString());
            WriteLine("\nTotal # C Grades: " + totalCs.ToString());
            WriteLine("\nTotal # D Grades: " + totalDs.ToString());
            WriteLine("\nTotal # F Grades: " + totalFs.ToString());
        }

        //  This method calcuates the highest grade.
        //  The highest grade is then displayed.
        static void calculateHighestGrade()
        {
            int highestGrade = -1;

            for (int lcv = 0; lcv < NUMSTUDS; ++lcv)
            {
                if (grades[lcv] > highestGrade)
                {
                    highestGrade = grades[lcv];
                }
            }

            WriteLine("\nThe Highest Grade Was: " + highestGrade.ToString());
        }

        //  This method calcuates the lowest grade.
        //  The lowest grade is then displayed.
        static void calculateLowestGrade()
        {
            int lowestGrade = 101;

            for (int lcv = 0; lcv < NUMSTUDS; ++lcv)
            {
                if (grades[lcv] < lowestGrade)
                {
                    lowestGrade = grades[lcv];
                }
            }

            WriteLine("\nThe Lowest Grade Was: " + lowestGrade.ToString());
        }

        //  This method calcuates the average grade.
        //  The average grade is then displayed.
        static void calculateAverageGrade()
        {
            int sum = 0;
            decimal avg = 0m;

            for (int lcv = 0; lcv < NUMSTUDS; ++lcv)
            {
                sum += grades[lcv];
            }

            avg = sum / 10.0m;

            WriteLine("\nThe Average Grade Was: " + avg.ToString("n2"));
        }
    }
}
