using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterestEarned
{
    public partial class Form1 : Form
    {
        decimal investment;
        decimal interest;
        decimal interestEarned;
        int years;
        decimal result;
        bool flag;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateInterest_Click(object sender, EventArgs e)
        {
            lstYearbyYearInterest.Items.Clear();

            flag = decimal.TryParse(txtInitialInvestment.Text, out investment);
            if (flag == false)
            {
                MessageBox.Show("Initial Investment amount needs to be valid", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            flag = decimal.TryParse(txtInterestPercent.Text, out interest);
            if (flag == false)
            {
                MessageBox.Show("Interest needs to be valid", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            flag = int.TryParse(txtYearsInvested.Text, out years);
            if (flag == false)
            {
                MessageBox.Show("Enter number of years", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (investment > 0 && interest > 0 && years > 0)
            {
                calculateInvestment(investment, interest, years);
            }
        }

        private void calculateInvestment(decimal investment, decimal interest, int years)
        {
            string buff;
            decimal val = 0;
            decimal YearlyInterest = interest / 100;
            interestEarned = investment * YearlyInterest * years;
            decimal annualInterestEarned = investment * YearlyInterest;

            result = investment + interestEarned;

            txtInterestEarned.Text = "$" + interestEarned.ToString();
            txtResult.Text = "$" +  result.ToString();

            for (int i = 1; i <= years; i++)
            {
                val += annualInterestEarned;
                buff = string.Format("{0,-5}{1,18:C}", i, val);
                lstYearbyYearInterest.Items.Add(buff);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
