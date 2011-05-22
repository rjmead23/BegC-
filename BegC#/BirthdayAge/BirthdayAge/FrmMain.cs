using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private TextBox txtBirthday;
    private TextBox txtAge;
    private Button btnCalculate;
    private Button btnExit;
    private Label lblBirthday;
    # region Windows code
    private void InitializeComponent()
    {
        this.txtBirthday = new System.Windows.Forms.TextBox();
        this.txtAge = new System.Windows.Forms.TextBox();
        this.btnCalculate = new System.Windows.Forms.Button();
        this.btnExit = new System.Windows.Forms.Button();
        this.lblBirthday = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // txtBirthday
        // 
        this.txtBirthday.Location = new System.Drawing.Point(47, 58);
        this.txtBirthday.Name = "txtBirthday";
        this.txtBirthday.Size = new System.Drawing.Size(179, 20);
        this.txtBirthday.TabIndex = 0;
        this.txtBirthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // txtAge
        // 
        this.txtAge.Location = new System.Drawing.Point(92, 107);
        this.txtAge.Name = "txtAge";
        this.txtAge.Size = new System.Drawing.Size(100, 20);
        this.txtAge.TabIndex = 1;
        this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.txtAge.Visible = false;
        // 
        // btnCalculate
        // 
        this.btnCalculate.Location = new System.Drawing.Point(12, 154);
        this.btnCalculate.Name = "btnCalculate";
        this.btnCalculate.Size = new System.Drawing.Size(75, 23);
        this.btnCalculate.TabIndex = 2;
        this.btnCalculate.Text = "Calculate";
        this.btnCalculate.UseVisualStyleBackColor = true;
        this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
        // 
        // btnExit
        // 
        this.btnExit.Location = new System.Drawing.Point(205, 154);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(75, 23);
        this.btnExit.TabIndex = 3;
        this.btnExit.Text = "&Exit";
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += new System.EventHandler(this.button2_Click);
        // 
        // lblBirthday
        // 
        this.lblBirthday.AutoSize = true;
        this.lblBirthday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblBirthday.Location = new System.Drawing.Point(71, 20);
        this.lblBirthday.Name = "lblBirthday";
        this.lblBirthday.Size = new System.Drawing.Size(136, 15);
        this.lblBirthday.TabIndex = 4;
        this.lblBirthday.Text = "Enter Birthday MM/DD/YY";
        // 
        // frmMain
        // 
        this.ClientSize = new System.Drawing.Size(292, 199);
        this.Controls.Add(this.lblBirthday);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.btnCalculate);
        this.Controls.Add(this.txtAge);
        this.Controls.Add(this.txtBirthday);
        this.Name = "frmMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Age Finder";
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

    private void button2_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        CalculateAge();
    }

    private void CalculateAge()
    {
        bool flag;
        int age;
        DateTime birthday;
        DateTime currentDateTime = DateTime.Now;

        flag = DateTime.TryParse(txtBirthday.Text, out birthday);
        if (flag == false)
        {
            MessageBox.Show("Invalid Date Format. Use MM/DD/YY", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtAge.Visible = false;
            txtBirthday.Clear();
            txtBirthday.Focus();
        }
        else
        {
            age = currentDateTime.Year - birthday.Year;
            txtAge.Text = "Current Age ";
            txtAge.Text += age.ToString();
            txtAge.Visible = true;
        }

    }
}