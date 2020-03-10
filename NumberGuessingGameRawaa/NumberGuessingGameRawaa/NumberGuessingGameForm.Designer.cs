namespace NumberGuessingGameRawaa
{
    partial class frmNumberGuessingGame
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
            this.lblNumStudents = new System.Windows.Forms.Label();
            this.lblGuess = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtNumStudents = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumStudents
            // 
            this.lblNumStudents.AutoSize = true;
            this.lblNumStudents.Location = new System.Drawing.Point(210, 162);
            this.lblNumStudents.Name = "lblNumStudents";
            this.lblNumStudents.Size = new System.Drawing.Size(35, 13);
            this.lblNumStudents.TabIndex = 0;
            this.lblNumStudents.Text = "label1";
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(484, 303);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(35, 13);
            this.lblGuess.TabIndex = 1;
            this.lblGuess.Text = "label2";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(169, 284);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // txtNumStudents
            // 
            this.txtNumStudents.Location = new System.Drawing.Point(487, 162);
            this.txtNumStudents.Name = "txtNumStudents";
            this.txtNumStudents.Size = new System.Drawing.Size(100, 20);
            this.txtNumStudents.TabIndex = 3;
            // 
            // frmNumberGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumStudents);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.lblNumStudents);
            this.Name = "frmNumberGuessingGame";
            this.Text = "Number Guessing Game By Rawaa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumStudents;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtNumStudents;
    }
}

