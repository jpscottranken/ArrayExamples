using System;
using static System.Console;

/*
 *      In this program:
 *      
 *      1.  Fill the integer array numbers with 25 random
 *          numbers. Each number is between 1 - 100.
 *      
 *      2.  Next, print out the array in its original order.
 *      
 *      3.  Next, sort the array and print out the array
 *          that has been sorted in ascending order.
 *      
 *      4.  Print out the smallest array element.
 *      
 *      5.  Next, reverse the array and print out the array
 *          that has been sorted in descending order.
 *      
 *      6.  Print out the largest array element.
 *      
 *      7.  Add all array elements and print out the sum.
 *      
 *      8.  Average all array elements and prnt out the average.
 */
namespace RandomConsole
{
    class Program
    {
        //  Global constant
        const int MAX = 25;                 //  Number of array elements

        //  Global variable
        static int[] numbers = new int[MAX];       //  Numbers array

        static void Main(string[] args)
        {   //  Begin main
            fillArray();

            printOutArrayInOriginalOrder();

            sortArrayAndPrintOUt();

            displaySmallestArrayElement(numbers[0]);

            reverseArrayAndPrintOUt();

            displayLargestArrayElement(numbers[0]);

            calculateAndDisplaySumOfArrayElements();
        }   //  End   main

        //  Fills the numbers array with 25 random numbers (1 - 100)
        static void fillArray()
        {
            Random r = new Random();

            //  Fill array with 100 random #s between 1 - 100
            for (int lcv = 0; lcv < numbers.Length; ++lcv)
            {
                numbers[lcv] = r.Next(1, 100);
            }
        }

        //  Prints out the numbers array in its original order
        static void printOutArrayInOriginalOrder()
        {
            string outputStr = "The array in original order:\n";

            for (int lcv = 0; lcv < numbers.Length; ++lcv)
            {
                outputStr += numbers[lcv] + " ";
            }

            WriteLine(outputStr);
        }

        //  Sorts the numbers array in ascending order and then
        //  Prints out the numbers array in its ascending order
        static void sortArrayAndPrintOUt()
        {
            string outputStr = "\nThe array in ascending order:\n";

            Array.Sort(numbers);

            for (int lcv = 0; lcv < numbers.Length; ++lcv)
            {
                outputStr += numbers[lcv] + " ";
            }

            WriteLine(outputStr);
        }

        //  Display the value of the smallest array element
        static void displaySmallestArrayElement(int smallest)
        {
            WriteLine("\nThe value of the smallest element is: " +
                      smallest.ToString());
        }

        //  Reverse the current array ascending array order,
        //  making the numbers array in descending order.
        //  Then print it out.
        static void reverseArrayAndPrintOUt()
        {
            string outputStr = "\nThe array in descending order:\n";

            Array.Sort(numbers);
            Array.Reverse(numbers);

            for (int lcv = 0; lcv < numbers.Length; ++lcv)
            {
                outputStr += numbers[lcv] + " ";
            }

            WriteLine(outputStr);
        }

        //  Print out value of largest array element
        static void displayLargestArrayElement(int largest)
        {
            WriteLine("\nThe value of the largest element is: " +
                      largest.ToString());
        }

        //  This routine sums all array elements and 
        //  prints out that sum.
        static void calculateAndDisplaySumOfArrayElements()
        {
            int sum = 0;

            for (int lcv = 0; lcv < numbers.Length; ++lcv)
            {
                sum += numbers[lcv];
            }

            WriteLine("\nThe sum of all 25 array elements: " +
            sum.ToString());

            calculateArrayAverageAndDisplay(sum);
        }

        //  This routine averages all array elements and 
        //  prints out that average.
        static void calculateArrayAverageAndDisplay(int sum)
        {
            decimal avg = (decimal)sum / numbers.Length;

            WriteLine("\nThe avg of all 25 array elements: " +
            avg.ToString());

            ReadLine();
        }
    }
}
