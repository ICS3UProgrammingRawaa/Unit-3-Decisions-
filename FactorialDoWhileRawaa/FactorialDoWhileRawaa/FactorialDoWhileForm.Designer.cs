namespace FactorialDoWhileRawaa
{
    partial class frmFactorialDoWhile
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
            this.lstFactorialNumbers = new System.Windows.Forms.ListBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblClickStart = new System.Windows.Forms.Label();
            this.prbProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblFactorialAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstFactorialNumbers
            // 
            this.lstFactorialNumbers.FormattingEnabled = true;
            this.lstFactorialNumbers.ItemHeight = 20;
            this.lstFactorialNumbers.Location = new System.Drawing.Point(90, 117);
            this.lstFactorialNumbers.Name = "lstFactorialNumbers";
            this.lstFactorialNumbers.Size = new System.Drawing.Size(329, 244);
            this.lstFactorialNumbers.TabIndex = 0;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(509, 117);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(378, 40);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Please Enter Any Number";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(598, 316);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(202, 56);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(614, 201);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(159, 38);
            this.txtNumber.TabIndex = 3;
            // 
            // lblClickStart
            // 
            this.lblClickStart.AutoSize = true;
            this.lblClickStart.Location = new System.Drawing.Point(650, 268);
            this.lblClickStart.Name = "lblClickStart";
            this.lblClickStart.Size = new System.Drawing.Size(78, 20);
            this.lblClickStart.TabIndex = 4;
            this.lblClickStart.Text = "Click start";
            // 
            // prbProgressBar
            // 
            this.prbProgressBar.Location = new System.Drawing.Point(320, 427);
            this.prbProgressBar.Name = "prbProgressBar";
            this.prbProgressBar.Size = new System.Drawing.Size(310, 49);
            this.prbProgressBar.TabIndex = 5;
            // 
            // lblFactorialAnswer
            // 
            this.lblFactorialAnswer.AutoSize = true;
            this.lblFactorialAnswer.Location = new System.Drawing.Point(444, 497);
            this.lblFactorialAnswer.Name = "lblFactorialAnswer";
            this.lblFactorialAnswer.Size = new System.Drawing.Size(0, 20);
            this.lblFactorialAnswer.TabIndex = 6;
            // 
            // frmFactorialDoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 576);
            this.Controls.Add(this.lblFactorialAnswer);
            this.Controls.Add(this.prbProgressBar);
            this.Controls.Add(this.lblClickStart);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lstFactorialNumbers);
            this.Name = "frmFactorialDoWhile";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFactorialNumbers;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblClickStart;
        private System.Windows.Forms.ProgressBar prbProgressBar;
        private System.Windows.Forms.Label lblFactorialAnswer;
    }
}

