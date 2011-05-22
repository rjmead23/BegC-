namespace AlphabetCount
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
            this.lblEnterText = new System.Windows.Forms.Label();
            this.txtInputText = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLetter = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lstboxResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblEnterText
            // 
            this.lblEnterText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEnterText.Location = new System.Drawing.Point(12, 18);
            this.lblEnterText.Name = "lblEnterText";
            this.lblEnterText.Size = new System.Drawing.Size(260, 23);
            this.lblEnterText.TabIndex = 0;
            this.lblEnterText.Text = "Enter Text";
            this.lblEnterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInputText
            // 
            this.txtInputText.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputText.Location = new System.Drawing.Point(12, 53);
            this.txtInputText.Multiline = true;
            this.txtInputText.Name = "txtInputText";
            this.txtInputText.Size = new System.Drawing.Size(260, 102);
            this.txtInputText.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(13, 161);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(198, 161);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLetter
            // 
            this.lblLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLetter.Location = new System.Drawing.Point(13, 201);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(115, 23);
            this.lblLetter.TabIndex = 4;
            this.lblLetter.Text = "Letter";
            this.lblLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCount
            // 
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.Location = new System.Drawing.Point(154, 201);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(118, 23);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "Count";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstboxResult
            // 
            this.lstboxResult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxResult.FormattingEnabled = true;
            this.lstboxResult.ItemHeight = 14;
            this.lstboxResult.Location = new System.Drawing.Point(13, 228);
            this.lstboxResult.Name = "lstboxResult";
            this.lstboxResult.Size = new System.Drawing.Size(259, 368);
            this.lstboxResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 613);
            this.Controls.Add(this.lstboxResult);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblLetter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtInputText);
            this.Controls.Add(this.lblEnterText);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alphabet Count";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterText;
        private System.Windows.Forms.TextBox txtInputText;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLetter;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ListBox lstboxResult;
    }
}

