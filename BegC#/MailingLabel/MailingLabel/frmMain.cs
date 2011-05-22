using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private TextBox txtName;
    private TextBox txtAddress;
    private TextBox txtCity;
    private TextBox txtState;
    private TextBox txtZip;
    private TextBox txtDisplayOutput;
    private Button btnDisplayOutput;
    private Button button2;
    # region Windows code
    private void InitializeComponent()
    {
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.txtName = new System.Windows.Forms.TextBox();
        this.txtAddress = new System.Windows.Forms.TextBox();
        this.txtCity = new System.Windows.Forms.TextBox();
        this.txtState = new System.Windows.Forms.TextBox();
        this.txtZip = new System.Windows.Forms.TextBox();
        this.txtDisplayOutput = new System.Windows.Forms.TextBox();
        this.btnDisplayOutput = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label1.Location = new System.Drawing.Point(12, 9);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(75, 20);
        this.label1.TabIndex = 0;
        this.label1.Text = "Name:";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label2
        // 
        this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label2.Location = new System.Drawing.Point(12, 37);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(75, 20);
        this.label2.TabIndex = 1;
        this.label2.Text = "Address:";
        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label3
        // 
        this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label3.Location = new System.Drawing.Point(12, 68);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(75, 20);
        this.label3.TabIndex = 3;
        this.label3.Text = "City:";
        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label4
        // 
        this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label4.Location = new System.Drawing.Point(278, 70);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(40, 20);
        this.label4.TabIndex = 2;
        this.label4.Text = "State:";
        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label5
        // 
        this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label5.Location = new System.Drawing.Point(461, 70);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(40, 20);
        this.label5.TabIndex = 4;
        this.label5.Text = "Zip:";
        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtName
        // 
        this.txtName.Location = new System.Drawing.Point(93, 9);
        this.txtName.Name = "txtName";
        this.txtName.Size = new System.Drawing.Size(478, 20);
        this.txtName.TabIndex = 5;
        // 
        // txtAddress
        // 
        this.txtAddress.Location = new System.Drawing.Point(93, 37);
        this.txtAddress.Name = "txtAddress";
        this.txtAddress.Size = new System.Drawing.Size(478, 20);
        this.txtAddress.TabIndex = 6;
        // 
        // txtCity
        // 
        this.txtCity.Location = new System.Drawing.Point(93, 68);
        this.txtCity.Name = "txtCity";
        this.txtCity.Size = new System.Drawing.Size(179, 20);
        this.txtCity.TabIndex = 7;
        // 
        // txtState
        // 
        this.txtState.Location = new System.Drawing.Point(324, 70);
        this.txtState.Name = "txtState";
        this.txtState.Size = new System.Drawing.Size(131, 20);
        this.txtState.TabIndex = 10;
        // 
        // txtZip
        // 
        this.txtZip.Location = new System.Drawing.Point(507, 70);
        this.txtZip.Name = "txtZip";
        this.txtZip.Size = new System.Drawing.Size(64, 20);
        this.txtZip.TabIndex = 9;
        // 
        // txtDisplayOutput
        // 
        this.txtDisplayOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtDisplayOutput.Location = new System.Drawing.Point(12, 134);
        this.txtDisplayOutput.Multiline = true;
        this.txtDisplayOutput.Name = "txtDisplayOutput";
        this.txtDisplayOutput.ReadOnly = true;
        this.txtDisplayOutput.Size = new System.Drawing.Size(559, 83);
        this.txtDisplayOutput.TabIndex = 8;
        // 
        // btnDisplayOutput
        // 
        this.btnDisplayOutput.Location = new System.Drawing.Point(12, 105);
        this.btnDisplayOutput.Name = "btnDisplayOutput";
        this.btnDisplayOutput.Size = new System.Drawing.Size(110, 23);
        this.btnDisplayOutput.TabIndex = 11;
        this.btnDisplayOutput.Text = "&Display";
        this.btnDisplayOutput.UseVisualStyleBackColor = true;
        this.btnDisplayOutput.Click += new System.EventHandler(this.btnDisplayOutput_Click);
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(461, 105);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(110, 23);
        this.button2.TabIndex = 12;
        this.button2.Text = "&Exit";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // frmMain
        // 
        this.ClientSize = new System.Drawing.Size(581, 233);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.btnDisplayOutput);
        this.Controls.Add(this.txtState);
        this.Controls.Add(this.txtZip);
        this.Controls.Add(this.txtDisplayOutput);
        this.Controls.Add(this.txtCity);
        this.Controls.Add(this.txtAddress);
        this.Controls.Add(this.txtName);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "frmMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Mailing Label Program";
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

    private void btnDisplayOutput_Click(object sender, EventArgs e)
    {
        String buffer;

        buffer = "Mailing label:" + Environment.NewLine +
            Environment.NewLine;
        buffer = buffer + "   Name: " + txtName.Text +
            Environment.NewLine;
        buffer = buffer + "   Address: " + txtAddress.Text +
            Environment.NewLine;
        buffer = buffer + "   City: " + txtCity.Text +
                        "   State: " + txtState.Text +
                        "   Zip: " + txtZip.Text;
        txtDisplayOutput.Text = buffer;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}