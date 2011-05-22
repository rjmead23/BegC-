using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private Button btnCalculate;
    private Button btnClose;
    private Label lbl1;
    private TextBox txtValue;
    private TextBox txtOutput;

    bool flag;
    int val;
    string output;


    # region Windows code
    private void InitializeComponent()
    {
        this.btnCalculate = new System.Windows.Forms.Button();
        this.btnClose = new System.Windows.Forms.Button();
        this.lbl1 = new System.Windows.Forms.Label();
        this.txtValue = new System.Windows.Forms.TextBox();
        this.txtOutput = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // btnCalculate
        // 
        this.btnCalculate.Location = new System.Drawing.Point(12, 97);
        this.btnCalculate.Name = "btnCalculate";
        this.btnCalculate.Size = new System.Drawing.Size(75, 23);
        this.btnCalculate.TabIndex = 0;
        this.btnCalculate.Text = "&Calculate";
        this.btnCalculate.UseVisualStyleBackColor = true;
        this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
        // 
        // btnClose
        // 
        this.btnClose.Location = new System.Drawing.Point(204, 97);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(75, 23);
        this.btnClose.TabIndex = 1;
        this.btnClose.Text = "Close";
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
        // 
        // lbl1
        // 
        this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lbl1.Location = new System.Drawing.Point(56, 9);
        this.lbl1.Name = "lbl1";
        this.lbl1.Size = new System.Drawing.Size(163, 23);
        this.lbl1.TabIndex = 2;
        this.lbl1.Text = "Enter a Whole Number Below:";
        this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtValue
        // 
        this.txtValue.Location = new System.Drawing.Point(84, 45);
        this.txtValue.Name = "txtValue";
        this.txtValue.Size = new System.Drawing.Size(100, 20);
        this.txtValue.TabIndex = 3;
        this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // txtOutput
        // 
        this.txtOutput.Location = new System.Drawing.Point(12, 71);
        this.txtOutput.Name = "txtOutput";
        this.txtOutput.Size = new System.Drawing.Size(267, 20);
        this.txtOutput.TabIndex = 4;
        this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.txtOutput.Visible = false;
        // 
        // frmMain
        // 
        this.ClientSize = new System.Drawing.Size(292, 121);
        this.Controls.Add(this.txtOutput);
        this.Controls.Add(this.txtValue);
        this.Controls.Add(this.lbl1);
        this.Controls.Add(this.btnClose);
        this.Controls.Add(this.btnCalculate);
        this.Name = "frmMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Odd or Even";
        this.ResumeLayout(false);
        this.PerformLayout();

    }
    #endregion

    public frmMain()
    {
        InitializeComponent();
    }

    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        // convert text to number
        flag = int.TryParse(txtValue.Text, out val);

        if (flag == false)
        {
            MessageBox.Show("Enter whole number and try again!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            txtOutput.Clear();
            txtOutput.Visible = false;
            txtValue.Clear();
            txtValue.Focus();
        }
        else
        {
            CalculateResult();
        }
    }

    private void CalculateResult()
    {
        // perform calculation
        output = (val % 2 == 1) ? "The value " + val.ToString() + " is an odd number" : "The value " + val.ToString() + " is an even number";
        txtOutput.Text = output;
        txtOutput.Visible = true;

        //if (val % 2 == 1)
        //{
        //    output = "The value " + val.ToString() + " is an odd number";
        //    txtOutput.Text = output;
        //    txtOutput.Visible = true;
        //}
        //else
        //{
        //    output = "The vlaue " + val.ToString() + " is an even number";
        //    txtOutput.Text = output;
        //    txtOutput.Visible = true;
        //}
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}