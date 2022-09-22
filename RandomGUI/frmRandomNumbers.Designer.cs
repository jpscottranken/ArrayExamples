
namespace RandomGUI
{
    partial class frmRandomNumbers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstNumbersArray = new System.Windows.Forms.ListBox();
            this.btnNewNumbers = new System.Windows.Forms.Button();
            this.btnSortAscending = new System.Windows.Forms.Button();
            this.btnClearListBox = new System.Windows.Forms.Button();
            this.btnSortDescending = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMedian = new System.Windows.Forms.Button();
            this.btnRange = new System.Windows.Forms.Button();
            this.btnLargest = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnSmallest = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNumbersArray
            // 
            this.lstNumbersArray.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNumbersArray.FormattingEnabled = true;
            this.lstNumbersArray.ItemHeight = 31;
            this.lstNumbersArray.Location = new System.Drawing.Point(46, 24);
            this.lstNumbersArray.Name = "lstNumbersArray";
            this.lstNumbersArray.Size = new System.Drawing.Size(87, 779);
            this.lstNumbersArray.TabIndex = 12;
            // 
            // btnNewNumbers
            // 
            this.btnNewNumbers.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewNumbers.Location = new System.Drawing.Point(183, 39);
            this.btnNewNumbers.Name = "btnNewNumbers";
            this.btnNewNumbers.Size = new System.Drawing.Size(212, 58);
            this.btnNewNumbers.TabIndex = 0;
            this.btnNewNumbers.Text = "New Numbers";
            this.btnNewNumbers.UseVisualStyleBackColor = true;
            this.btnNewNumbers.Click += new System.EventHandler(this.btnNewNumbers_Click);
            // 
            // btnSortAscending
            // 
            this.btnSortAscending.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortAscending.Location = new System.Drawing.Point(183, 318);
            this.btnSortAscending.Name = "btnSortAscending";
            this.btnSortAscending.Size = new System.Drawing.Size(212, 58);
            this.btnSortAscending.TabIndex = 4;
            this.btnSortAscending.Text = "Sort Ascending";
            this.btnSortAscending.UseVisualStyleBackColor = true;
            this.btnSortAscending.Click += new System.EventHandler(this.btnSortAscending_Click);
            // 
            // btnClearListBox
            // 
            this.btnClearListBox.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearListBox.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearListBox.Location = new System.Drawing.Point(183, 182);
            this.btnClearListBox.Name = "btnClearListBox";
            this.btnClearListBox.Size = new System.Drawing.Size(212, 58);
            this.btnClearListBox.TabIndex = 2;
            this.btnClearListBox.Text = "Clear ListBox";
            this.btnClearListBox.UseVisualStyleBackColor = true;
            this.btnClearListBox.Click += new System.EventHandler(this.btnClearListBox_Click);
            // 
            // btnSortDescending
            // 
            this.btnSortDescending.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortDescending.Location = new System.Drawing.Point(183, 455);
            this.btnSortDescending.Name = "btnSortDescending";
            this.btnSortDescending.Size = new System.Drawing.Size(212, 58);
            this.btnSortDescending.TabIndex = 6;
            this.btnSortDescending.Text = "Sort Descending";
            this.btnSortDescending.UseVisualStyleBackColor = true;
            this.btnSortDescending.Click += new System.EventHandler(this.btnSortDescending_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(183, 729);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(212, 58);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(183, 594);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(212, 58);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMedian
            // 
            this.btnMedian.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedian.Location = new System.Drawing.Point(432, 594);
            this.btnMedian.Name = "btnMedian";
            this.btnMedian.Size = new System.Drawing.Size(212, 58);
            this.btnMedian.TabIndex = 9;
            this.btnMedian.Text = "Median";
            this.btnMedian.UseVisualStyleBackColor = true;
            this.btnMedian.Click += new System.EventHandler(this.btnMedian_Click);
            // 
            // btnRange
            // 
            this.btnRange.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRange.Location = new System.Drawing.Point(432, 729);
            this.btnRange.Name = "btnRange";
            this.btnRange.Size = new System.Drawing.Size(212, 58);
            this.btnRange.TabIndex = 11;
            this.btnRange.Text = "Range";
            this.btnRange.UseVisualStyleBackColor = true;
            this.btnRange.Click += new System.EventHandler(this.btnRange_Click);
            // 
            // btnLargest
            // 
            this.btnLargest.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLargest.Location = new System.Drawing.Point(432, 455);
            this.btnLargest.Name = "btnLargest";
            this.btnLargest.Size = new System.Drawing.Size(212, 58);
            this.btnLargest.TabIndex = 7;
            this.btnLargest.Text = "Largest";
            this.btnLargest.UseVisualStyleBackColor = true;
            this.btnLargest.Click += new System.EventHandler(this.btnLargest_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAverage.Location = new System.Drawing.Point(432, 182);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(212, 58);
            this.btnAverage.TabIndex = 3;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnSmallest
            // 
            this.btnSmallest.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmallest.Location = new System.Drawing.Point(432, 318);
            this.btnSmallest.Name = "btnSmallest";
            this.btnSmallest.Size = new System.Drawing.Size(212, 58);
            this.btnSmallest.TabIndex = 5;
            this.btnSmallest.Text = "Smallest";
            this.btnSmallest.UseVisualStyleBackColor = true;
            this.btnSmallest.Click += new System.EventHandler(this.btnSmallest_Click);
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(432, 39);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(212, 58);
            this.btnSum.TabIndex = 1;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // frmRandomNumbers
            // 
            this.AcceptButton = this.btnNewNumbers;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClearListBox;
            this.ClientSize = new System.Drawing.Size(684, 815);
            this.Controls.Add(this.btnMedian);
            this.Controls.Add(this.btnRange);
            this.Controls.Add(this.btnLargest);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnSmallest);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSortDescending);
            this.Controls.Add(this.btnClearListBox);
            this.Controls.Add(this.btnSortAscending);
            this.Controls.Add(this.btnNewNumbers);
            this.Controls.Add(this.lstNumbersArray);
            this.Name = "frmRandomNumbers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# Array Program with Random Numbers";
            this.Load += new System.EventHandler(this.frmRandomNumbers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumbersArray;
        private System.Windows.Forms.Button btnNewNumbers;
        private System.Windows.Forms.Button btnSortAscending;
        private System.Windows.Forms.Button btnClearListBox;
        private System.Windows.Forms.Button btnSortDescending;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMedian;
        private System.Windows.Forms.Button btnRange;
        private System.Windows.Forms.Button btnLargest;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnSmallest;
        private System.Windows.Forms.Button btnSum;
    }
}

