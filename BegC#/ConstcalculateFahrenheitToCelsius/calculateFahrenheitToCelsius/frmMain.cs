using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private TextBox txtFahrenheit;
    private Button btnConvert;
    private Button btnExit;
    private TextBox txtCelsiusOutput;
    private Label label1;

    const double fahrenheitFreezingPoint = 32;
    const double fiveNinths = 0.5555555555555555;
    # region Windows code
    private void InitializeComponent()
    {
        this.label1 = new System.Windows.Forms.Label();
        this.txtFahrenheit = new System.Windows.Forms.TextBox();
        this.btnConvert = new System.Windows.Forms.Button();
        this.btnExit = new System.Windows.Forms.Button();
        this.txtCelsiusOutput = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label1.Location = new System.Drawing.Point(83, 24);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(128, 23);
        this.label1.TabIndex = 0;
        this.label1.Text = "Enter Fahrenheit Value";
        // 
        // txtFahrenheit
        // 
        this.txtFahrenheit.Location = new System.Drawing.Point(83, 63);
        this.txtFahrenheit.Name = "txtFahrenheit";
        this.txtFahrenheit.Size = new System.Drawing.Size(128, 20);
        this.txtFahrenheit.TabIndex = 1;
        this.txtFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // btnConvert
        // 
        this.btnConvert.Location = new System.Drawing.Point(12, 129);
        this.btnConvert.Name = "btnConvert";
        this.btnConvert.Size = new System.Drawing.Size(75, 23);
        this.btnConvert.TabIndex = 2;
        this.btnConvert.Text = "&Convert";
        this.btnConvert.UseVisualStyleBackColor = true;
        this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
        // 
        // btnExit
        // 
        this.btnExit.Location = new System.Drawing.Point(205, 129);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(75, 23);
        this.btnExit.TabIndex = 3;
        this.btnExit.Text = "&Exit";
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
        // 
        // txtCelsiusOutput
        // 
        this.txtCelsiusOutput.BackColor = System.Drawing.SystemColors.Control;
        this.txtCelsiusOutput.Location = new System.Drawing.Point(12, 103);
        this.txtCelsiusOutput.Name = "txtCelsiusOutput";
        this.txtCelsiusOutput.Size = new System.Drawing.Size(268, 20);
        this.txtCelsiusOutput.TabIndex = 4;
        this.txtCelsiusOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.txtCelsiusOutput.Visible = false;
        // 
        // frmMain
        // 
        this.ClientSize = new System.Drawing.Size(292, 167);
        this.Controls.Add(this.txtCelsiusOutput);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.btnConvert);
        this.Controls.Add(this.txtFahrenheit);
        this.Controls.Add(this.label1);
        this.Name = "frmMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Fahrenheit to Celsius Converter";
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

    private void btnConvert_Click(object sender, EventArgs e)
    {
        bool flag;
        double farenheitTemp;
        double answer;

        //      Check input
        flag = double.TryParse(txtFahrenheit.Text, out farenheitTemp);
        if (flag == false)
        {
            MessageBox.Show("Enter a valid fahrenheit value", "Input Error");
            txtFahrenheit.Focus();

            return;
        }
            // Process Step
        answer = fiveNinths * (farenheitTemp - fahrenheitFreezingPoint); 

           // Display result
        if (answer != 0)
        {
            txtCelsiusOutput.Text = farenheitTemp.ToString() + " Fahrenheit is " +
                        answer.ToString("#") + " Celsius";
            txtCelsiusOutput.Visible = true;
        }
        else
        {
            txtCelsiusOutput.Text = farenheitTemp.ToString() + " Fahrenheit is " +
            "0" + " Celsius";
            txtCelsiusOutput.Visible = true;
        }
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
