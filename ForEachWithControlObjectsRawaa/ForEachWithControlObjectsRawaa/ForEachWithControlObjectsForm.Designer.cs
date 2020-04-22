namespace ForEachWithControlObjectsRawaa
{
    partial class frmForEachWithControlObjects
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
            this.lblLabel = new System.Windows.Forms.Label();
            this.btnbutton = new System.Windows.Forms.Button();
            this.chbCheckBox = new System.Windows.Forms.CheckBox();
            this.nudNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.Location = new System.Drawing.Point(243, 190);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(180, 45);
            this.lblLabel.TabIndex = 0;
            this.lblLabel.Text = "Welcome!";
            this.lblLabel.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // btnbutton
            // 
            this.btnbutton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbutton.Location = new System.Drawing.Point(711, 238);
            this.btnbutton.Name = "btnbutton";
            this.btnbutton.Size = new System.Drawing.Size(178, 53);
            this.btnbutton.TabIndex = 1;
            this.btnbutton.Text = "Click Me";
            this.btnbutton.UseVisualStyleBackColor = true;
            this.btnbutton.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // chbCheckBox
            // 
            this.chbCheckBox.AutoSize = true;
            this.chbCheckBox.Font = new System.Drawing.Font("Microsoft Tai Le", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCheckBox.Location = new System.Drawing.Point(315, 445);
            this.chbCheckBox.Name = "chbCheckBox";
            this.chbCheckBox.Size = new System.Drawing.Size(255, 60);
            this.chbCheckBox.TabIndex = 2;
            this.chbCheckBox.Text = "Check Me!";
            this.chbCheckBox.UseVisualStyleBackColor = true;
            this.chbCheckBox.CheckedChanged += new System.EventHandler(this.chbCheckBox_CheckedChanged);
            // 
            // nudNumericUpDown
            // 
            this.nudNumericUpDown.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumericUpDown.Location = new System.Drawing.Point(393, 302);
            this.nudNumericUpDown.Name = "nudNumericUpDown";
            this.nudNumericUpDown.Size = new System.Drawing.Size(151, 38);
            this.nudNumericUpDown.TabIndex = 3;
            this.nudNumericUpDown.ValueChanged += new System.EventHandler(this.nudNumericUpDown_ValueChanged);
            // 
            // frmForEachWithControlObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 614);
            this.Controls.Add(this.nudNumericUpDown);
            this.Controls.Add(this.chbCheckBox);
            this.Controls.Add(this.btnbutton);
            this.Controls.Add(this.lblLabel);
            this.Name = "frmForEachWithControlObjects";
            this.Text = "For Each With Control Objects By Rawaa";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Button btnbutton;
        private System.Windows.Forms.CheckBox chbCheckBox;
        private System.Windows.Forms.NumericUpDown nudNumericUpDown;
    }
}

