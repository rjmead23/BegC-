using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Factorial
{
    public partial class Form1 : Form
    {
        bool flag;
        int num;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {          
            flag = int.TryParse(txtFactorialInput.Text, out num);
            if (flag == false)
            {
                MessageBox.Show("Enter Digit numbers only", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                int result = calculateFactorial(num);
                lblAnswer.Visible = true;
                lblAnswer.Text = result.ToString();        
            }
        }

        public int calculateFactorial(int num)
        {
            int i;
            int factorial = 1;

            for (i = num; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
