using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace RandomGUI
{
    public partial class frmRandomNumbers : Form
    {
        public frmRandomNumbers()
        {
            InitializeComponent();
        }

        //  Program constants
        const int LEN = 25;             //  Size of the array

        //  Global program variables
        int[] original = new int[LEN];  //  Array in original order
        int[] modified = new int[LEN];  //  Array in modified order
        int theSum = 0;             //  Sum of all array elements
        double theAvg = 0.0;           //  sum / 25

        private void btnNewNumbers_Click(object sender, EventArgs e)
        {
            createNewNumbers();
        }

        //  This routine creates 25 new numbers for the arrays/listbox.
        private void createNewNumbers()
        {
            //  "Seeding" the rand
            Random r = new Random();

            clearListBox();

            //  Fill up both arrays with the same 25
            //  random numbers between 1 - 100
            for (int lcv = 0; lcv < original.Length; ++lcv)
            {
                //  Fill up each array
                original[lcv] = r.Next(1, 100);
                modified[lcv] = original[lcv];

                //  Copy current array values to ListBox
                lstNumbersArray.Items.Add(original[lcv]);
            }
        }

        //  This routine clears the listbox
        private void btnClearListBox_Click(object sender, EventArgs e)
        {
            clearListBox();
        }

        //  This routine clears the listbox
        private void clearListBox()
        {
            lstNumbersArray.Items.Clear();
        }

        private void btnSortAscending_Click(object sender, EventArgs e)
        {
            sortAscending();
        }

        //  This routine sorts the array in ascending order
        //  and then fills up the listbox with its contents
        private void sortAscending()
        {
            Array.Sort(modified);

            clearListBox();
            for (int lcv = 0; lcv < modified.Length; ++lcv)
            {
                //  Copy current array values to ListBox
                lstNumbersArray.Items.Add(modified[lcv]);
            }
        }

        private void btnSortDescending_Click(object sender, EventArgs e)
        {
            sortDescending();
        }

        //  This routine sorts the array in descending order
        //  and then fills up the listbox with its contents
        private void sortDescending()
        {
            Array.Sort(modified);
            Array.Reverse(modified);

            clearListBox();
            for (int lcv = 0; lcv < modified.Length; ++lcv)
            {
                //  Copy current array values to ListBox
                lstNumbersArray.Items.Add(modified[lcv]);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            doTheSearch();
        }

        private void doTheSearch()
        {
            sortAscending();

            //  InputBox Message
            string value = Interaction.InputBox(
                            "Number To Search For",
                            "SEARCH", "50", 770, 455);

            int theValue = Convert.ToInt32(value);

            int result = Array.BinarySearch(modified, theValue);

            if (result < 0)
            {
                //  The value being search for not in array
                MessageBox.Show("The value " + theValue.ToString() +
                                " WAS NOT FOUND in the array",
                                "ELEMENT NOT FOUND",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                //  The value being search for was in array
                MessageBox.Show("The value " + theValue.ToString() +
                                " WAS FOUND in the array",
                                "ELEMENT FOUND",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit The Program?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            sumElements(true);
        }

        private void sumElements(bool value)
        {
            theSum = 0;

            for (int lcv = 0; lcv < modified.Length; ++lcv)
            {
                theSum += modified[lcv];
            }

            if (value)
            {
                MessageBox.Show("The sum of all array elements: " +
                                theSum.ToString(),
                                "SUM OF ALL 25 ARRAY ELEMENTS",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            avgElements();
        }

        private void avgElements()
        {
            sumElements(false);

            theAvg = (double) theSum / modified.Length;

            MessageBox.Show("The average of all array elements: " +
                theAvg.ToString(),
                "AVERAGE OF ALL 25 ARRAY ELEMENTS",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnSmallest_Click(object sender, EventArgs e)
        {
            displaySmallestArrayElementValue();
        }

        public void displaySmallestArrayElementValue()
        {
            Array.Sort(modified);
            MessageBox.Show("The smallest array element value: " +
                modified[0].ToString(),
                "SMALLEST ARRAY ELEMENT VALUE",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void btnLargest_Click(object sender, EventArgs e)
        {
            displayLargestArrayElementValue();
        }

        public void displayLargestArrayElementValue()
        {
            Array.Sort(modified);
            Array.Reverse(modified);
            MessageBox.Show("The largest array element value: " +
                modified[0].ToString(),
                "LARGEST ARRAY ELEMENT VALUE",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnMedian_Click(object sender, EventArgs e)
        {
            findTheMedian();
        }

        private void findTheMedian()
        {
            sortAscending();

            int median = LEN / 2;

            MessageBox.Show("The median array element value: " +
                modified[median].ToString(),
                "MEDIAN ARRAY ELEMENT VALUE",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnRange_Click(object sender, EventArgs e)
        {
            findTheRange();
        }

        private void findTheRange()
        {
            sortAscending();
            int theSmallest = modified[0];

            sortDescending();
            int theLargest = modified[0];

            int theRange = theLargest - theSmallest;

            MessageBox.Show("The range of array elements: " +
            theRange.ToString(),
            "RANGE OF ARRAY ELEMENTS",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }


        private void frmRandomNumbers_Load(object sender, EventArgs e)
        {
            createNewNumbers();
        }

    }
}
