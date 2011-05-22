using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OuncesToGrams
{
    public partial class Form1 : Form
    {
        const double GRAMSPEROUNCE = 28.3495231;
        const int OUNCESTOPOUND = 16;
        int pounds;
        int ounces;
        double grams;
        bool flag;
        string buff;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            flag = int.TryParse(txtPounds.Text, out pounds);
            if (flag == false)
            {
                MessageBox.Show("Enter valid value", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ounces = pounds * OUNCESTOPOUND;


                ConvertPoundsToGrams(ounces);

            }            
        }

        private void ConvertPoundsToGrams(int ounces)
        {
            int i;
            for (i = 1; i <= ounces; i++)
            {
                grams = (double) i * GRAMSPEROUNCE;
                buff = string.Format("{0,4},{1,55}", i, grams);
                lstConversion.Items.Add(buff);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
