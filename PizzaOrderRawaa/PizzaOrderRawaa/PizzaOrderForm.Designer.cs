namespace PizzaOrderRawaa
{
    partial class frmPizzaOrder
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
            this.grbPizzaSize = new System.Windows.Forms.GroupBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblXtraLarge = new System.Windows.Forms.Label();
            this.lblLarge = new System.Windows.Forms.Label();
            this.lblSmall = new System.Windows.Forms.Label();
            this.lblSizeChoice = new System.Windows.Forms.Label();
            this.grbToppings = new System.Windows.Forms.GroupBox();
            this.txtToppings = new System.Windows.Forms.TextBox();
            this.lblThreeToppings = new System.Windows.Forms.Label();
            this.lblTwoToppings = new System.Windows.Forms.Label();
            this.lblOneTopping = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lbFourToppings = new System.Windows.Forms.Label();
            this.lblSizeCost = new System.Windows.Forms.Label();
            this.lblToppingsCost = new System.Windows.Forms.Label();
            this.grbDrink = new System.Windows.Forms.GroupBox();
            this.lblDrink = new System.Windows.Forms.Label();
            this.txtDrink = new System.Windows.Forms.TextBox();
            this.lblYes = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblDrinkCost = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblHst = new System.Windows.Forms.Label();
            this.lblSubtotalC = new System.Windows.Forms.Label();
            this.lblTotalC = new System.Windows.Forms.Label();
            this.lblHstC = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbProvinces = new System.Windows.Forms.GroupBox();
            this.radOntario = new System.Windows.Forms.RadioButton();
            this.radAlberta = new System.Windows.Forms.RadioButton();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.nudToppings = new System.Windows.Forms.NumericUpDown();
            this.nudDrink = new System.Windows.Forms.NumericUpDown();
            this.grbPizzaSize.SuspendLayout();
            this.grbToppings.SuspendLayout();
            this.grbDrink.SuspendLayout();
            this.grbProvinces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrink)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPizzaSize
            // 
            this.grbPizzaSize.Controls.Add(this.nudSize);
            this.grbPizzaSize.Controls.Add(this.lblSizeCost);
            this.grbPizzaSize.Controls.Add(this.lblXtraLarge);
            this.grbPizzaSize.Controls.Add(this.lblLarge);
            this.grbPizzaSize.Controls.Add(this.lblSmall);
            this.grbPizzaSize.Controls.Add(this.lblSizeChoice);
            this.grbPizzaSize.Location = new System.Drawing.Point(12, 3);
            this.grbPizzaSize.Name = "grbPizzaSize";
            this.grbPizzaSize.Size = new System.Drawing.Size(508, 296);
            this.grbPizzaSize.TabIndex = 5;
            this.grbPizzaSize.TabStop = false;
            this.grbPizzaSize.Text = "Pizza Size";
            this.grbPizzaSize.Enter += new System.EventHandler(this.grbPizzaSize_Enter);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(985, 436);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(97, 26);
            this.txtSize.TabIndex = 9;
            this.txtSize.Text = " ";
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // lblXtraLarge
            // 
            this.lblXtraLarge.AutoSize = true;
            this.lblXtraLarge.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXtraLarge.Location = new System.Drawing.Point(29, 193);
            this.lblXtraLarge.Name = "lblXtraLarge";
            this.lblXtraLarge.Size = new System.Drawing.Size(163, 30);
            this.lblXtraLarge.TabIndex = 8;
            this.lblXtraLarge.Text = "Xtra Large = 3";
            // 
            // lblLarge
            // 
            this.lblLarge.AutoSize = true;
            this.lblLarge.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLarge.Location = new System.Drawing.Point(29, 146);
            this.lblLarge.Name = "lblLarge";
            this.lblLarge.Size = new System.Drawing.Size(114, 30);
            this.lblLarge.TabIndex = 7;
            this.lblLarge.Text = "Large = 2";
            // 
            // lblSmall
            // 
            this.lblSmall.AutoSize = true;
            this.lblSmall.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmall.Location = new System.Drawing.Point(29, 94);
            this.lblSmall.Name = "lblSmall";
            this.lblSmall.Size = new System.Drawing.Size(114, 30);
            this.lblSmall.TabIndex = 6;
            this.lblSmall.Text = "Small = 1";
            // 
            // lblSizeChoice
            // 
            this.lblSizeChoice.AutoSize = true;
            this.lblSizeChoice.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeChoice.Location = new System.Drawing.Point(29, 46);
            this.lblSizeChoice.Name = "lblSizeChoice";
            this.lblSizeChoice.Size = new System.Drawing.Size(192, 30);
            this.lblSizeChoice.TabIndex = 5;
            this.lblSizeChoice.Text = "Select Pizza Size:";
            // 
            // grbToppings
            // 
            this.grbToppings.Controls.Add(this.nudToppings);
            this.grbToppings.Controls.Add(this.lblToppingsCost);
            this.grbToppings.Controls.Add(this.lbFourToppings);
            this.grbToppings.Controls.Add(this.lblThreeToppings);
            this.grbToppings.Controls.Add(this.lblTwoToppings);
            this.grbToppings.Controls.Add(this.lblOneTopping);
            this.grbToppings.Controls.Add(this.lblToppings);
            this.grbToppings.Location = new System.Drawing.Point(543, 12);
            this.grbToppings.Name = "grbToppings";
            this.grbToppings.Size = new System.Drawing.Size(508, 287);
            this.grbToppings.TabIndex = 10;
            this.grbToppings.TabStop = false;
            this.grbToppings.Text = "Toppings";
            // 
            // txtToppings
            // 
            this.txtToppings.Location = new System.Drawing.Point(985, 378);
            this.txtToppings.Name = "txtToppings";
            this.txtToppings.Size = new System.Drawing.Size(97, 26);
            this.txtToppings.TabIndex = 9;
            // 
            // lblThreeToppings
            // 
            this.lblThreeToppings.AutoSize = true;
            this.lblThreeToppings.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreeToppings.Location = new System.Drawing.Point(29, 193);
            this.lblThreeToppings.Name = "lblThreeToppings";
            this.lblThreeToppings.Size = new System.Drawing.Size(213, 30);
            this.lblThreeToppings.TabIndex = 8;
            this.lblThreeToppings.Text = "three toppings = 3";
            // 
            // lblTwoToppings
            // 
            this.lblTwoToppings.AutoSize = true;
            this.lblTwoToppings.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoToppings.Location = new System.Drawing.Point(29, 146);
            this.lblTwoToppings.Name = "lblTwoToppings";
            this.lblTwoToppings.Size = new System.Drawing.Size(196, 30);
            this.lblTwoToppings.TabIndex = 7;
            this.lblTwoToppings.Text = "two toppings = 2";
            // 
            // lblOneTopping
            // 
            this.lblOneTopping.AutoSize = true;
            this.lblOneTopping.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneTopping.Location = new System.Drawing.Point(29, 94);
            this.lblOneTopping.Name = "lblOneTopping";
            this.lblOneTopping.Size = new System.Drawing.Size(188, 30);
            this.lblOneTopping.TabIndex = 6;
            this.lblOneTopping.Text = "one topping = 1";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(29, 46);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(302, 30);
            this.lblToppings.TabIndex = 5;
            this.lblToppings.Text = "Select amount of toppings:";
            // 
            // lbFourToppings
            // 
            this.lbFourToppings.AutoSize = true;
            this.lbFourToppings.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFourToppings.Location = new System.Drawing.Point(29, 241);
            this.lbFourToppings.Name = "lbFourToppings";
            this.lbFourToppings.Size = new System.Drawing.Size(201, 30);
            this.lbFourToppings.TabIndex = 10;
            this.lbFourToppings.Text = "four toppings = 4";
            // 
            // lblSizeCost
            // 
            this.lblSizeCost.AutoSize = true;
            this.lblSizeCost.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeCost.Location = new System.Drawing.Point(349, 155);
            this.lblSizeCost.Name = "lblSizeCost";
            this.lblSizeCost.Size = new System.Drawing.Size(46, 30);
            this.lblSizeCost.TabIndex = 10;
            this.lblSizeCost.Text = "???";
            // 
            // lblToppingsCost
            // 
            this.lblToppingsCost.AutoSize = true;
            this.lblToppingsCost.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsCost.Location = new System.Drawing.Point(368, 146);
            this.lblToppingsCost.Name = "lblToppingsCost";
            this.lblToppingsCost.Size = new System.Drawing.Size(46, 30);
            this.lblToppingsCost.TabIndex = 11;
            this.lblToppingsCost.Text = "???";
            // 
            // grbDrink
            // 
            this.grbDrink.Controls.Add(this.nudDrink);
            this.grbDrink.Controls.Add(this.lblDrinkCost);
            this.grbDrink.Controls.Add(this.lblNo);
            this.grbDrink.Controls.Add(this.lblYes);
            this.grbDrink.Controls.Add(this.lblDrink);
            this.grbDrink.Location = new System.Drawing.Point(1071, 24);
            this.grbDrink.Name = "grbDrink";
            this.grbDrink.Size = new System.Drawing.Size(458, 275);
            this.grbDrink.TabIndex = 11;
            this.grbDrink.TabStop = false;
            this.grbDrink.Text = "Drink";
            // 
            // lblDrink
            // 
            this.lblDrink.AutoSize = true;
            this.lblDrink.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrink.Location = new System.Drawing.Point(59, 38);
            this.lblDrink.Name = "lblDrink";
            this.lblDrink.Size = new System.Drawing.Size(146, 30);
            this.lblDrink.TabIndex = 0;
            this.lblDrink.Text = "Select Drink:";
            // 
            // txtDrink
            // 
            this.txtDrink.Location = new System.Drawing.Point(985, 498);
            this.txtDrink.Name = "txtDrink";
            this.txtDrink.Size = new System.Drawing.Size(97, 26);
            this.txtDrink.TabIndex = 12;
            // 
            // lblYes
            // 
            this.lblYes.AutoSize = true;
            this.lblYes.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYes.Location = new System.Drawing.Point(59, 95);
            this.lblYes.Name = "lblYes";
            this.lblYes.Size = new System.Drawing.Size(92, 30);
            this.lblYes.TabIndex = 13;
            this.lblYes.Text = "Yes = 1";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(59, 154);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(88, 30);
            this.lblNo.TabIndex = 14;
            this.lblNo.Text = "No = 2";
            // 
            // lblDrinkCost
            // 
            this.lblDrinkCost.AutoSize = true;
            this.lblDrinkCost.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinkCost.Location = new System.Drawing.Point(277, 125);
            this.lblDrinkCost.Name = "lblDrinkCost";
            this.lblDrinkCost.Size = new System.Drawing.Size(46, 30);
            this.lblDrinkCost.TabIndex = 12;
            this.lblDrinkCost.Text = "???";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(127, 419);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(107, 30);
            this.lblSubtotal.TabIndex = 12;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(127, 498);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 30);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total:";
            // 
            // lblHst
            // 
            this.lblHst.AutoSize = true;
            this.lblHst.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHst.Location = new System.Drawing.Point(127, 574);
            this.lblHst.Name = "lblHst";
            this.lblHst.Size = new System.Drawing.Size(61, 30);
            this.lblHst.TabIndex = 14;
            this.lblHst.Text = "HST:";
            // 
            // lblSubtotalC
            // 
            this.lblSubtotalC.AutoSize = true;
            this.lblSubtotalC.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalC.Location = new System.Drawing.Point(292, 419);
            this.lblSubtotalC.Name = "lblSubtotalC";
            this.lblSubtotalC.Size = new System.Drawing.Size(46, 30);
            this.lblSubtotalC.TabIndex = 15;
            this.lblSubtotalC.Text = "???";
            // 
            // lblTotalC
            // 
            this.lblTotalC.AutoSize = true;
            this.lblTotalC.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalC.Location = new System.Drawing.Point(292, 498);
            this.lblTotalC.Name = "lblTotalC";
            this.lblTotalC.Size = new System.Drawing.Size(46, 30);
            this.lblTotalC.TabIndex = 16;
            this.lblTotalC.Text = "???";
            // 
            // lblHstC
            // 
            this.lblHstC.AutoSize = true;
            this.lblHstC.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHstC.Location = new System.Drawing.Point(292, 574);
            this.lblHstC.Name = "lblHstC";
            this.lblHstC.Size = new System.Drawing.Size(46, 30);
            this.lblHstC.TabIndex = 17;
            this.lblHstC.Text = "???";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(662, 408);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(212, 54);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbProvinces
            // 
            this.grbProvinces.Controls.Add(this.radAlberta);
            this.grbProvinces.Controls.Add(this.radOntario);
            this.grbProvinces.Location = new System.Drawing.Point(1276, 574);
            this.grbProvinces.Name = "grbProvinces";
            this.grbProvinces.Size = new System.Drawing.Size(233, 148);
            this.grbProvinces.TabIndex = 19;
            this.grbProvinces.TabStop = false;
            this.grbProvinces.Text = "Provinces";
            // 
            // radOntario
            // 
            this.radOntario.AutoSize = true;
            this.radOntario.Location = new System.Drawing.Point(24, 43);
            this.radOntario.Name = "radOntario";
            this.radOntario.Size = new System.Drawing.Size(86, 24);
            this.radOntario.TabIndex = 0;
            this.radOntario.TabStop = true;
            this.radOntario.Text = "Ontario";
            this.radOntario.UseVisualStyleBackColor = true;
            // 
            // radAlberta
            // 
            this.radAlberta.AutoSize = true;
            this.radAlberta.Location = new System.Drawing.Point(24, 85);
            this.radAlberta.Name = "radAlberta";
            this.radAlberta.Size = new System.Drawing.Size(85, 24);
            this.radAlberta.TabIndex = 1;
            this.radAlberta.TabStop = true;
            this.radAlberta.Text = "Alberta";
            this.radAlberta.UseVisualStyleBackColor = true;
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(308, 50);
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(120, 26);
            this.nudSize.TabIndex = 11;
            // 
            // nudToppings
            // 
            this.nudToppings.Location = new System.Drawing.Point(358, 50);
            this.nudToppings.Name = "nudToppings";
            this.nudToppings.Size = new System.Drawing.Size(120, 26);
            this.nudToppings.TabIndex = 12;
            // 
            // nudDrink
            // 
            this.nudDrink.Location = new System.Drawing.Point(265, 42);
            this.nudDrink.Name = "nudDrink";
            this.nudDrink.Size = new System.Drawing.Size(120, 26);
            this.nudDrink.TabIndex = 20;
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 759);
            this.Controls.Add(this.grbProvinces);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtDrink);
            this.Controls.Add(this.lblHstC);
            this.Controls.Add(this.txtToppings);
            this.Controls.Add(this.lblTotalC);
            this.Controls.Add(this.lblSubtotalC);
            this.Controls.Add(this.lblHst);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.grbDrink);
            this.Controls.Add(this.grbToppings);
            this.Controls.Add(this.grbPizzaSize);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order By Rawaa";
            this.Load += new System.EventHandler(this.frmPizzaOrder_Load);
            this.grbPizzaSize.ResumeLayout(false);
            this.grbPizzaSize.PerformLayout();
            this.grbToppings.ResumeLayout(false);
            this.grbToppings.PerformLayout();
            this.grbDrink.ResumeLayout(false);
            this.grbDrink.PerformLayout();
            this.grbProvinces.ResumeLayout(false);
            this.grbProvinces.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPizzaSize;
        private System.Windows.Forms.Label lblSizeCost;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblXtraLarge;
        private System.Windows.Forms.Label lblLarge;
        private System.Windows.Forms.Label lblSmall;
        private System.Windows.Forms.Label lblSizeChoice;
        private System.Windows.Forms.GroupBox grbToppings;
        private System.Windows.Forms.Label lblToppingsCost;
        private System.Windows.Forms.Label lbFourToppings;
        private System.Windows.Forms.TextBox txtToppings;
        private System.Windows.Forms.Label lblThreeToppings;
        private System.Windows.Forms.Label lblTwoToppings;
        private System.Windows.Forms.Label lblOneTopping;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.GroupBox grbDrink;
        private System.Windows.Forms.Label lblDrinkCost;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblYes;
        private System.Windows.Forms.TextBox txtDrink;
        private System.Windows.Forms.Label lblDrink;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblHst;
        private System.Windows.Forms.Label lblSubtotalC;
        private System.Windows.Forms.Label lblTotalC;
        private System.Windows.Forms.Label lblHstC;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbProvinces;
        private System.Windows.Forms.RadioButton radAlberta;
        private System.Windows.Forms.RadioButton radOntario;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.NumericUpDown nudToppings;
        private System.Windows.Forms.NumericUpDown nudDrink;
    }
}

