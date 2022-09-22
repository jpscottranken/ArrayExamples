using System;
using System.Windows.Forms;

namespace ArrayLookupGUI
{
    public partial class frmArrayLookup : Form
    {
        public frmArrayLookup()
        {
            InitializeComponent();
        }

        //  Program constants
        const int MINGRADE  = 0;
        const int MAXGRADE  = 100;
        const string WAS    = " WAS FOUND ";
        const string WASNOT = " WAS NOT FOUND ";

        //  Global arrays
        string[] firstNames = { "Jeff", "Mary", "Bob", "Kate", "Ken" };
        string[] lastNames  = { "West", "King", "Post", "Clark", "Rose" };
        int[] grades        = { 91, 88, 100, 71, 60 };

        //  Global variables
        string searchStr;   //  Used for fn & ln search
        string gradeStr;    //  Used for a grade search
        bool found;         //  Value found/not found

        private void btnSearch_Click(object sender, EventArgs e)
        {
            performTheSearch();
        }

        private void performTheSearch()
        {
            int searchVal = cboArrayToSearch.SelectedIndex;

            switch (searchVal)
            {
                case -1:                 //  Combo Box empty
                case  0:                 //  Combo Box Select Array
                    showMessage("You Must Enter An Array To Search",
                                "NO ARRAY NAME CHOSEN!");
                    cboArrayToSearch.Focus();
                    break;

                case 1:                 //  Combo Box First Name
                    found = stringSearch(firstNames);
                    displayResults(found, searchStr);
                    break;

                case 2:                 //  Combo Box Last  Name
                    found = stringSearch(lastNames);
                    displayResults(found, searchStr);
                    break;

                case 3:                 //  Combo Box Grades
                    found = gradeSearch(grades);
                    displayResults(found, gradeStr);
                    break;

                default:
                    showMessage("Bad Option",
                                "THIS SHOULD NEVER BE HIT!");
                    break;
            }
        }

        //  This function handles firstName array
        //  and lastname array searches
        private bool stringSearch(string[] s)
        {
            bool retVal = false;

            searchStr = txtSearchValue.Text;

            //  Check for blank search value input
            if (searchStr == "")
            {
                showMessage("You Must Enter A Value To Search For",
                            "NO SEARCH VALUE INPUTTED!");
                txtSearchValue.Focus();
                return retVal;
            }

            //  Loop through the array (firstNames or lastNames)
            //  If a match is found, set retVal to true and
            //  break out of loop.
            //
            //  If the entire array has been searched, and
            //  no match was found, 'keep" retVal false
            //  (initial value).
            //
            //  Finally, return retVal
            for (int lcv = 0; lcv < firstNames.Length; ++lcv)
            {

                if (searchStr.ToUpper().Equals(s[lcv].ToUpper()))
                {
                    retVal = true;
                    break;
                }
            }

            return retVal;
        }

        private bool gradeSearch(int[] g)
        {
            bool retVal = false;

            //  Set gradeStr to value in textbox
            gradeStr = txtSearchValue.Text;

            //  Convert gradeStr to an int
            int gradeInt = Convert.ToInt32(gradeStr);

            //  Make range chaeck
            //
            //  If grade inputted out-of-range
            //  (< 0 or > 100), print out error
            //  message, clear out textbox, set
            //  focus to textbox and return retVal.
            if ((gradeInt < MINGRADE) ||
                (gradeInt > MAXGRADE))
            {
                showMessage("You Must Enter A Grade Between " +
                            MINGRADE + " and " + MAXGRADE + "!!!",
                            "OUT-OF-RANGE GRADE INPUTTED!");
                txtSearchValue.Text = "";
                txtSearchValue.Focus();
                return retVal;
            }

            //  Loop through the array (grades)
            //  If a match is found, set retVal to true and
            //  break out of loop.
            //
            //  If the entire array has been searched, and
            //  no match was found, 'keep" retVal false
            //  (initial value).
            //
            //  Finally, return retVal
            for (int lcv = 0; lcv < grades.Length; ++lcv)
            {

                if (gradeStr.ToUpper().Equals(grades[lcv].ToString().ToUpper()))
                {
                    retVal = true;
                    break;
                }
            }

            return retVal;
        }

        //  Display the results as:
        //  whatever name WAS FOUND
        //  whatever name WAS NOT FOUND
        //  whatever grade WAS FOUND
        //  whatever grade WAS NOT FOUND
        public void displayResults(bool found, string str)
        {
            string res = (found) ? WAS : WASNOT;

            lblResults.Text = "The value " + str +
                              res + " in the array";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAndSetFocus();
        }

        private void clearAndSetFocus()
        {
            cboArrayToSearch.SelectedIndex = 0;
            txtSearchValue.Text = "";
            lblResults.Text     = "";
            cboArrayToSearch.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }

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

        //  Assure that combo box it is set to
        //  select array when program run begins.
        private void frmArrayLookup_Load(object sender, EventArgs e)
        {
            cboArrayToSearch.SelectedIndex = 0;
        }

        private void showMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
