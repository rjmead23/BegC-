using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private Button btnRefresh;
    private Button btnClose;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private TextBox txtCompleteDateAndTime;
    private TextBox txtLongDate;
    private TextBox txtGeneralDateAndTime;
    private TextBox txtShortDate;
    private TextBox txtShortTime;
    private TextBox txtLongTime;
    private TextBox txtDaysToNewYears;
    # region Windows code
    private void InitializeComponent()
    {
        this.btnRefresh = new System.Windows.Forms.Button();
        this.btnClose = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.label6 = new System.Windows.Forms.Label();
        this.label7 = new System.Windows.Forms.Label();
        this.txtCompleteDateAndTime = new System.Windows.Forms.TextBox();
        this.txtLongDate = new System.Windows.Forms.TextBox();
        this.txtGeneralDateAndTime = new System.Windows.Forms.TextBox();
        this.txtShortDate = new System.Windows.Forms.TextBox();
        this.txtShortTime = new System.Windows.Forms.TextBox();
        this.txtLongTime = new System.Windows.Forms.TextBox();
        this.txtDaysToNewYears = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // btnRefresh
        // 
        this.btnRefresh.Location = new System.Drawing.Point(12, 255);
        this.btnRefresh.Name = "btnRefresh";
        this.btnRefresh.Size = new System.Drawing.Size(75, 23);
        this.btnRefresh.TabIndex = 0;
        this.btnRefresh.Text = "&Refresh";
        this.btnRefresh.UseVisualStyleBackColor = true;
        this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
        // 
        // btnClose
        // 
        this.btnClose.Location = new System.Drawing.Point(278, 255);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(75, 23);
        this.btnClose.TabIndex = 1;
        this.btnClose.Text = "&Close";
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
        // 
        // label1
        // 
        this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label1.Location = new System.Drawing.Point(12, 19);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(154, 23);
        this.label1.TabIndex = 2;
        this.label1.Text = "Full Date and Time:";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label2
        // 
        this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label2.Location = new System.Drawing.Point(12, 53);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(154, 23);
        this.label2.TabIndex = 3;
        this.label2.Text = "Long Date:";
        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label3
        // 
        this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label3.Location = new System.Drawing.Point(12, 119);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(154, 23);
        this.label3.TabIndex = 5;
        this.label3.Text = "General Date and Time:";
        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label4
        // 
        this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label4.Location = new System.Drawing.Point(12, 85);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(154, 23);
        this.label4.TabIndex = 4;
        this.label4.Text = "Short Date:";
        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label5
        // 
        this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label5.Location = new System.Drawing.Point(12, 185);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(154, 23);
        this.label5.TabIndex = 7;
        this.label5.Text = "Short Time:";
        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label6
        // 
        this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label6.Location = new System.Drawing.Point(12, 151);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(154, 23);
        this.label6.TabIndex = 6;
        this.label6.Text = "Long Time:";
        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label7
        // 
        this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label7.Location = new System.Drawing.Point(12, 217);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(154, 23);
        this.label7.TabIndex = 8;
        this.label7.Text = "Days until New Years Eve:";
        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtCompleteDateAndTime
        // 
        this.txtCompleteDateAndTime.Location = new System.Drawing.Point(172, 21);
        this.txtCompleteDateAndTime.Name = "txtCompleteDateAndTime";
        this.txtCompleteDateAndTime.Size = new System.Drawing.Size(181, 20);
        this.txtCompleteDateAndTime.TabIndex = 9;
        // 
        // txtLongDate
        // 
        this.txtLongDate.Location = new System.Drawing.Point(172, 53);
        this.txtLongDate.Name = "txtLongDate";
        this.txtLongDate.Size = new System.Drawing.Size(180, 20);
        this.txtLongDate.TabIndex = 10;
        // 
        // txtGeneralDateAndTime
        // 
        this.txtGeneralDateAndTime.Location = new System.Drawing.Point(172, 120);
        this.txtGeneralDateAndTime.Name = "txtGeneralDateAndTime";
        this.txtGeneralDateAndTime.Size = new System.Drawing.Size(179, 20);
        this.txtGeneralDateAndTime.TabIndex = 12;
        // 
        // txtShortDate
        // 
        this.txtShortDate.Location = new System.Drawing.Point(173, 88);
        this.txtShortDate.Name = "txtShortDate";
        this.txtShortDate.Size = new System.Drawing.Size(179, 20);
        this.txtShortDate.TabIndex = 11;
        // 
        // txtShortTime
        // 
        this.txtShortTime.Location = new System.Drawing.Point(171, 187);
        this.txtShortTime.Name = "txtShortTime";
        this.txtShortTime.Size = new System.Drawing.Size(179, 20);
        this.txtShortTime.TabIndex = 14;
        // 
        // txtLongTime
        // 
        this.txtLongTime.Location = new System.Drawing.Point(172, 153);
        this.txtLongTime.Name = "txtLongTime";
        this.txtLongTime.Size = new System.Drawing.Size(179, 20);
        this.txtLongTime.TabIndex = 13;
        // 
        // txtDaysToNewYears
        // 
        this.txtDaysToNewYears.Location = new System.Drawing.Point(172, 219);
        this.txtDaysToNewYears.Name = "txtDaysToNewYears";
        this.txtDaysToNewYears.Size = new System.Drawing.Size(179, 20);
        this.txtDaysToNewYears.TabIndex = 15;
        // 
        // frmMain
        // 
        this.ClientSize = new System.Drawing.Size(365, 293);
        this.Controls.Add(this.txtDaysToNewYears);
        this.Controls.Add(this.txtShortTime);
        this.Controls.Add(this.txtLongTime);
        this.Controls.Add(this.txtGeneralDateAndTime);
        this.Controls.Add(this.txtShortDate);
        this.Controls.Add(this.txtLongDate);
        this.Controls.Add(this.txtCompleteDateAndTime);
        this.Controls.Add(this.label7);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.btnClose);
        this.Controls.Add(this.btnRefresh);
        this.MaximizeBox = false;
        this.MaximumSize = new System.Drawing.Size(373, 327);
        this.MinimumSize = new System.Drawing.Size(373, 327);
        this.Name = "frmMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Date Time Tester";
        this.ResumeLayout(false);
        this.PerformLayout();

    }
    #endregion

    public frmMain()
    {
        InitializeComponent();
        UpdateDateTimeInfo(); // Update Text Boxes on Form Initialization
    }

    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        UpdateDateTimeInfo();
    }

    private void UpdateDateTimeInfo()
    {
        int days;
        DateTime myTime = new DateTime();
        myTime = DateTime.Now;
        DateTime newYears = new DateTime(myTime.Year, 12, 31);

        txtCompleteDateAndTime.Text = myTime.ToString("F");
        txtLongDate.Text = myTime.ToString("D");
        txtShortDate.Text = myTime.ToString("d");
        txtGeneralDateAndTime.Text = myTime.ToString("g");
        txtLongTime.Text = myTime.ToString("T");
        txtShortTime.Text = myTime.ToString("t");

        days = newYears.DayOfYear - myTime.DayOfYear;
        txtDaysToNewYears.Text = days.ToString();
    }
}