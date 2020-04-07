namespace ChocolateBoxesRawaa
{
    partial class frmChocolateBoxes
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
            this.nudNumberOfBoxes = new System.Windows.Forms.NumericUpDown();
            this.lblReward = new System.Windows.Forms.Label();
            this.btnReward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfBoxes)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNumberOfBoxes
            // 
            this.nudNumberOfBoxes.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumberOfBoxes.Location = new System.Drawing.Point(607, 200);
            this.nudNumberOfBoxes.Name = "nudNumberOfBoxes";
            this.nudNumberOfBoxes.Size = new System.Drawing.Size(182, 38);
            this.nudNumberOfBoxes.TabIndex = 0;
            // 
            // lblReward
            // 
            this.lblReward.AutoSize = true;
            this.lblReward.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReward.Location = new System.Drawing.Point(471, 413);
            this.lblReward.Name = "lblReward";
            this.lblReward.Size = new System.Drawing.Size(59, 40);
            this.lblReward.TabIndex = 1;
            this.lblReward.Text = "???";
            // 
            // btnReward
            // 
            this.btnReward.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReward.Location = new System.Drawing.Point(132, 192);
            this.btnReward.Name = "btnReward";
            this.btnReward.Size = new System.Drawing.Size(291, 56);
            this.btnReward.TabIndex = 2;
            this.btnReward.Text = "Claim Reward ";
            this.btnReward.UseVisualStyleBackColor = true;
            this.btnReward.Click += new System.EventHandler(this.btnReward_Click);
            // 
            // frmChocolateBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 618);
            this.Controls.Add(this.btnReward);
            this.Controls.Add(this.lblReward);
            this.Controls.Add(this.nudNumberOfBoxes);
            this.Name = "frmChocolateBoxes";
            this.Text = "Chocolate Boxes By Rawaa";
            this.Load += new System.EventHandler(this.frmChocolateBoxes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfBoxes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNumberOfBoxes;
        private System.Windows.Forms.Label lblReward;
        private System.Windows.Forms.Button btnReward;
    }
}

