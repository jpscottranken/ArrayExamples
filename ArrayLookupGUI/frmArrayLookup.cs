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
        string searchStr;
        string gradeStr;
        bool found;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            performTheSearch();
        }

        private void performTheSearch()
        {
            int searchVal = cboArrayToSearch.SelectedIndex;

            switch (searchVal)
            {
                case -1:                //  Combo Box empty
                case 0:                 //  Combo Box Select Array
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
                    displayResults(found, gradeStr.ToString());
                    break;

                default:
                    showMessage("You Must Enter An Array To Search",
                                "NO ARRAY NAME CHOSEN!");
                    break;
            }
        }

        private bool stringSearch(string[] s)
        {
            bool retVal = false;

            searchStr = txtSearchValue.Text;

            if (searchStr == "")
            {
                showMessage("You Must Enter A Value To Search For",
                            "NO SEARCH VALUE INPUTTED!");
                txtSearchValue.Focus();
                return retVal;
            }

            for (int lcv = 0; lcv < firstNames.Length; ++lcv)
            {

                if (searchStr.ToUpper().Equals(firstNames[lcv].ToUpper()))
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

            gradeStr = txtSearchValue.Text;
            int gradeInt = Convert.ToInt32(gradeStr);

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

        private void showMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
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

        private void frmArrayLookup_Load(object sender, EventArgs e)
        {
            cboArrayToSearch.SelectedIndex = 0;
        }
    }
}
