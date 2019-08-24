using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patrick_s_Loan_Calculator
{
    public partial class LoanCalculator : Form
    {

        double interestRate, monthlyInterestRate, loanAmount, monthlyPayment, TotalPayment;
        int numberOfYears;
        string iMonthlyPayment, iTotalPayment;

        private void BtnExitCalculator_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Loan Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void TxtAmountOfLoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void TxtNumberOfYears_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void TxtInterestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void ErrorEmptyInfo_Click(object sender, EventArgs e)
        {

        }

        private void ErrorFormat_Click(object sender, EventArgs e)
        {

        }

        private void BtnResetCalculator_Click(object sender, EventArgs e)
        {
            txtAmountOfLoan.Clear();
            txtInterestRate.Clear();
            txtNumberOfYears.Clear();
            lblMonthlyPayment.Text = "";
            lblTotalPayment.Text = "";
            rtfReceipt.Clear();
            errorEmptyInfo.Visible = false;
            errorFormat.Visible = false;
            txtAmountOfLoan.Visible = true;
            txtInterestRate.Visible = true;
            txtNumberOfYears.Visible = true;
            lblAmountOfLoan.Visible = false;
            lblInterestRate.Visible = false;
            lblNumberOfYears.Visible = false;
            btnLoanCalculator.Enabled = true;

        }

        private void BtnLoanCalculator_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAmountOfLoan.Text == "" || txtNumberOfYears.Text == "" || txtInterestRate.Text == "")
                {
                    errorEmptyInfo.Visible = true;
                }

                else
                {

                    errorEmptyInfo.Visible = false;
                    errorFormat.Visible = false;
                    txtAmountOfLoan.Visible = false;
                    txtInterestRate.Visible = false;
                    txtNumberOfYears.Visible = false;
                    lblAmountOfLoan.Visible = true;
                    lblInterestRate.Visible = true;
                    lblNumberOfYears.Visible = true;
                    btnLoanCalculator.Enabled = false;

                    interestRate = Convert.ToDouble(txtInterestRate.Text);
                    lblInterestRate.Text = Convert.ToString(interestRate);
                    monthlyInterestRate = (interestRate/100) / 12;
                    numberOfYears = Convert.ToInt32(txtNumberOfYears.Text);
                    lblNumberOfYears.Text = Convert.ToString(numberOfYears);
                    loanAmount = Convert.ToDouble(txtAmountOfLoan.Text);

                    monthlyPayment = loanAmount * (monthlyInterestRate * Math.Pow((1 + monthlyInterestRate),numberOfYears * 12)) / (Math.Pow((1 + monthlyInterestRate), numberOfYears * 12)-1) ;

                    //--------------------------------------------------------------------------------------------------------------------

                    iMonthlyPayment = Convert.ToString(monthlyPayment);
                    iMonthlyPayment = String.Format("{0:C}", monthlyPayment);
                    lblMonthlyPayment.Text = (iMonthlyPayment);

                    //--------------------------------------------------------------------------------------------------------------------

                    TotalPayment = monthlyPayment * numberOfYears * 12;

                    iTotalPayment = Convert.ToString(TotalPayment);
                    iTotalPayment = String.Format("{0:C}", TotalPayment);
                    lblTotalPayment.Text = (iTotalPayment);


                    txtAmountOfLoan.Text = String.Format("{0:C}", loanAmount);
                    lblAmountOfLoan.Text = txtAmountOfLoan.Text;

                    rtfReceipt.AppendText("\t" + "\t" + "\t" + "\t" + "Patrick's Mortgage Calculator" + "\n");
                    rtfReceipt.AppendText("--------------------------------------------------------------------------------------" + "\n");
                    rtfReceipt.AppendText("\t" + "\t" + "\t" + "Mortgage Principal: " + "\t" + "\t" + txtAmountOfLoan.Text + "\n");
                    rtfReceipt.AppendText("\t" + "\t" + "\t" + "Number of Year: " + "\t" + "\t" + "\t" + txtNumberOfYears.Text + "\n");
                    rtfReceipt.AppendText("\t" + "\t" + "\t" + "Number of Monthly Payment: " + "\t" + numberOfYears * 12 + "\n");
                    rtfReceipt.AppendText("\t" + "\t" + "\t" + "Monthly Interest Rate: " + "\t" + "\t" + monthlyInterestRate * 100 + "%" + "\n");
                    rtfReceipt.AppendText("\t" + "\t" + "\t" + "Monthly Payment:" + "\t" + "\t" + "\t" + lblMonthlyPayment.Text + "\n");
                    rtfReceipt.AppendText("\t" + "\t" + "\t" + "Total cost of mortgage:" + "\t" + "\t" + lblTotalPayment.Text + "\n");
                    rtfReceipt.AppendText("--------------------------------------------------------------------------------------" + "\n");
                    rtfReceipt.AppendText("\t" + "\t" + "Press the 'Reset' button to make a new calculation.");

                }
            }
            catch
            {
                errorFormat.Visible = true;
                txtAmountOfLoan.Visible = true;
                txtInterestRate.Visible = true;
                txtNumberOfYears.Visible = true;
                lblAmountOfLoan.Visible = false;
                lblInterestRate.Visible = false;
                lblNumberOfYears.Visible = false;
                btnLoanCalculator.Enabled = true;

            }
            

        }

        public LoanCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
