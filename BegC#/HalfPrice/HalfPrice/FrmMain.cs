using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private Button btnExit;
    private Label lblAge;
    private TextBox txtAge;
    private TextBox txtOutputPrice;
    private Button btnCalculatePrice;
    # region Windows code
    private void InitializeComponent()
    {
        this.btnCalculatePrice = new System.Windows.Forms.Button();
        this.btnExit = new System.Windows.Forms.Button();
        this.lblAge = new System.Windows.Forms.Label();
        this.txtAge = new System.Windows.Forms.TextBox();
        this.txtOutputPrice = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // btnCalculatePrice
        // 
        this.btnCalculatePrice.Location = new System.Drawing.Point(14, 125);
        this.btnCalculatePrice.Name = "btnCalculatePrice";
        this.btnCalculatePrice.Size = new System.Drawing.Size(91, 23);
        this.btnCalculatePrice.TabIndex = 0;
        this.btnCalculatePrice.Text = "&Calculate Price";
        this.btnCalculatePrice.UseVisualStyleBackColor = true;
        this.btnCalculatePrice.Click += new System.EventHandler(this.btnCalculatePrice_Click);
        // 
        // btnExit
        // 
        this.btnExit.Location = new System.Drawing.Point(191, 125);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(91, 23);
        this.btnExit.TabIndex = 1;
        this.btnExit.Text = "&Exit";
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
        // 
        // lblAge
        // 
        this.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblAge.Location = new System.Drawing.Point(85, 20);
        this.lblAge.Name = "lblAge";
        this.lblAge.Size = new System.Drawing.Size(100, 23);
        this.lblAge.TabIndex = 2;
        this.lblAge.Text = "Enter Age:";
        this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtAge
        // 
        this.txtAge.Location = new System.Drawing.Point(76, 63);
        this.txtAge.Name = "txtAge";
        this.txtAge.Size = new System.Drawing.Size(130, 20);
        this.txtAge.TabIndex = 3;
        this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // txtOutputPrice
        // 
        this.txtOutputPrice.Location = new System.Drawing.Point(14, 99);
        this.txtOutputPrice.Name = "txtOutputPrice";
        this.txtOutputPrice.Size = new System.Drawing.Size(266, 20);
        this.txtOutputPrice.TabIndex = 4;
        this.txtOutputPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.txtOutputPrice.Visible = false;
        // 
        // frmMain
        // 
        this.ClientSize = new System.Drawing.Size(292, 163);
        this.Controls.Add(this.txtOutputPrice);
        this.Controls.Add(this.txtAge);
        this.Controls.Add(this.lblAge);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.btnCalculatePrice);
        this.Name = "frmMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Calculate Ticket Price";
        this.ResumeLayout(false);
        this.PerformLayout();

    }
    #endregion

    const double FULLPRICE = 16F;
    double price;

    public frmMain()
    {
        InitializeComponent();
    }

    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnCalculatePrice_Click(object sender, EventArgs e)
    {
        bool flag;
        int age;

        flag = int.TryParse(txtAge.Text, out age);
        if (flag == false)
        {
            MessageBox.Show("Value is not a whole number", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
        else
        {
            // call calculate method
            price = CalculatePrice(age);

            txtOutputPrice.Text = "The cost of one ticket for a person aged " + age + " is $" + price.ToString();
            txtOutputPrice.Visible = true;
        }
    }

    private double CalculatePrice(int age)
    {
        price = FULLPRICE;

        if (age < 13 || age > 64)
        {
            price *= .5F;
        }
        return price;
    }
}
