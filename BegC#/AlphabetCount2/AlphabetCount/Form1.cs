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

            lstvResult.Items.Clear();

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
            ListViewItem which;
            for (i = 0; i < MAXLETTERS; i++)
            {
                oneLetter = (char)(i + LETTERA);
                which = new ListViewItem(oneLetter.ToString());
                which.SubItems.Add("[" + count[i] + "]".ToString());

                lstvResult.Items.Add(which);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
