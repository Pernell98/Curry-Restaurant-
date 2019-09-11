using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curry_Restaurant
{
    public partial class frmCurryRestaurant : Form
    {
        public frmCurryRestaurant()
        {
            InitializeComponent();
        }

        private void OptPizza_CheckedChanged(object sender, EventArgs e)
        {
            grpPizzaSizes.Enabled = true;
            grpCrust.Enabled = true;
            grpToppings.Enabled = true;
            grpPizzaVariety.Enabled = true;
            grpStuffing.Enabled = true;
        }

        private void FrmCurryRestaurant_Load(object sender, EventArgs e)
        {
            optPizza.Checked = false;
            optPasta.Checked = false;
            optBuritto.Checked = false;
        }

        private void OptPasta_CheckedChanged(object sender, EventArgs e)
        {
            grpPastaVariety.Enabled = true;
            grpSauces.Enabled = true;
            grpAddOn.Enabled = true;
        }

        private void OptBuritto_CheckedChanged(object sender, EventArgs e)
        {
            grpBurittoSizes.Enabled = true;
            grpTypes.Enabled = true;
        }

        private void ChkMedium_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if(optPizza.Checked)
            {
                Pizza pizzaMenu = new Pizza();

                string size = pizzaMenu.pizzaSize(chkSmallPizza.Text);
                string Toppings = pizzaMenu.pizzaToppings(chkPepperoni.Text);
                string Crust = pizzaMenu.pizzaCrust(chkThin.Text);
                string PizzaVariety = pizzaMenu.pizzaVariety(chkBaked.Text);
                string Stuffing = pizzaMenu.pizzaStuffing(chkPlain.Text);
            }

           
        }
    }
}
