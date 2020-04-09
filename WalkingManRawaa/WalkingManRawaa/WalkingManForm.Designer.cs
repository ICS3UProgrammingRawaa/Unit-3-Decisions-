namespace WalkingManRawaa
{
    partial class frmWalkingMan
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
            this.btnWalk = new System.Windows.Forms.Button();
            this.picMan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWalk
            // 
            this.btnWalk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnWalk.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWalk.Location = new System.Drawing.Point(247, 105);
            this.btnWalk.Name = "btnWalk";
            this.btnWalk.Size = new System.Drawing.Size(181, 60);
            this.btnWalk.TabIndex = 0;
            this.btnWalk.Text = "Walk";
            this.btnWalk.UseVisualStyleBackColor = false;
            this.btnWalk.Click += new System.EventHandler(this.btnWalk_Click);
            // 
            // picMan
            // 
            this.picMan.Image = global::WalkingManRawaa.Properties.Resources.walk10;
            this.picMan.Location = new System.Drawing.Point(150, 209);
            this.picMan.Name = "picMan";
            this.picMan.Size = new System.Drawing.Size(377, 344);
            this.picMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMan.TabIndex = 1;
            this.picMan.TabStop = false;
            // 
            // frmWalkingMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 657);
            this.Controls.Add(this.picMan);
            this.Controls.Add(this.btnWalk);
            this.Name = "frmWalkingMan";
            this.Text = "Walking Man By Rawaa";
            ((System.ComponentModel.ISupportInitialize)(this.picMan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWalk;
        private System.Windows.Forms.PictureBox picMan;
    }
}

