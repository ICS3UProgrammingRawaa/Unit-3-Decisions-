/*
 * Created by: Rawaa Al Ghanai
 * Created on: April 13, 2020
 * Created for: ICS3U Programming
 * Assignment #5b - Pizza Order
 * This program gives the user the choice of pizza sizes, toppings, and drink.
 * It also gives an option of different tax values in different provinces.
 * It then calculates the subtotal, HST, and total for the order. 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderRawaa
{
    public partial class frmPizzaOrder : Form
    {

        public frmPizzaOrder()
        {
            InitializeComponent();
            // hide labels 
            this.lblToppingsCost.Hide();
            this.lblDrinkCost.Hide();
            this.lblSizeCost.Hide();
            this.lblHstC.Hide();
            this.lblHst.Hide();
            this.lblSubtotalC.Hide();
            this.lblSubtotal.Hide();
            this.lblTotalC.Hide();
            this.lblTotal.Hide();

            // hide unwanted textboxes 
            this.txtDrink.Hide();
            this.txtSize.Hide();
            this.txtToppings.Hide();

            // declare constants
            const double SMALLPIZZA = 4.99;
            const double LARGEPIZZA = 9.99;
            const double XTRALARGEPIZZA = 12.99;
            const double ONETOPPING = 0.75;
            const double TWOTOPPINGS = 1.35;
            const double THREETOPPINGS = 2.15;
            const double FOURTOPPINGS = 2.75;
            const double YESDRINK = 2.99;
            const double NODRINK = 0.00;
            const double ALBERTATAX = 0.05;
            const double ONTARIOTAX = 0.13;

            double subtotal = 0;
            double total = 0;
            double HST = 0;
        }

        private void frmPizzaOrder_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declare constants
            const double SMALLPIZZA = 4.99;
            const double LARGEPIZZA = 9.99;
            const double XTRALARGEPIZZA = 12.99;
            const double ONETOPPING = 0.75;
            const double TWOTOPPINGS = 1.35;
            const double THREETOPPINGS = 2.15;
            const double FOURTOPPINGS = 2.75;
            const double YESDRINK = 2.99;
            const double NODRINK = 0.00;
            const double ALBERTATAX = 0.05;
            const double ONTARIOTAX = 0.13;

            double subtotal = 0;
            double total = 0;
            double HST = 0;

            // declare variables 
            double pizzaSize, toppings, drink, pizzaCost, toppingCost, drinkCost;

            pizzaSize = double.Parse(nudSize.Text);
            toppings = double.Parse(nudToppings.Text);
            drink = double.Parse(nudDrink.Text);

            // variables
            pizzaCost = 0;
            toppingCost = 0;
            drinkCost = 0;
            

            // get size of pizza 
            if (pizzaSize==1)
            {
                pizzaCost = SMALLPIZZA;
                lblSizeCost.Text = Convert.ToString(pizzaCost);
                lblSizeCost.Text = String.Format("${0:0.00}", pizzaCost);
                this.lblSizeCost.Show(); 
            }
            else if (pizzaSize==2)
            {
                pizzaCost = LARGEPIZZA;
                lblSizeCost.Text = Convert.ToString(pizzaCost);
                lblSizeCost.Text = String.Format("${0:0.00}", pizzaCost);
                this.lblSizeCost.Show();
            }
            else if (pizzaCost == 3)
            {
                pizzaCost = XTRALARGEPIZZA;
                lblSizeCost.Text = Convert.ToString(pizzaCost);
                lblSizeCost.Text = String.Format("${0:0.00}", pizzaCost);
                this.lblSizeCost.Show();
            }
            // get the number of toppings 
            if (toppings == 1)
            {
                toppingCost = ONETOPPING;
                lblToppingsCost.Text = Convert.ToString(toppingCost);
                lblToppingsCost.Text = String.Format("${0:0.00}", toppingCost);
                this.lblToppingsCost.Show();
            }
            else if (toppings == 2)
            {
                toppingCost = TWOTOPPINGS;
                lblToppingsCost.Text = Convert.ToString(toppingCost);
                lblToppingsCost.Text = String.Format("${0:0.00}", toppingCost);
                this.lblToppingsCost.Show();
            }
            else if (toppings == 3)
            {
                toppingCost = THREETOPPINGS;
                lblToppingsCost.Text = Convert.ToString(toppingCost);
                lblToppingsCost.Text = String.Format("${0:0.00}", toppingCost);
                this.lblToppingsCost.Show();
            }
            else if (toppings == 4)
            {
                toppingCost = FOURTOPPINGS;
                lblToppingsCost.Text = Convert.ToString(toppingCost);
                lblToppingsCost.Text = String.Format("${0:0.00}", toppingCost);
                this.lblToppingsCost.Show();
            }
            // get if user wants to get a drink
            if (drink == 1)
            {
                drinkCost = YESDRINK;
                lblDrinkCost.Text = Convert.ToString(drinkCost);
                lblDrinkCost.Text = String.Format("${0:0.00}", drinkCost);
                this.lblDrinkCost.Show();
            }
            else if (drink == 2)
            {
                drinkCost = NODRINK;
                lblDrinkCost.Text = Convert.ToString(drinkCost);
                lblDrinkCost.Text = String.Format("${0:0.00}", drinkCost);
                this.lblDrinkCost.Show();
            }
            // calculate subtotal 
            subtotal = pizzaCost + toppingCost + drinkCost;
            lblSubtotalC.Text = Convert.ToString(subtotal);
            lblSubtotalC.Text = String.Format("${0:0.00}", subtotal);
            this.lblSubtotalC.Show();
            this.lblSubtotal.Show();

            // get the user's province and calculate tax
            if (radOntario.Checked == true)
            {
                HST = ONTARIOTAX * subtotal;
                lblHstC.Text = Convert.ToString(HST);
                lblHstC.Text = String.Format("${0:0.00}", HST);
                this.lblHstC.Show();
                this.lblHst.Show();
            }
            else if(radAlberta.Checked == true)
            {
                HST = ALBERTATAX * subtotal;
                lblHstC.Text = Convert.ToString(HST);
                lblHstC.Text = String.Format("${0:0.00}", HST);
                this.lblHstC.Show();
                this.lblHst.Show();
            }
            // calculate total 
            total = subtotal + HST;
            lblTotalC.Text = Convert.ToString(total);
            lblTotalC.Text = String.Format("${0:0.00}", total);
            this.lblTotalC.Show();
            this.lblTotal.Show();
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void grbPizzaSize_Enter(object sender, EventArgs e)
        {

        }
    }
}
