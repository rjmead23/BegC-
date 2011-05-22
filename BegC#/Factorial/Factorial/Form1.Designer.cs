namespace Factorial
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtFactorialInput = new System.Windows.Forms.TextBox();
            this.lblFactorial = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(11, 134);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(195, 134);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtFactorialInput
            // 
            this.txtFactorialInput.Location = new System.Drawing.Point(172, 26);
            this.txtFactorialInput.Name = "txtFactorialInput";
            this.txtFactorialInput.Size = new System.Drawing.Size(100, 20);
            this.txtFactorialInput.TabIndex = 2;
            // 
            // lblFactorial
            // 
            this.lblFactorial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFactorial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFactorial.Location = new System.Drawing.Point(13, 26);
            this.lblFactorial.Name = "lblFactorial";
            this.lblFactorial.Size = new System.Drawing.Size(153, 23);
            this.lblFactorial.TabIndex = 3;
            this.lblFactorial.Text = "Enter Factorial to Calculate";
            this.lblFactorial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Location = new System.Drawing.Point(83, 73);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(119, 23);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "label1";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 193);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblFactorial);
            this.Controls.Add(this.txtFactorialInput);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.MaximumSize = new System.Drawing.Size(300, 231);
            this.MinimumSize = new System.Drawing.Size(300, 231);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factorial Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtFactorialInput;
        private System.Windows.Forms.Label lblFactorial;
        private System.Windows.Forms.Label lblAnswer;
    }
}

