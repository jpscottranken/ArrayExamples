using System;
using System.Windows.Forms;

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


namespace GradesGUI
{
    public partial class frmGradesArray : Form
    {
        public frmGradesArray()
        {
            InitializeComponent();
        }

        //  Global Constants
        const int MINGRADE =   0;
        const int MAXGRADE = 100;
        const int NUMSTUDS =  10;

        //  Global variables
        int[] grades  = new int[NUMSTUDS];
        int totalAs   =   0;
        int totalBs   =   0;
        int totalCs   =   0;
        int totalDs   =   0;
        int totalFs   = 0;
        int highest   =  -1;
        int lowest    = 101;
        decimal avg   =   0.0m;
        int sumGrades =   0;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            for (int lcv = 0; lcv < grades.Length; ++lcv)
            {   //  Begin for
                validateCurrentArrayElement(lcv);

                //  Set array element
                grades[lcv] = Convert.ToInt32(txtNumberGrade.Text);

                calculateLetterGrade(lcv);

                //  Check for possible new high grade
                if (grades[lcv] > highest)
                {
                    highest = grades[lcv];
                }

                //  Check for possible new low grade
                if (grades[lcv] < lowest)
                {
                    lowest = grades[lcv];
                }

                //  Add grades to grade total counter
                sumGrades += grades[lcv];
             }       //  End   for

            txtNumberGrade.Enabled = false;
            txtLetterGrade.Enabled = false;

            enableButtons();
        }

        private void validateCurrentArrayElement(int lcv)
        {
            //  Call method to verify that 
            //  value in textbox 1 is not empty.
            bool keepGoing = IsPresent(txtNumberGrade);

            if (keepGoing)
            {
                //  Something was entered into textbox 1
                //  Verify that what was entered is numeric.
                keepGoing = IsInt32(txtNumberGrade);
            }
            else
            {
                //  Nothing entered into textbox
                txtNumberGrade.Text = "";
                txtNumberGrade.Focus();
                validateCurrentArrayElement(lcv);
            }

            if (keepGoing)
            {
                //  If true, we entered an integer
                keepGoing = IsWithinRange(txtNumberGrade,
                                          MINGRADE, MAXGRADE);
            }
            else
            {
                //  Non-Numeric value entered into textbox
                txtNumberGrade.Text = "";
                txtNumberGrade.Focus();
                validateCurrentArrayElement(lcv);
            }
        }
        private void calculateLetterGrade(int lcv)
        {
            //MessageBox.Show("In calculateLetterGrade" +
            //                "\nlcv passed in was:  " + lcv.ToString(),
            //                "IN CALCULATELETTERGRADE()");
            string lg = "";

            if (grades[lcv] >= 90)
            {
                lg = "A";
                ++totalAs;
            }
            else if (grades[lcv] >= 80)
            {
                lg = "B";
                ++totalBs;
            }
            else if (grades[lcv] >= 70)
            {
                lg = "C";
                ++totalCs;
            }
            else if (grades[lcv] >= 60)
            {
                lg = "D";
                ++totalDs;
            }
            else if (grades[lcv] >= 0)
            {
                lg = "F";
                ++totalFs;
            }

            txtLetterGrade.Text = lg;
        }

