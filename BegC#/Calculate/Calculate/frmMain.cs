using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private Label label1;
    private Label label2;
    private TextBox txtOperand1;
    private TextBox txtOperand2;
    private TextBox txtDisplayOutput;
    private Button btnCalculate;
    private Button btnClear;
    private Button btnExit;
    # region Windows code
    private void InitializeComponent()
    {
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.txtOperand1 = new System.Windows.Forms.TextBox();
        this.txtOperand2 = new System.Windows.Forms.TextBox();
        this.txtDisplayOutput = new System.Windows.Forms.TextBox();
        this.btnCalculate = new System.Windows.Forms.Button();
        this.btnExit = new System.Windows.Forms.Button();
        this.btnClear = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label1.Location = new System.Drawing.Point(14, 9);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(174, 23);
        this.label1.TabIndex = 0;
        this.label1.Text = "Enter First Integer Value:";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label2
        // 
        this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label2.Location = new System.Drawing.Point(13, 44);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(175, 23);
        this.label2.TabIndex = 1;
        this.label2.Text = "Enter Second Integer Value:";
        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtOperand1
        // 
        this.txtOperand1.Location = new System.Drawing.Point(194, 9);
        this.txtOperand1.Name = "txtOperand1";
        this.txtOperand1.Size = new System.Drawing.Size(216, 20);
        this.txtOperand1.TabIndex = 2;
        // 
        // txtOperand2
        // 
        this.txtOperand2.Location = new System.Drawing.Point(194, 46);
        this.txtOperand2.Name = "txtOperand2";
        this.txtOperand2.Size = new System.Drawing.Size(216, 20);
        this.txtOperand2.TabIndex = 3;
        // 
        // txtDisplayOutput
        // 
        this.txtDisplayOutput.Location = new System.Drawing.Point(194, 81);
        this.txtDisplayOutput.Name = "txtDisplayOutput";
        this.txtDisplayOutput.Size = new System.Drawing.Size(216, 20);
        this.txtDisplayOutput.TabIndex = 4;
        this.txtDisplayOutput.Visible = false;
        // 
        // btnCalculate
        // 
        this.btnCalculate.Location = new System.Drawing.Point(14, 120);
        this.btnCalculate.Name = "btnCalculate";
        this.btnCalculate.Size = new System.Drawing.Size(75, 23);
        this.btnCalculate.TabIndex = 5;
        this.btnCalculate.Text = "&Calculate";
        this.btnCalculate.UseVisualStyleBackColor = true;
        this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
        // 
        // btnExit
        // 
        this.btnExit.Location = new System.Drawing.Point(335, 120);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(75, 23);
        this.btnExit.TabIndex = 6;
        this.btnExit.Text = "&Exit";
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
        // 
        // btnClear
        // 
        this.btnClear.Location = new System.Drawing.Point(105, 120);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(75, 23);
        this.btnClear.TabIndex = 7;
        this.btnClear.Text = "Clear";
        this.btnClear.UseVisualStyleBackColor = true;
        this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
        // 
        // frmMain
        // 
        this.ClientSize = new System.Drawing.Size(422, 160);
        this.Controls.Add(this.btnClear);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.btnCalculate);
        this.Controls.Add(this.txtDisplayOutput);
        this.Controls.Add(this.txtOperand2);
        this.Controls.Add(this.txtOperand1);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "frmMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Integer Division";
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

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        bool flag;
        int operand1;
        int operand2;
        int answer;

        //      Input Step
        // Check first input
        flag = int.TryParse(txtOperand1.Text, out operand1);
        if (flag == false)
        {
            MessageBox.Show("Enter a whole number in the First Integer Field", "Input Error");
            txtOperand1.Focus();
            return;
        }

        // check second input
        flag = int.TryParse(txtOperand2.Text, out operand2);
        if (flag == false)
        {
            MessageBox.Show("Enter a whole number in the Second Integer Field", "Input Error");
            txtOperand2.Focus();
            return;
        }

        // Check second input to make sure it is not a zero
        if (txtOperand2.Text != "0")
        {
            //      Process Step
            answer = operand1 * operand2;
            //      Display Step
            txtDisplayOutput.Text = operand1.ToString() + " Multiplied by " +
                                    operand2.ToString() + " equals " +
                                    answer.ToString();
            txtDisplayOutput.Visible = true;
        }
        else
        {
            MessageBox.Show("Second integer value cannot be zero", "Input Error");
            txtOperand2.Focus();
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtDisplayOutput.Visible = false;
        txtDisplayOutput.Clear();
        txtOperand1.Clear();
        txtOperand2.Clear();
        txtOperand1.Focus();
    }
}