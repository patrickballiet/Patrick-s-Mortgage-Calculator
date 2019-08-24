namespace Patrick_s_Loan_Calculator
{
    partial class LoanCalculator
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
            this.btnLoanCalculator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmountOfLoan = new System.Windows.Forms.TextBox();
            this.txtNumberOfYears = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtfReceipt = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnResetCalculator = new System.Windows.Forms.Button();
            this.btnExitCalculator = new System.Windows.Forms.Button();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorEmptyInfo = new System.Windows.Forms.Label();
            this.lblAmountOfLoan = new System.Windows.Forms.Label();
            this.lblNumberOfYears = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.errorFormat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoanCalculator
            // 
            this.btnLoanCalculator.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLoanCalculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoanCalculator.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnLoanCalculator.FlatAppearance.BorderSize = 5;
            this.btnLoanCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoanCalculator.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanCalculator.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoanCalculator.Location = new System.Drawing.Point(48, 250);
            this.btnLoanCalculator.Name = "btnLoanCalculator";
            this.btnLoanCalculator.Size = new System.Drawing.Size(160, 36);
            this.btnLoanCalculator.TabIndex = 0;
            this.btnLoanCalculator.Text = "Calculate Payments";
            this.btnLoanCalculator.UseVisualStyleBackColor = false;
            this.btnLoanCalculator.Click += new System.EventHandler(this.BtnLoanCalculator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mortgage Principal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Years:";
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Annual Interest Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monthly Payment :";
            // 
            // txtAmountOfLoan
            // 
            this.txtAmountOfLoan.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountOfLoan.Location = new System.Drawing.Point(240, 134);
            this.txtAmountOfLoan.Name = "txtAmountOfLoan";
            this.txtAmountOfLoan.Size = new System.Drawing.Size(140, 30);
            this.txtAmountOfLoan.TabIndex = 8;
            this.txtAmountOfLoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAmountOfLoan_KeyPress);
            // 
            // txtNumberOfYears
            // 
            this.txtNumberOfYears.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfYears.Location = new System.Drawing.Point(240, 169);
            this.txtNumberOfYears.Name = "txtNumberOfYears";
            this.txtNumberOfYears.Size = new System.Drawing.Size(140, 30);
            this.txtNumberOfYears.TabIndex = 9;
            this.txtNumberOfYears.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            this.txtNumberOfYears.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumberOfYears_KeyPress);
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterestRate.Location = new System.Drawing.Point(240, 205);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(140, 30);
            this.txtInterestRate.TabIndex = 10;
            this.txtInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInterestRate_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total cost of mortgage:";
            // 
            // rtfReceipt
            // 
            this.rtfReceipt.Enabled = false;
            this.rtfReceipt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfReceipt.Location = new System.Drawing.Point(552, 131);
            this.rtfReceipt.Name = "rtfReceipt";
            this.rtfReceipt.Size = new System.Drawing.Size(623, 330);
            this.rtfReceipt.TabIndex = 16;
            this.rtfReceipt.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(400, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "PATRICK\'S MORTGAGE CALCULATOR\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResetCalculator
            // 
            this.btnResetCalculator.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnResetCalculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetCalculator.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetCalculator.Location = new System.Drawing.Point(50, 431);
            this.btnResetCalculator.Name = "btnResetCalculator";
            this.btnResetCalculator.Size = new System.Drawing.Size(138, 33);
            this.btnResetCalculator.TabIndex = 19;
            this.btnResetCalculator.Text = "Reset Calculator";
            this.btnResetCalculator.UseVisualStyleBackColor = false;
            this.btnResetCalculator.Click += new System.EventHandler(this.BtnResetCalculator_Click);
            // 
            // btnExitCalculator
            // 
            this.btnExitCalculator.BackColor = System.Drawing.Color.Red;
            this.btnExitCalculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitCalculator.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitCalculator.Location = new System.Drawing.Point(203, 431);
            this.btnExitCalculator.Name = "btnExitCalculator";
            this.btnExitCalculator.Size = new System.Drawing.Size(123, 33);
            this.btnExitCalculator.TabIndex = 20;
            this.btnExitCalculator.Text = "Exit Calculator";
            this.btnExitCalculator.UseVisualStyleBackColor = false;
            this.btnExitCalculator.Click += new System.EventHandler(this.BtnExitCalculator_Click);
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.BackColor = System.Drawing.Color.Black;
            this.lblMonthlyPayment.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyPayment.ForeColor = System.Drawing.Color.Transparent;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(240, 339);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(140, 20);
            this.lblMonthlyPayment.TabIndex = 21;
            this.lblMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.BackColor = System.Drawing.Color.Black;
            this.lblTotalPayment.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayment.ForeColor = System.Drawing.Color.Transparent;
            this.lblTotalPayment.Location = new System.Drawing.Point(240, 380);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(140, 20);
            this.lblTotalPayment.TabIndex = 22;
            this.lblTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(363, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "-----------------------------------------------------------";
            // 
            // errorEmptyInfo
            // 
            this.errorEmptyInfo.AutoSize = true;
            this.errorEmptyInfo.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorEmptyInfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.errorEmptyInfo.Location = new System.Drawing.Point(44, 98);
            this.errorEmptyInfo.Name = "errorEmptyInfo";
            this.errorEmptyInfo.Size = new System.Drawing.Size(336, 15);
            this.errorEmptyInfo.TabIndex = 24;
            this.errorEmptyInfo.Text = "Please make sure to fill out all the different information needed.";
            this.errorEmptyInfo.Visible = false;
            this.errorEmptyInfo.Click += new System.EventHandler(this.ErrorEmptyInfo_Click);
            // 
            // lblAmountOfLoan
            // 
            this.lblAmountOfLoan.BackColor = System.Drawing.Color.Black;
            this.lblAmountOfLoan.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOfLoan.ForeColor = System.Drawing.Color.Transparent;
            this.lblAmountOfLoan.Location = new System.Drawing.Point(240, 134);
            this.lblAmountOfLoan.Name = "lblAmountOfLoan";
            this.lblAmountOfLoan.Size = new System.Drawing.Size(140, 32);
            this.lblAmountOfLoan.TabIndex = 25;
            this.lblAmountOfLoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAmountOfLoan.Visible = false;
            // 
            // lblNumberOfYears
            // 
            this.lblNumberOfYears.BackColor = System.Drawing.Color.Black;
            this.lblNumberOfYears.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfYears.ForeColor = System.Drawing.Color.Transparent;
            this.lblNumberOfYears.Location = new System.Drawing.Point(240, 166);
            this.lblNumberOfYears.Name = "lblNumberOfYears";
            this.lblNumberOfYears.Size = new System.Drawing.Size(140, 35);
            this.lblNumberOfYears.TabIndex = 26;
            this.lblNumberOfYears.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumberOfYears.Visible = false;
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.BackColor = System.Drawing.Color.Black;
            this.lblInterestRate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestRate.ForeColor = System.Drawing.Color.Transparent;
            this.lblInterestRate.Location = new System.Drawing.Point(240, 201);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(140, 34);
            this.lblInterestRate.TabIndex = 27;
            this.lblInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInterestRate.Visible = false;
            // 
            // errorFormat
            // 
            this.errorFormat.AutoSize = true;
            this.errorFormat.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorFormat.ForeColor = System.Drawing.SystemColors.Desktop;
            this.errorFormat.Location = new System.Drawing.Point(44, 98);
            this.errorFormat.Name = "errorFormat";
            this.errorFormat.Size = new System.Drawing.Size(446, 15);
            this.errorFormat.TabIndex = 28;
            this.errorFormat.Text = "Please make sure to enter correct formats in the fields before running the calcul" +
    "ation.";
            this.errorFormat.Visible = false;
            this.errorFormat.Click += new System.EventHandler(this.ErrorFormat_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(481, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "Using C#/.Net Winform";
            // 
            // LoanCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1217, 541);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.errorFormat);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.lblNumberOfYears);
            this.Controls.Add(this.lblAmountOfLoan);
            this.Controls.Add(this.errorEmptyInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalPayment);
            this.Controls.Add(this.lblMonthlyPayment);
            this.Controls.Add(this.btnExitCalculator);
            this.Controls.Add(this.btnResetCalculator);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtfReceipt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtNumberOfYears);
            this.Controls.Add(this.txtAmountOfLoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoanCalculator);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1233, 580);
            this.MinimumSize = new System.Drawing.Size(1233, 580);
            this.Name = "LoanCalculator";
            this.Text = "Patrick\'s Loan Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoanCalculator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmountOfLoan;
        private System.Windows.Forms.TextBox txtNumberOfYears;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtfReceipt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnResetCalculator;
        private System.Windows.Forms.Button btnExitCalculator;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label errorEmptyInfo;
        private System.Windows.Forms.Label lblAmountOfLoan;
        private System.Windows.Forms.Label lblNumberOfYears;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label errorFormat;
        private System.Windows.Forms.Label label8;
    }
}

