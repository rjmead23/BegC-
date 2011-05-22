namespace InterestEarned
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculateInterest = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblInvestment = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtInitialInvestment = new System.Windows.Forms.TextBox();
            this.txtInterestPercent = new System.Windows.Forms.TextBox();
            this.txtYearsInvested = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblInterestEarned = new System.Windows.Forms.Label();
            this.txtInterestEarned = new System.Windows.Forms.TextBox();
            this.lblYearsOutput = new System.Windows.Forms.Label();
            this.lblInterestOutput = new System.Windows.Forms.Label();
            this.lstYearbyYearInterest = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCalculateInterest
            // 
            this.btnCalculateInterest.Location = new System.Drawing.Point(15, 230);
            this.btnCalculateInterest.Name = "btnCalculateInterest";
            this.btnCalculateInterest.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateInterest.TabIndex = 0;
            this.btnCalculateInterest.Text = "Calculate";
            this.btnCalculateInterest.UseVisualStyleBackColor = true;
            this.btnCalculateInterest.Click += new System.EventHandler(this.btnCalculateInterest_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(200, 230);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblInvestment
            // 
            this.lblInvestment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInvestment.Location = new System.Drawing.Point(12, 15);
            this.lblInvestment.Name = "lblInvestment";
            this.lblInvestment.Size = new System.Drawing.Size(136, 23);
            this.lblInvestment.TabIndex = 2;
            this.lblInvestment.Text = "Initial Investment Amount:";
            this.lblInvestment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInterest
            // 
            this.lblInterest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInterest.Location = new System.Drawing.Point(10, 48);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(136, 23);
            this.lblInterest.TabIndex = 3;
            this.lblInterest.Text = "Annual Interest Rate:";
            this.lblInterest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblYears
            // 
            this.lblYears.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblYears.Location = new System.Drawing.Point(10, 81);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(136, 23);
            this.lblYears.TabIndex = 4;
            this.lblYears.Text = "Years Invested:";
            this.lblYears.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(15, 182);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(136, 23);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Total After Investment:";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInitialInvestment
            // 
            this.txtInitialInvestment.Location = new System.Drawing.Point(172, 17);
            this.txtInitialInvestment.Name = "txtInitialInvestment";
            this.txtInitialInvestment.Size = new System.Drawing.Size(100, 20);
            this.txtInitialInvestment.TabIndex = 6;
            // 
            // txtInterestPercent
            // 
            this.txtInterestPercent.Location = new System.Drawing.Point(172, 50);
            this.txtInterestPercent.Name = "txtInterestPercent";
            this.txtInterestPercent.Size = new System.Drawing.Size(100, 20);
            this.txtInterestPercent.TabIndex = 7;
            // 
            // txtYearsInvested
            // 
            this.txtYearsInvested.Location = new System.Drawing.Point(170, 84);
            this.txtYearsInvested.Name = "txtYearsInvested";
            this.txtYearsInvested.Size = new System.Drawing.Size(100, 20);
            this.txtYearsInvested.TabIndex = 8;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(175, 183);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 9;
            // 
            // lblInterestEarned
            // 
            this.lblInterestEarned.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInterestEarned.Location = new System.Drawing.Point(13, 144);
            this.lblInterestEarned.Name = "lblInterestEarned";
            this.lblInterestEarned.Size = new System.Drawing.Size(135, 23);
            this.lblInterestEarned.TabIndex = 10;
            this.lblInterestEarned.Text = "Interest Earned:";
            this.lblInterestEarned.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInterestEarned
            // 
            this.txtInterestEarned.Enabled = false;
            this.txtInterestEarned.Location = new System.Drawing.Point(174, 147);
            this.txtInterestEarned.Name = "txtInterestEarned";
            this.txtInterestEarned.ReadOnly = true;
            this.txtInterestEarned.Size = new System.Drawing.Size(100, 20);
            this.txtInterestEarned.TabIndex = 11;
            // 
            // lblYearsOutput
            // 
            this.lblYearsOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblYearsOutput.Location = new System.Drawing.Point(299, 16);
            this.lblYearsOutput.Name = "lblYearsOutput";
            this.lblYearsOutput.Size = new System.Drawing.Size(84, 23);
            this.lblYearsOutput.TabIndex = 12;
            this.lblYearsOutput.Text = "Years";
            // 
            // lblInterestOutput
            // 
            this.lblInterestOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInterestOutput.Location = new System.Drawing.Point(398, 15);
            this.lblInterestOutput.Name = "lblInterestOutput";
            this.lblInterestOutput.Size = new System.Drawing.Size(84, 23);
            this.lblInterestOutput.TabIndex = 13;
            this.lblInterestOutput.Text = "Interest Earned";
            // 
            // lstYearbyYearInterest
            // 
            this.lstYearbyYearInterest.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstYearbyYearInterest.FormattingEnabled = true;
            this.lstYearbyYearInterest.ItemHeight = 14;
            this.lstYearbyYearInterest.Location = new System.Drawing.Point(299, 41);
            this.lstYearbyYearInterest.Name = "lstYearbyYearInterest";
            this.lstYearbyYearInterest.Size = new System.Drawing.Size(183, 200);
            this.lstYearbyYearInterest.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 265);
            this.Controls.Add(this.lstYearbyYearInterest);
            this.Controls.Add(this.lblInterestOutput);
            this.Controls.Add(this.lblYearsOutput);
            this.Controls.Add(this.txtInterestEarned);
            this.Controls.Add(this.lblInterestEarned);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtYearsInvested);
            this.Controls.Add(this.txtInterestPercent);
            this.Controls.Add(this.txtInitialInvestment);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.lblInvestment);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculateInterest);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interest Earned calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateInterest;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblInvestment;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtInitialInvestment;
        private System.Windows.Forms.TextBox txtInterestPercent;
        private System.Windows.Forms.TextBox txtYearsInvested;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblInterestEarned;
        private System.Windows.Forms.TextBox txtInterestEarned;
        private System.Windows.Forms.Label lblYearsOutput;
        private System.Windows.Forms.Label lblInterestOutput;
        private System.Windows.Forms.ListBox lstYearbyYearInterest;
    }
}

