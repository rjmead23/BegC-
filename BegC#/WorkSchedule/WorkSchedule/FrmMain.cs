using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private Label lblChoose;
    private Button btnSchedule;
    private Button btnExit;
    private TextBox txtWorkDay;

    # region Windows code
    private void InitializeComponent()
    {
        this.lblChoose = new System.Windows.Forms.Label();
        this.btnSchedule = new System.Windows.Forms.Button();
        this.btnExit = new System.Windows.Forms.Button();
        this.txtWorkDay = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // lblChoose
        // 
        this.lblChoose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblChoose.Location = new System.Drawing.Point(82, 31);
        this.lblChoose.Name = "lblChoose";
        this.lblChoose.Size = new System.Drawing.Size(100, 23);
        this.lblChoose.TabIndex = 0;
        this.lblChoose.Text = "Choose Workday";
        this.lblChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnSchedule
        // 
        this.btnSchedule.Location = new System.Drawing.Point(12, 130);
        this.btnSchedule.Name = "btnSchedule";
        this.btnSchedule.Size = new System.Drawing.Size(109, 23);
        this.btnSchedule.TabIndex = 1;
        this.btnSchedule.Text = "Review Schedule";
        this.btnSchedule.UseVisualStyleBackColor = true;
        this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
        // 
        // btnExit
        // 
        this.btnExit.Location = new System.Drawing.Point(171, 130);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(109, 23);
        this.btnExit.TabIndex = 2;
        this.btnExit.Text = "&Exit";
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
        // 
        // txtWorkDay
        // 
        this.txtWorkDay.Location = new System.Drawing.Point(37, 72);
        this.txtWorkDay.Name = "txtWorkDay";
        this.txtWorkDay.Size = new System.Drawing.Size(191, 20);
        this.txtWorkDay.TabIndex = 3;
        this.txtWorkDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // frmMain
        // 
        this.ClientSize = new System.Drawing.Size(292, 170);
        this.Controls.Add(this.txtWorkDay);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.btnSchedule);
        this.Controls.Add(this.lblChoose);
        this.Name = "frmMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Work Schedule";
        this.ResumeLayout(false);
        this.PerformLayout();

    }
    #endregion

    //string day;

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

    private void btnSchedule_Click(object sender, EventArgs e)
    {
        string day = txtWorkDay.Text.ToUpper();      

        returnWorkSchedule(day);
    }

    private void returnWorkSchedule(string day)
    {
        switch (day)
        {
            case "MONDAY":
                MessageBox.Show("Go to work on Monday", "schedule", MessageBoxButtons.OK);
                txtWorkDay.Focus();
                break;
            case "TUESDAY":
                MessageBox.Show("No work on Tuesday. Enjoy your day off!!", "schedule", MessageBoxButtons.OK);
                break;
            case "WEDNESDAY":
                MessageBox.Show("Half day of work on Wednesday.", "Schedule", MessageBoxButtons.OK);
                break;
            case "THURSDAY":
                MessageBox.Show("Work from home on Thursday.", "Schedule", MessageBoxButtons.OK);
                break;
            case "FRIDAY":
                MessageBox.Show("All day in the office on Friday.", "Schedule", MessageBoxButtons.OK);
                break;
            case "SATURDAY":
                MessageBox.Show("No work on Saturday. Enjoy your day off!!", "Schedule", MessageBoxButtons.OK);
                break;
            case "SUNDAY":
                MessageBox.Show("No work on Sunday. Enjoy your day off!!", "Schedule", MessageBoxButtons.OK);
                break;
            default:
                MessageBox.Show("Invalid input. enter a day of week and try again!", "Schedule",MessageBoxButtons.OK);
                txtWorkDay.Clear();
                txtWorkDay.Focus();
                break;

        }

    }
}