        //  This method runs when the Clear button is clicked
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAndSetFocus();
        }

        //  This method clears both textboxes
        //  and sets the focus to textbox 1.
        private void clearAndSetFocus()
        {
            txtNumberGrade.Text = "";
            txtLetterGrade.Text = "";
            txtNumberGrade.Focus();
        }

        //  This method runs when the Exit button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }

        //  This method let the user exit the program if desired
        private void exitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //  This method runs when the form loads into memory
        private void frmGradesArray_Load(object sender, EventArgs e)
        {
            disableButtons();
        }

        //  This method disables all buttons
        //  except the Calculate, Exit, and
        //  NewPgm Run buttons
        private void disableButtons()
        {
            btnTotalAs.Enabled = false;
            btnTotalBs.Enabled = false;
            btnTotalCs.Enabled = false;
            btnTotalDs.Enabled = false;
            btnTotalFs.Enabled = false;
            btnHighest.Enabled = false;
            btnLowest.Enabled  = false;
            btnAverage.Enabled = false;
        }
        //  This method enables all buttons
        //  disabled earlier
        private void enableButtons()
        {
            btnTotalAs.Enabled = true;
            btnTotalBs.Enabled = true;
            btnTotalCs.Enabled = true;
            btnTotalDs.Enabled = true;
            btnTotalFs.Enabled = true;
            btnHighest.Enabled = true;
            btnLowest.Enabled  = true;
            btnAverage.Enabled = true;
        }

        //  This method verifies that the value
        //  inputted into the numberGrade textbox
        //  was not left empty, uses Murach method
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.",
                                "NUMBER GRADE TEXTBOX INPUT REQUIRED!");
                textBox.Focus();
                return false;
            }

            return true;
        }

        //  This method verifies that the value
        //  inputted into the numberGrade textbox
        //  is an integer, uses Murach method
        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;

            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }

            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.",
                                "NUMBER GRADE TEXTBOX INPUT MUST BE INTEGER!");
                textBox.Text = "";
                textBox.Focus();
                return false;
            }
        }

        //  This method verifies that the value
        //  inputted into the numberGrade textbox
        //  is between 0 - 100, uses Murach method
        public static bool IsWithinRange(TextBox textBox, 
                                         int min, int max)
        {
            decimal number = Convert.ToInt32(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(textBox.Tag + " must be between " + min
                    + " and " + max + ".",
                    "NUMBER GRADE TEXTBOX INPUT OUT-OF-RANGE!");
                textBox.Text = "";
                textBox.Focus();
                return false;
            }
            return true;
        }

        //  This method runs when the Total A's button is clicked.
        private void btnTotalAs_Click(object sender, EventArgs e)
        {
            displayGradeInfo("A", totalAs);
        }

        //  This method runs when the Total B's button is clicked.
        private void btnTotalBs_Click(object sender, EventArgs e)
        {
            displayGradeInfo("B", totalBs);
        }

        //  This method runs when the Total C's button is clicked.
        private void btnTotalCs_Click(object sender, EventArgs e)
        {
            displayGradeInfo("C", totalCs);
        }

        //  This method runs when the Total D's button is clicked.
        private void btnTotalDs_Click(object sender, EventArgs e)
        {
            displayGradeInfo("D", totalDs);
        }

        //  This method runs when the Total F's button is clicked.
        private void btnTotalFs_Click(object sender, EventArgs e)
        {
            displayGradeInfo("F", totalFs);
        }

        //  This method displays the total number of grades.
        private void displayGradeInfo(string grade, int totalCounter)
        {
            MessageBox.Show("The Total Number of " + grade + "s: " +
                            totalCounter.ToString());
        }

        //  This method displays the highest test grade.
        private void btnHighest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Highest Grade: " + highest.ToString());
        }

        //  This method displays the lowest test grade.
        private void btnLowest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Highest Grade: " + lowest.ToString());
        }

        //  This method displays the average test grade.
        private void btnAverage_Click(object sender, EventArgs e)
        {
            avg = sumGrades / 10.0m;

            MessageBox.Show("Average Grade: " + avg.ToString("n2"));
        }

        //  This method allows a new program run to take place.
        private void btnNewProgramRun_Click(object sender, EventArgs e)
        {
            disableButtons();
            clearCounters();
            clearAndSetFocus();
        }

        //  This method clears all global variables.
        private void clearCounters()
        {
            totalAs = 0;
            totalBs = 0;
            totalCs = 0;
            totalDs = 0;
            totalFs = 0;

            highest = -1;
            lowest  = 101;
            avg     = 0.0m;

            grades  = null;
        }
    }
}
