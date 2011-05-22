using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomNumbers
{
    public partial class Form1 : Form
    {
        const int MAXITERATIONS = 200000;   // Limit on loop passes

        bool flag;
        int counter;    // Pass counter
        int max;        // Max value for random number
        int last;
        int current;
        Random randomNumber = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {


            //=========================== Program Input Step ============================
            flag = int.TryParse(txtMax.Text, out max);
            if (flag == false)
            {
                MessageBox.Show("Digit Characters only.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtMax.Focus();
            }
            else
            {
                calculateRandom();
            }
        }

        //============================== Program Process Step ===========================
        private void calculateRandom()
        {
            counter = 0;
            last = (int) randomNumber.Next(max);

            do
            {
                current = randomNumber.Next(max);
                if (last == current)
                {
                    break;
                }
                last = current;
                counter++;
            } while (counter < MAXITERATIONS);

            //========================== Program Output Step ============================
            if (counter < MAXITERATIONS)
            {
                lbl2.Visible = true;
                lbl2.Text = "It took " + counter.ToString() + " passes to match";
            }
            else
            {
                lbl2.Visible = true;
                lbl2.Text = "no back to back match";
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
