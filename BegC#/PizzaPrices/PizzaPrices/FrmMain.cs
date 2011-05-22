using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private Label lblChooseSize;
    private Button btnCalculatePrice;
    private TextBox txtPizzaSize;
    private TextBox txtOutputPrice;
    private Button btnExit;

    const double SMALLPIZZA = 6F;
    double price;
    string size;

    # region Windows code
    private void InitializeComponent()
    {
        this.lblChooseSize = new System.Windows.Forms.Label();
        this.btnCalculatePrice = new System.Windows.Forms.Button();
        this.btnExit = new System.Windows.Forms.Button();
        this.txtPizzaSize = new System.Windows.Forms.TextBox();
        this.txtOutputPrice = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // lblChooseSize
        // 
        this.lblChooseSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblChooseSize.Location = new System.Drawing.Point(66, 9);
        this.lblChooseSize.Name = "lblChooseSize";
        this.lblChooseSize.Size = new System.Drawing.Size(147, 18);
        this.lblChooseSize.TabIndex = 0;
        this.lblChooseSize.Text = "Enter Size of Pizza Below:";
        this.lblChooseSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnCalculatePrice
        // 
        this.btnCalculatePrice.Location = new System.Drawing.Point(14, 125);
        this.btnCalculatePrice.Name = "btnCalculatePrice";
        this.btnCalculatePrice.Size = new System.Drawing.Size(75, 23);
        this.btnCalculatePrice.TabIndex = 1;
        this.btnCalculatePrice.Text = "&Calculate";
        this.btnCalculatePrice.UseVisualStyleBackColor = true;
        this.btnCalculatePrice.Click += new System.EventHandler(this.btnCalculatePrice_Click);
        // 
        // btnExit
        // 
        this.btnExit.Location = new System.Drawing.Point(206, 125);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(75, 23);
        this.btnExit.TabIndex = 2;
        this.btnExit.Text = "&Exit";
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
        // 
        // txtPizzaSize
        // 
        this.txtPizzaSize.Location = new System.Drawing.Point(66, 50);
        this.txtPizzaSize.Name = "txtPizzaSize";
        this.txtPizzaSize.Size = new System.Drawing.Size(147, 20);
        this.txtPizzaSize.TabIndex = 3;
        this.txtPizzaSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // txtOutputPrice
        // 
        this.txtOutputPrice.Location = new System.Drawing.Point(14, 86);
        this.txtOutputPrice.Name = "txtOutputPrice";
        this.txtOutputPrice.Size = new System.Drawing.Size(267, 20);
        this.txtOutputPrice.TabIndex = 4;
        this.txtOutputPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.txtOutputPrice.Visible = false;
        // 
        // frmMain
        // 
        this.ClientSize = new System.Drawing.Size(292, 158);
        this.Controls.Add(this.txtOutputPrice);
        this.Controls.Add(this.txtPizzaSize);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.btnCalculatePrice);
        this.Controls.Add(this.lblChooseSize);
        this.Name = "frmMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Pizza Price";
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

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnCalculatePrice_Click(object sender, EventArgs e)
    {
        size = txtPizzaSize.Text.ToUpper();

        price = CalculatePrice(size);

        if (price != 0)
        {
            txtOutputPrice.Text = "The price of a " + size.ToLower() + " pizza is $" + price.ToString();
            txtOutputPrice.Visible = true;
        }
    }

    private double CalculatePrice(string size)
    {
        switch (size)
        {
            case "SMALL":
                price = SMALLPIZZA;
                break;
            case "MEDIUM":
                price = SMALLPIZZA;
                price += 1;
                break;
            case "LARGE":
                price = SMALLPIZZA;
                price += 2;
                break;
           default:
                MessageBox.Show("Incorrect Pizza size, please enter small, medium or large and try again!",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                price = 0;
                txtOutputPrice.Visible = false;
                txtPizzaSize.Focus();
                txtPizzaSize.SelectAll();
                break;
        }
        return price;
    }
}