namespace ToManyStudentsRawaa
{
    partial class frmTooManyStudents
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
            this.lblNumberStudents = new System.Windows.Forms.Label();
            this.lblTooManyStudents = new System.Windows.Forms.Label();
            this.btnCheckSize = new System.Windows.Forms.Button();
            this.txtNumStudents = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumberStudents
            // 
            this.lblNumberStudents.AutoSize = true;
            this.lblNumberStudents.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberStudents.Location = new System.Drawing.Point(73, 159);
            this.lblNumberStudents.Name = "lblNumberStudents";
            this.lblNumberStudents.Size = new System.Drawing.Size(434, 30);
            this.lblNumberStudents.TabIndex = 0;
            this.lblNumberStudents.Text = "Enter the number of Students (max 24):";
            // 
            // lblTooManyStudents
            // 
            this.lblTooManyStudents.AutoSize = true;
            this.lblTooManyStudents.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTooManyStudents.Location = new System.Drawing.Point(483, 244);
            this.lblTooManyStudents.Name = "lblTooManyStudents";
            this.lblTooManyStudents.Size = new System.Drawing.Size(46, 30);
            this.lblTooManyStudents.TabIndex = 1;
            this.lblTooManyStudents.Text = "???";
            this.lblTooManyStudents.Click += new System.EventHandler(this.LblAnswer_Click);
            // 
            // btnCheckSize
            // 
            this.btnCheckSize.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckSize.Location = new System.Drawing.Point(179, 239);
            this.btnCheckSize.Name = "btnCheckSize";
            this.btnCheckSize.Size = new System.Drawing.Size(151, 40);
            this.btnCheckSize.TabIndex = 2;
            this.btnCheckSize.Text = "Check Size";
            this.btnCheckSize.UseVisualStyleBackColor = true;
            this.btnCheckSize.Click += new System.EventHandler(this.BtnCheckSize_Click);
            // 
            // txtNumStudents
            // 
            this.txtNumStudents.Location = new System.Drawing.Point(532, 167);
            this.txtNumStudents.Name = "txtNumStudents";
            this.txtNumStudents.Size = new System.Drawing.Size(100, 20);
            this.txtNumStudents.TabIndex = 3;
            // 
            // frmTooManyStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumStudents);
            this.Controls.Add(this.btnCheckSize);
            this.Controls.Add(this.lblTooManyStudents);
            this.Controls.Add(this.lblNumberStudents);
            this.Name = "frmTooManyStudents";
            this.Text = "Too Many Students By Rawaa ";
            this.Load += new System.EventHandler(this.FrmTooManyStudents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberStudents;
        private System.Windows.Forms.Label lblTooManyStudents;
        private System.Windows.Forms.Button btnCheckSize;
        private System.Windows.Forms.TextBox txtNumStudents;
    }
}

