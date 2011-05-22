using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private Label lblStartValue;
    private Label lblEndValue;
    private Label lblNumber;
    private Label lblNumberSquared;
    private Button btnCalculate;
    private Button btnClear;
    private Button btnClose;
    private TextBox txtStart;
    private TextBox txtEnd;
    private ListBox lstOutput;

    string buff;

    # region Windows code
    private void InitializeComponent()
    {
        this.lstOutput = new System.Windows.Forms.ListBox();
        this.lblStartValue = new System.Windows.Forms.Label();
        this.lblEndValue = new System.Windows.Forms.Label();
        this.lblNumber = new System.Windows.Forms.Label();
        this.lblNumberSquared = new System.Windows.Forms.Label();
        this.btnCalculate = new System.Windows.Forms.Button();
        this.btnClear = new System.Windows.Forms.Button();
        this.btnClose = new System.Windows.Forms.Button();
        this.txtStart = new System.Windows.Forms.TextBox();
        this.txtEnd = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // lstOutput
        // 
        this.lstOutput.FormattingEnabled = true;
        this.lstOutput.Location = new System.Drawing.Point(12, 149);
        this.lstOutput.Name = "lstOutput";
        this.lstOutput.Size = new System.Drawing.Size(251, 238);
        this.lstOutput.TabIndex = 0;
        // 
        // lblStartValue
        // 
        this.lblStartValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblStartValue.Location = new System.Drawing.Point(12, 13);
        this.lblStartValue.Name = "lblStartValue";
        this.lblStartValue.Size = new System.Drawing.Size(133, 23);
        this.lblStartValue.TabIndex = 1;
        this.lblStartValue.Text = "Starting Table Value:";
        this.lblStartValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblEndValue
        // 
        this.lblEndValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblEndValue.Location = new System.Drawing.Point(12, 41);
        this.lblEndValue.Name = "lblEndValue";
        this.lblEndValue.Size = new System.Drawing.Size(133, 23);
        this.lblEndValue.TabIndex = 2;
        this.lblEndValue.Text = "Ending Table value:";
        this.lblEndValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblNumber
        // 
        this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblNumber.Location = new System.Drawing.Point(12, 123);
        this.lblNumber.Name = "lblNumber";
        this.lblNumber.Size = new System.Drawing.Size(100, 23);
        this.lblNumber.TabIndex = 3;
        this.lblNumber.Text = "Number";
        this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblNumberSquared
        // 
        this.lblNumberSquared.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblNumberSquared.Location = new System.Drawing.Point(163, 123);
        this.lblNumberSquared.Name = "lblNumberSquared";
        this.lblNumberSquared.Size = new System.Drawing.Size(100, 23);
        this.lblNumberSquared.TabIndex = 4;
        this.lblNumberSquared.Text = "Number Squared";
        this.lblNumberSquared.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnCalculate
        // 
        this.btnCalculate.Location = new System.Drawing.Point(12, 83);
        this.btnCalculate.Name = "btnCalculate";
        this.btnCalculate.Size = new System.Drawing.Size(75, 23);
        this.btnCalculate.TabIndex = 5;
        this.btnCalculate.Text = "Calculate";
        this.btnCalculate.UseVisualStyleBackColor = true;
        this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
        // 
        // btnClear
        // 
        this.btnClear.Location = new System.Drawing.Point(94, 82);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(75, 23);
        this.btnClear.TabIndex = 6;
        this.btnClear.Text = "Clear";
        this.btnClear.UseVisualStyleBackColor = true;
        this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
        // 
        // btnClose
        // 
        this.btnClose.Location = new System.Drawing.Point(176, 83);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(75, 23);
        this.btnClose.TabIndex = 7;
        this.btnClose.Text = "Close";
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
        // 
        // txtStart
        // 
        this.txtStart.Location = new System.Drawing.Point(151, 13);
        this.txtStart.Name = "txtStart";
        this.txtStart.Size = new System.Drawing.Size(100, 20);
        this.txtStart.TabIndex = 8;
        this.txtStart.Text = "0";
        // 
        // txtEnd
        // 
        this.txtEnd.Location = new System.Drawing.Point(151, 41);
        this.txtEnd.Name = "txtEnd";
        this.txtEnd.Size = new System.Drawing.Size(100, 20);
        this.txtEnd.TabIndex = 9;
        this.txtEnd.Text = "100";
        // 
        // frmMain
        // 
        this.ClientSize = new System.Drawing.Size(292, 410);
        this.Controls.Add(this.txtEnd);
        this.Controls.Add(this.txtStart);
        this.Controls.Add(this.btnClose);
        this.Controls.Add(this.btnClear);
        this.Controls.Add(this.btnCalculate);
        this.Controls.Add(this.lblNumberSquared);
        this.Controls.Add(this.lblNumber);
        this.Controls.Add(this.lblEndValue);
        this.Controls.Add(this.lblStartValue);
        this.Controls.Add(this.lstOutput);
        this.MaximizeBox = false;
        this.MaximumSize = new System.Drawing.Size(300, 444);
        this.MinimumSize = new System.Drawing.Size(300, 444);
        this.Name = "frmMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Table Of Squares";
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
        bool flag;
        int start;
        int end;

        // Clear previous results
        lstOutput.Items.Clear();

        //===================== Gather Inputs =======================================

        // Convert start from text to int
        flag = int.TryParse(txtStart.Text, out start);
        if (flag == false)
        {
            MessageBox.Show("Numeric data only", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtStart.SelectAll();
            txtStart.Focus();
            return;
        }

        // Convert end from text to int
        flag = int.TryParse(txtEnd.Text, out end);
        if (flag == false)
        {
            MessageBox.Show("Numeric data only", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtEnd.Focus();
            txtEnd.SelectAll();
            return;
        }

        // Check for reasonable values
        if (start > end)
        {
            MessageBox.Show("Start is greater than end.", "Input Error", MessageBoxButtons.OK);
            txtStart.Focus();
            txtStart.SelectAll();
            return;
        }
        else
        {
            CalculateNumbers(start, end);
        } 
    }

    private void CalculateNumbers(int start, int end)
    {
        //int i;

        //for (i = start; i <= end; i++)
        //{
        //    buff = string.Format("{0, 5}{1,60}", i, i * i);
        //    lstOutput.Items.Add(buff);
        //}

        int i;
        int j;
        int square;
        int nextOddInteger;

        for (i = start; i <= end; i++)
        {
            nextOddInteger = 1; // set first odd integer
            square = 0; // Always start with square = 0

            for (j = 0; j < i; j++) // Nested j loop
            {
                square += nextOddInteger;   // sum the odd integer
                nextOddInteger += 2;        // Set the next odd integer
            }

            buff = String.Format("{0, 5}{1, 60}", i, square);
            lstOutput.Items.Add(buff);
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        // Clear any previuous results
        lstOutput.Items.Clear();
        txtStart.Clear();
        txtEnd.Clear();
        txtStart.Focus();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}