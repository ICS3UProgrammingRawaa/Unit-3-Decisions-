namespace SumOfNumbersRawaa
{
    partial class frmSumOfNumbers
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lstAddingNumber = new System.Windows.Forms.ListBox();
            this.txtMaxNumber = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(196, 144);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(248, 40);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Enter a Number:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(470, 506);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(59, 40);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "???";
            // 
            // lstAddingNumber
            // 
            this.lstAddingNumber.FormattingEnabled = true;
            this.lstAddingNumber.ItemHeight = 20;
            this.lstAddingNumber.Location = new System.Drawing.Point(302, 205);
            this.lstAddingNumber.Name = "lstAddingNumber";
            this.lstAddingNumber.Size = new System.Drawing.Size(403, 244);
            this.lstAddingNumber.TabIndex = 2;
            // 
            // txtMaxNumber
            // 
            this.txtMaxNumber.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxNumber.Location = new System.Drawing.Point(564, 144);
            this.txtMaxNumber.Name = "txtMaxNumber";
            this.txtMaxNumber.Size = new System.Drawing.Size(155, 38);
            this.txtMaxNumber.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(852, 281);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(154, 39);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmSumOfNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 639);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtMaxNumber);
            this.Controls.Add(this.lstAddingNumber);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblNumber);
            this.Name = "frmSumOfNumbers";
            this.Text = "Sum of Numbers By Rawaa";
            this.Load += new System.EventHandler(this.frmSumOfNumbers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.ListBox lstAddingNumber;
        private System.Windows.Forms.TextBox txtMaxNumber;
        private System.Windows.Forms.Button btnStart;
    }
}

