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
                Pizza menu = new Pizza();

                string  pizzaSize  = menu.pizzaSize(size());
                string pizzaToppings = menu.pizzaToppings(toppings());
                string pizzaCrust = menu.pizzaCrust(crust());
                string pizzaVariety = menu.pizzaVariety(variety());
                string pizzaStuffing = menu.pizzaStuffing(stuffing());
                string pastaVariety = menu.
                
            }
           
        }

        //pizza
        private string size()
        {
            if (chkSmallPizza.Checked)
            {
                return chkSmallPizza.Text;
            }
            else if (chkMedium.Checked)
            {
                return chkMedium.Text;
            }
            else
                return chkLarge.Text;
        }

        private string toppings()
        {
            if (chkPepperoni.Checked)
            {
                return chkPepperoni.Text;
            }
            else if (chkOlives.Checked)
            {
                return chkOlives.Text;
            }
            else
                return chkMushroom.Text;
        }

        private string crust()
        {
            if (chkThin.Checked)
            {
                return chkThin.Text;
            }
            else if (chkThick.Checked)
            {
                return chkThick.Text;
            }
            else
                return chkStuffed.Text;
        }

        private string variety()
        {
            if (chkBaked.Checked)
            {
                return chkBaked.Text;
            }
            else 
            {
                return chkBrownedTop.Text;
            }

        }

        private string stuffing()
        {
            if (chkPlain.Checked)
            {
                return chkPlain.Text;
            }
            else if (chkCheesyCoating.Checked)
            {
                return chkCheesyCoating.Text;
            }
            else
                return chkCheeseStuffed.Text;
        }

        //pasta
        private string pastaVariety()
        {
            if (chkSpaghetti.Checked)
            {
                return chkSpaghetti.Text;
            }
            else if (chkAngelHair.Checked)
            {
                return chkAngelHair.Text;
            }
            else if (chkRigatoniStuffed.Checked)
            {
                return chkRigatoniStuffed.Text;
            }
            else if (chkRigatoniBeef.Checked)
            {
                return chkRigatoniBeef.Text;
            }
            else if (chkRigatoniSausage.Checked)
            {
                return chkRigatoniSausage.Text;
            }
            else
                return chkRigatoniCheese.Text;
        }

        private string Sauces()
        {
            if (chkRed.Checked)
            {
                return chkRed.Text;
            }
            else
            {
                return chkWhite.Text;
            }

        }

        private string AddOn()
        {
            if (chkPlainAdd.Checked)
            {
                return chkPlainAdd.Text;
            }
            else if (chkMeatballs.Checked)
            {
                return chkMeatballs.Text;
            }
            else
                return chkSausage.Text;
        }

        //Burrittos
        private string BurrittoSizes()
        {
            if (chkPetite.Checked)
            {
                return chkPetite.Text;
            }
            else if (chkAverage.Checked)
            {
                return chkAverage.Text;
            }
            else
                return chkHumongous.Text;
        }

        private string Types()
        {
            if (chkMachaca.Checked)
            {
                return chkMachaca.Text;
            }
            else if (chkPolo.Checked)
            {
                return chkPolo.Text;
            }
            else
                return chkVegetarian.Text;
        }
    }
}
