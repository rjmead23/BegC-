using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlphabetCount
{
    public partial class Form1 : Form
    {

        private const int MAXLETTERS = 26;
        private const int MAXCHARS = MAXLETTERS - 1;
        private const int LETTERA = 65;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            char oneLetter;
            int index;
            int i;
            int length;
            int[] count = new int[MAXLETTERS];
            string input;
            string buff;

            lstboxResult.Items.Clear();

            length = txtInputText.Text.Length; // find out if there's a value in the user input field
            if (length == 0)
            {
                MessageBox.Show("You need to enter some text", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInputText.Focus();
                return;
            }
            input = txtInputText.Text.ToUpper(); // Count for just letters. upper and lower mix would bring different results

            for (i = 0; i < input.Length; i++) // Examine all letters
            {
                oneLetter = input[i];   // get a character
                index = oneLetter - LETTERA;    // Make into an index
                if (index < 0 || index > MAXCHARS)
                    continue;
                count[index]++;
            }
            for (i = 0; i < MAXLETTERS; i++)
            {
                buff = string.Format("{0,8} {1,17}[{2}]", (char)(i + LETTERA), " ", count[i]);
                lstboxResult.Items.Add(buff);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
