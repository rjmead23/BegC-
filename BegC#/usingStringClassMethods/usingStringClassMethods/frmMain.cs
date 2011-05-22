using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private TextBox txtInput;
    private TextBox txtLength;
    private TextBox txtToLower;
    private TextBox txtToUpper;
    private TextBox txtLastIndexOf;
    private TextBox txtSearchIndex;
    private TextBox txtLastChar;
    private TextBox txtSearchChar;
    private TextBox txtReplaceResult;
    private TextBox txtReplaceWith;
    private TextBox txtReplaceChars;
    private TextBox txtRemoveResult;
    private TextBox txtRemove;
    private TextBox txtSubstringResult;
    private TextBox txtEndIndex;
    private TextBox txtStartIndex;
    private Button btnTest;
    private Label lblString;
    private Label lblLength;
    private Label lblsearchChar;
    private Label lblUpper;
    private Label lblLower;
    private Label lblSearchLastChar;
    private Label lblIndexOf;
    private Label lblSubStringIndex;
    private Label lblLastIndexOf;
    private Label label4;
    private Label lblSubString;
    private Label lblRemoval;
    private Label label2;
    private Label label7;
    private Label label8;
    private Button btnExit;
    # region Windows code
    private void InitializeComponent()
    {
        this.txtInput = new System.Windows.Forms.TextBox();
        this.txtLength = new System.Windows.Forms.TextBox();
        this.txtToLower = new System.Windows.Forms.TextBox();
        this.txtToUpper = new System.Windows.Forms.TextBox();
        this.txtLastIndexOf = new System.Windows.Forms.TextBox();
        this.txtSearchIndex = new System.Windows.Forms.TextBox();
        this.txtLastChar = new System.Windows.Forms.TextBox();
        this.txtSearchChar = new System.Windows.Forms.TextBox();
        this.txtReplaceResult = new System.Windows.Forms.TextBox();
        this.txtReplaceWith = new System.Windows.Forms.TextBox();
        this.txtReplaceChars = new System.Windows.Forms.TextBox();
        this.txtRemoveResult = new System.Windows.Forms.TextBox();
        this.txtRemove = new System.Windows.Forms.TextBox();
        this.txtSubstringResult = new System.Windows.Forms.TextBox();
        this.txtEndIndex = new System.Windows.Forms.TextBox();
        this.txtStartIndex = new System.Windows.Forms.TextBox();
        this.btnTest = new System.Windows.Forms.Button();
        this.btnExit = new System.Windows.Forms.Button();
        this.lblString = new System.Windows.Forms.Label();
        this.lblLength = new System.Windows.Forms.Label();
        this.lblsearchChar = new System.Windows.Forms.Label();
        this.lblUpper = new System.Windows.Forms.Label();
        this.lblLower = new System.Windows.Forms.Label();
        this.lblSearchLastChar = new System.Windows.Forms.Label();
        this.lblIndexOf = new System.Windows.Forms.Label();
        this.lblSubStringIndex = new System.Windows.Forms.Label();
        this.lblLastIndexOf = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.lblSubString = new System.Windows.Forms.Label();
        this.lblRemoval = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label7 = new System.Windows.Forms.Label();
        this.label8 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // txtInput
        // 
        this.txtInput.Location = new System.Drawing.Point(211, 20);
        this.txtInput.Name = "txtInput";
        this.txtInput.Size = new System.Drawing.Size(750, 20);
        this.txtInput.TabIndex = 0;
        this.txtInput.Text = "This is a test of various string METHODS, 1234567890 and z";
        // 
        // txtLength
        // 
        this.txtLength.Location = new System.Drawing.Point(211, 57);
        this.txtLength.Name = "txtLength";
        this.txtLength.Size = new System.Drawing.Size(100, 20);
        this.txtLength.TabIndex = 1;
        // 
        // txtToLower
        // 
        this.txtToLower.Location = new System.Drawing.Point(211, 126);
        this.txtToLower.Name = "txtToLower";
        this.txtToLower.Size = new System.Drawing.Size(750, 20);
        this.txtToLower.TabIndex = 3;
        // 
        // txtToUpper
        // 
        this.txtToUpper.Location = new System.Drawing.Point(211, 91);
        this.txtToUpper.Name = "txtToUpper";
        this.txtToUpper.Size = new System.Drawing.Size(750, 20);
        this.txtToUpper.TabIndex = 2;
        // 
        // txtLastIndexOf
        // 
        this.txtLastIndexOf.Location = new System.Drawing.Point(834, 192);
        this.txtLastIndexOf.Name = "txtLastIndexOf";
        this.txtLastIndexOf.Size = new System.Drawing.Size(49, 20);
        this.txtLastIndexOf.TabIndex = 7;
        // 
        // txtSearchIndex
        // 
        this.txtSearchIndex.Location = new System.Drawing.Point(834, 162);
        this.txtSearchIndex.Name = "txtSearchIndex";
        this.txtSearchIndex.Size = new System.Drawing.Size(49, 20);
        this.txtSearchIndex.TabIndex = 6;
        // 
        // txtLastChar
        // 
        this.txtLastChar.Location = new System.Drawing.Point(211, 195);
        this.txtLastChar.Name = "txtLastChar";
        this.txtLastChar.Size = new System.Drawing.Size(54, 20);
        this.txtLastChar.TabIndex = 5;
        this.txtLastChar.Text = "s";
        // 
        // txtSearchChar
        // 
        this.txtSearchChar.Location = new System.Drawing.Point(211, 162);
        this.txtSearchChar.Name = "txtSearchChar";
        this.txtSearchChar.Size = new System.Drawing.Size(54, 20);
        this.txtSearchChar.TabIndex = 4;
        this.txtSearchChar.Text = "v";
        // 
        // txtReplaceResult
        // 
        this.txtReplaceResult.Location = new System.Drawing.Point(211, 332);
        this.txtReplaceResult.Name = "txtReplaceResult";
        this.txtReplaceResult.Size = new System.Drawing.Size(750, 20);
        this.txtReplaceResult.TabIndex = 15;
        // 
        // txtReplaceWith
        // 
        this.txtReplaceWith.Location = new System.Drawing.Point(401, 300);
        this.txtReplaceWith.Name = "txtReplaceWith";
        this.txtReplaceWith.Size = new System.Drawing.Size(100, 20);
        this.txtReplaceWith.TabIndex = 14;
        this.txtReplaceWith.Text = "***";
        // 
        // txtReplaceChars
        // 
        this.txtReplaceChars.Location = new System.Drawing.Point(211, 300);
        this.txtReplaceChars.Name = "txtReplaceChars";
        this.txtReplaceChars.Size = new System.Drawing.Size(100, 20);
        this.txtReplaceChars.TabIndex = 13;
        this.txtReplaceChars.Text = "1234567890";
        // 
        // txtRemoveResult
        // 
        this.txtRemoveResult.Location = new System.Drawing.Point(317, 259);
        this.txtRemoveResult.Name = "txtRemoveResult";
        this.txtRemoveResult.Size = new System.Drawing.Size(644, 20);
        this.txtRemoveResult.TabIndex = 12;
        // 
        // txtRemove
        // 
        this.txtRemove.Location = new System.Drawing.Point(211, 259);
        this.txtRemove.Name = "txtRemove";
        this.txtRemove.Size = new System.Drawing.Size(100, 20);
        this.txtRemove.TabIndex = 11;
        this.txtRemove.Text = "string";
        // 
        // txtSubstringResult
        // 
        this.txtSubstringResult.Location = new System.Drawing.Point(834, 230);
        this.txtSubstringResult.Name = "txtSubstringResult";
        this.txtSubstringResult.Size = new System.Drawing.Size(127, 20);
        this.txtSubstringResult.TabIndex = 10;
        // 
        // txtEndIndex
        // 
        this.txtEndIndex.Location = new System.Drawing.Point(423, 230);
        this.txtEndIndex.Name = "txtEndIndex";
        this.txtEndIndex.Size = new System.Drawing.Size(54, 20);
        this.txtEndIndex.TabIndex = 9;
        this.txtEndIndex.Text = "7";
        // 
        // txtStartIndex
        // 
        this.txtStartIndex.Location = new System.Drawing.Point(211, 227);
        this.txtStartIndex.Name = "txtStartIndex";
        this.txtStartIndex.Size = new System.Drawing.Size(54, 20);
        this.txtStartIndex.TabIndex = 8;
        this.txtStartIndex.Text = "18";
        // 
        // btnTest
        // 
        this.btnTest.Location = new System.Drawing.Point(12, 372);
        this.btnTest.Name = "btnTest";
        this.btnTest.Size = new System.Drawing.Size(100, 23);
        this.btnTest.TabIndex = 16;
        this.btnTest.Text = "&Test";
        this.btnTest.UseVisualStyleBackColor = true;
        this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
        // 
        // btnExit
        // 
        this.btnExit.Location = new System.Drawing.Point(861, 372);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(100, 23);
        this.btnExit.TabIndex = 17;
        this.btnExit.Text = "&Exit";
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
        // 
        // lblString
        // 
        this.lblString.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblString.Location = new System.Drawing.Point(12, 20);
        this.lblString.Name = "lblString";
        this.lblString.Size = new System.Drawing.Size(179, 23);
        this.lblString.TabIndex = 18;
        this.lblString.Text = "String to test:";
        this.lblString.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblLength
        // 
        this.lblLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblLength.Location = new System.Drawing.Point(12, 57);
        this.lblLength.Name = "lblLength";
        this.lblLength.Size = new System.Drawing.Size(179, 23);
        this.lblLength.TabIndex = 19;
        this.lblLength.Text = "String length:";
        this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblsearchChar
        // 
        this.lblsearchChar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblsearchChar.Location = new System.Drawing.Point(12, 160);
        this.lblsearchChar.Name = "lblsearchChar";
        this.lblsearchChar.Size = new System.Drawing.Size(179, 23);
        this.lblsearchChar.TabIndex = 20;
        this.lblsearchChar.Text = "Search for Charactor:";
        this.lblsearchChar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblUpper
        // 
        this.lblUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblUpper.Location = new System.Drawing.Point(12, 91);
        this.lblUpper.Name = "lblUpper";
        this.lblUpper.Size = new System.Drawing.Size(179, 23);
        this.lblUpper.TabIndex = 21;
        this.lblUpper.Text = "String.ToUpper:";
        this.lblUpper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblLower
        // 
        this.lblLower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblLower.Location = new System.Drawing.Point(12, 126);
        this.lblLower.Name = "lblLower";
        this.lblLower.Size = new System.Drawing.Size(179, 23);
        this.lblLower.TabIndex = 22;
        this.lblLower.Text = "String ToLower:";
        this.lblLower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblSearchLastChar
        // 
        this.lblSearchLastChar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblSearchLastChar.Location = new System.Drawing.Point(12, 192);
        this.lblSearchLastChar.Name = "lblSearchLastChar";
        this.lblSearchLastChar.Size = new System.Drawing.Size(179, 23);
        this.lblSearchLastChar.TabIndex = 23;
        this.lblSearchLastChar.Text = "Search for last Charactor:";
        this.lblSearchLastChar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblIndexOf
        // 
        this.lblIndexOf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblIndexOf.Location = new System.Drawing.Point(271, 162);
        this.lblIndexOf.Name = "lblIndexOf";
        this.lblIndexOf.Size = new System.Drawing.Size(557, 23);
        this.lblIndexOf.TabIndex = 24;
        this.lblIndexOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblSubStringIndex
        // 
        this.lblSubStringIndex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblSubStringIndex.Location = new System.Drawing.Point(12, 225);
        this.lblSubStringIndex.Name = "lblSubStringIndex";
        this.lblSubStringIndex.Size = new System.Drawing.Size(179, 23);
        this.lblSubStringIndex.TabIndex = 25;
        this.lblSubStringIndex.Text = "Extract Substring from Index:";
        this.lblSubStringIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblLastIndexOf
        // 
        this.lblLastIndexOf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblLastIndexOf.Location = new System.Drawing.Point(271, 195);
        this.lblLastIndexOf.Name = "lblLastIndexOf";
        this.lblLastIndexOf.Size = new System.Drawing.Size(557, 23);
        this.lblLastIndexOf.TabIndex = 26;
        this.lblLastIndexOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label4
        // 
        this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label4.Location = new System.Drawing.Point(271, 227);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(146, 23);
        this.label4.TabIndex = 27;
        this.label4.Text = "for this many charactors";
        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblSubString
        // 
        this.lblSubString.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblSubString.Location = new System.Drawing.Point(483, 230);
        this.lblSubString.Name = "lblSubString";
        this.lblSubString.Size = new System.Drawing.Size(345, 23);
        this.lblSubString.TabIndex = 28;
        this.lblSubString.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblRemoval
        // 
        this.lblRemoval.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblRemoval.Location = new System.Drawing.Point(12, 259);
        this.lblRemoval.Name = "lblRemoval";
        this.lblRemoval.Size = new System.Drawing.Size(179, 23);
        this.lblRemoval.TabIndex = 30;
        this.lblRemoval.Text = "txtInput.Removal() = :";
        this.lblRemoval.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label2
        // 
        this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label2.Location = new System.Drawing.Point(12, 297);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(179, 23);
        this.label2.TabIndex = 31;
        this.label2.Text = "Find:";
        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label7
        // 
        this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label7.Location = new System.Drawing.Point(317, 297);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(78, 23);
        this.label7.TabIndex = 32;
        this.label7.Text = "Replace With:";
        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label8
        // 
        this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label8.Location = new System.Drawing.Point(12, 332);
        this.label8.Name = "label8";
        this.label8.Size = new System.Drawing.Size(179, 23);
        this.label8.TabIndex = 33;
        this.label8.Text = "txtInput.Replace() = :";
        this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // frmMain
        // 
        this.ClientSize = new System.Drawing.Size(974, 415);
        this.Controls.Add(this.label8);
        this.Controls.Add(this.label7);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.lblRemoval);
        this.Controls.Add(this.lblSubString);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.lblLastIndexOf);
        this.Controls.Add(this.lblSubStringIndex);
        this.Controls.Add(this.lblIndexOf);
        this.Controls.Add(this.lblSearchLastChar);
        this.Controls.Add(this.lblLower);
        this.Controls.Add(this.lblUpper);
        this.Controls.Add(this.lblsearchChar);
        this.Controls.Add(this.lblLength);
        this.Controls.Add(this.lblString);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.btnTest);
        this.Controls.Add(this.txtReplaceResult);
        this.Controls.Add(this.txtReplaceWith);
        this.Controls.Add(this.txtReplaceChars);
        this.Controls.Add(this.txtRemoveResult);
        this.Controls.Add(this.txtRemove);
        this.Controls.Add(this.txtSubstringResult);
        this.Controls.Add(this.txtEndIndex);
        this.Controls.Add(this.txtStartIndex);
        this.Controls.Add(this.txtLastIndexOf);
        this.Controls.Add(this.txtSearchIndex);
        this.Controls.Add(this.txtLastChar);
        this.Controls.Add(this.txtSearchChar);
        this.Controls.Add(this.txtToLower);
        this.Controls.Add(this.txtToUpper);
        this.Controls.Add(this.txtLength);
        this.Controls.Add(this.txtInput);
        this.Name = "frmMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "String Tester";
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

    private void btnTest_Click(object sender, EventArgs e)
    {
        bool flag;
        int index;
        int start;
        int howMany;
        string temp;

        lblIndexOf.Text = " ";

        // Find length
        txtLength.Text = txtInput.Text.Length.ToString();
        // Change case
        txtToUpper.Text = txtInput.Text.ToUpper();

        txtToLower.Text = txtInput.Text.ToLower();

        // Index of
        index = txtInput.Text.IndexOf(txtSearchChar.Text, 0);
        lblIndexOf.Text = "txtInput.Text.IndexOf(\"" + txtSearchChar.Text + "\", 0) = ";
        txtSearchIndex.Text = index.ToString();

        // Last indexOf
        index = txtInput.Text.LastIndexOf(txtLastChar.Text);
        lblLastIndexOf.Text = "txtInput.Text.LastIndexOf(\"" + txtLastChar.Text + "\") = ";
        txtLastIndexOf.Text = index.ToString();

        // Substring
        flag = int.TryParse(txtStartIndex.Text, out start);
        if (flag == false)
        {
            MessageBox.Show("Improper numeric input, re-enter.");
            txtStartIndex.Focus();
            return;
        }
        flag = int.TryParse(txtEndIndex.Text, out howMany);
        if (flag == false)
        {
            MessageBox.Show("Improper numeric input, re-enter.");
            txtEndIndex.Focus();
            return;
        }
        lblSubString.Text = "txtInput.Text.Substring(" + start.ToString() + ", " + howMany.ToString() + ") = ";
        txtSubstringResult.Text = txtInput.Text.Substring(start, howMany);

        // Remove
        temp = txtInput.Text;
        index = temp.IndexOf(txtRemove.Text);
        if (index > 0)
        {
            txtRemoveResult.Text = temp.Remove(index, txtRemove.Text.Length);
        }
        
        // Replace
        temp = txtInput.Text;
        txtReplaceResult.Text = temp.Replace(txtReplaceChars.Text, txtReplaceWith.Text);

    }
}