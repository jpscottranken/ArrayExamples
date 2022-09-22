namespace GradesGUI
{
    partial class frmGradesArray
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
            this.btnTotalAs = new System.Windows.Forms.Button();
            this.btnTotalBs = new System.Windows.Forms.Button();
            this.btnTotalCs = new System.Windows.Forms.Button();
            this.btnHighest = new System.Windows.Forms.Button();
            this.btnLowest = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTotalDs = new System.Windows.Forms.Button();
            this.btnTotalFs = new System.Windows.Forms.Button();
            this.lblNumberGrade = new System.Windows.Forms.Label();
            this.txtNumberGrade = new System.Windows.Forms.TextBox();
            this.txtLetterGrade = new System.Windows.Forms.TextBox();
            this.lblLetterGrade = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnNewProgramRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTotalAs
            // 
            this.btnTotalAs.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalAs.Location = new System.Drawing.Point(551, 69);
            this.btnTotalAs.Name = "btnTotalAs";
            this.btnTotalAs.Size = new System.Drawing.Size(194, 77);
            this.btnTotalAs.TabIndex = 2;
            this.btnTotalAs.Text = "Total A\'s";
            this.btnTotalAs.UseVisualStyleBackColor = true;
            this.btnTotalAs.Click += new System.EventHandler(this.btnTotalAs_Click);
            // 
            // btnTotalBs
            // 
            this.btnTotalBs.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalBs.Location = new System.Drawing.Point(551, 210);
            this.btnTotalBs.Name = "btnTotalBs";
            this.btnTotalBs.Size = new System.Drawing.Size(194, 77);
            this.btnTotalBs.TabIndex = 3;
            this.btnTotalBs.Text = "Total B\'s";
            this.btnTotalBs.UseVisualStyleBackColor = true;
            this.btnTotalBs.Click += new System.EventHandler(this.btnTotalBs_Click);
            // 
            // btnTotalCs
            // 
            this.btnTotalCs.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalCs.Location = new System.Drawing.Point(551, 350);
            this.btnTotalCs.Name = "btnTotalCs";
            this.btnTotalCs.Size = new System.Drawing.Size(194, 77);
            this.btnTotalCs.TabIndex = 4;
            this.btnTotalCs.Text = "Total C\'s";
            this.btnTotalCs.UseVisualStyleBackColor = true;
            this.btnTotalCs.Click += new System.EventHandler(this.btnTotalCs_Click);
            // 
            // btnHighest
            // 
            this.btnHighest.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighest.Location = new System.Drawing.Point(772, 69);
            this.btnHighest.Name = "btnHighest";
            this.btnHighest.Size = new System.Drawing.Size(194, 77);
            this.btnHighest.TabIndex = 7;
            this.btnHighest.Text = "Highest Grade";
            this.btnHighest.UseVisualStyleBackColor = true;
            this.btnHighest.Click += new System.EventHandler(this.btnHighest_Click);
            // 
            // btnLowest
            // 
            this.btnLowest.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowest.Location = new System.Drawing.Point(772, 210);
            this.btnLowest.Name = "btnLowest";
            this.btnLowest.Size = new System.Drawing.Size(194, 77);
            this.btnLowest.TabIndex = 8;
            this.btnLowest.Text = "Lowest Grade";
            this.btnLowest.UseVisualStyleBackColor = true;
            this.btnLowest.Click += new System.EventHandler(this.btnLowest_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAverage.Location = new System.Drawing.Point(772, 350);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(194, 77);
            this.btnAverage.TabIndex = 9;
            this.btnAverage.Text = "Average Grade";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(772, 492);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(194, 77);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(772, 635);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(194, 77);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTotalDs
            // 
            this.btnTotalDs.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalDs.Location = new System.Drawing.Point(551, 492);
            this.btnTotalDs.Name = "btnTotalDs";
            this.btnTotalDs.Size = new System.Drawing.Size(194, 77);
            this.btnTotalDs.TabIndex = 5;
            this.btnTotalDs.Text = "Total D\'s";
            this.btnTotalDs.UseVisualStyleBackColor = true;
            this.btnTotalDs.Click += new System.EventHandler(this.btnTotalDs_Click);
            // 
            // btnTotalFs
            // 
            this.btnTotalFs.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalFs.Location = new System.Drawing.Point(551, 635);
            this.btnTotalFs.Name = "btnTotalFs";
            this.btnTotalFs.Size = new System.Drawing.Size(194, 77);
            this.btnTotalFs.TabIndex = 6;
            this.btnTotalFs.Text = "Total F\'s";
            this.btnTotalFs.UseVisualStyleBackColor = true;
            this.btnTotalFs.Click += new System.EventHandler(this.btnTotalFs_Click);
            // 
            // lblNumberGrade
            // 
            this.lblNumberGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblNumberGrade.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberGrade.Location = new System.Drawing.Point(108, 210);
            this.lblNumberGrade.Name = "lblNumberGrade";
            this.lblNumberGrade.Size = new System.Drawing.Size(212, 38);
            this.lblNumberGrade.TabIndex = 13;
            this.lblNumberGrade.Text = "Number Grade:";
            this.lblNumberGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumberGrade
            // 
            this.txtNumberGrade.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberGrade.Location = new System.Drawing.Point(341, 210);
            this.txtNumberGrade.Name = "txtNumberGrade";
            this.txtNumberGrade.Size = new System.Drawing.Size(137, 38);
            this.txtNumberGrade.TabIndex = 0;
            this.txtNumberGrade.Tag = "numberGrade";
            this.txtNumberGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLetterGrade
            // 
            this.txtLetterGrade.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetterGrade.Location = new System.Drawing.Point(341, 350);
            this.txtLetterGrade.Name = "txtLetterGrade";
            this.txtLetterGrade.ReadOnly = true;
            this.txtLetterGrade.Size = new System.Drawing.Size(137, 38);
            this.txtLetterGrade.TabIndex = 12;
            this.txtLetterGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLetterGrade
            // 
            this.lblLetterGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblLetterGrade.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetterGrade.Location = new System.Drawing.Point(108, 350);
            this.lblLetterGrade.Name = "lblLetterGrade";
            this.lblLetterGrade.Size = new System.Drawing.Size(212, 38);
            this.lblLetterGrade.TabIndex = 14;
            this.lblLetterGrade.Text = "Letter Grade:";
            this.lblLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(57, 492);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(194, 77);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnNewProgramRun
            // 
            this.btnNewProgramRun.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProgramRun.Location = new System.Drawing.Point(284, 492);
            this.btnNewProgramRun.Name = "btnNewProgramRun";
            this.btnNewProgramRun.Size = new System.Drawing.Size(194, 77);
            this.btnNewProgramRun.TabIndex = 15;
            this.btnNewProgramRun.Text = "New Pgm Run";
            this.btnNewProgramRun.UseVisualStyleBackColor = true;
            this.btnNewProgramRun.Click += new System.EventHandler(this.btnNewProgramRun_Click);
            // 
            // frmGradesArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1094, 748);
            this.Controls.Add(this.btnNewProgramRun);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtLetterGrade);
            this.Controls.Add(this.lblLetterGrade);
            this.Controls.Add(this.txtNumberGrade);
            this.Controls.Add(this.lblNumberGrade);
            this.Controls.Add(this.btnTotalFs);
            this.Controls.Add(this.btnTotalDs);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnLowest);
            this.Controls.Add(this.btnHighest);
            this.Controls.Add(this.btnTotalCs);
            this.Controls.Add(this.btnTotalBs);
            this.Controls.Add(this.btnTotalAs);
            this.Name = "frmGradesArray";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A Program Utilizing an Integer Array";
            this.Load += new System.EventHandler(this.frmGradesArray_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTotalAs;
        private System.Windows.Forms.Button btnTotalBs;
        private System.Windows.Forms.Button btnTotalCs;
        private System.Windows.Forms.Button btnHighest;
        private System.Windows.Forms.Button btnLowest;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTotalDs;
        private System.Windows.Forms.Button btnTotalFs;
        private System.Windows.Forms.Label lblNumberGrade;
        private System.Windows.Forms.TextBox txtNumberGrade;
        private System.Windows.Forms.TextBox txtLetterGrade;
        private System.Windows.Forms.Label lblLetterGrade;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnNewProgramRun;
    }
}

