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
            grpPastaVariety.Enabled = false;
            grpSauces.Enabled = false;
            grpAddOn.Enabled = false;
            grpBurritoSizes.Enabled = false;
            grpBurritoTypes.Enabled = false;
        }

        private void FrmCurryRestaurant_Load(object sender, EventArgs e)
        {
            optPizza.Checked = false;
            optPasta.Checked = false;
            optBurrito.Checked = false;
        }

        private void OptPasta_CheckedChanged(object sender, EventArgs e)
        {
            grpPizzaSizes.Enabled = false;
            grpCrust.Enabled = false;
            grpToppings.Enabled = false;
            grpPizzaVariety.Enabled = false;
            grpStuffing.Enabled = false;
            grpPastaVariety.Enabled = true;
            grpSauces.Enabled = true;
            grpAddOn.Enabled = true;
            grpBurritoSizes.Enabled = false;
            grpBurritoTypes.Enabled = false;
        }

        private void OptBuritto_CheckedChanged(object sender, EventArgs e)
        {
            grpPizzaSizes.Enabled = false;
            grpCrust.Enabled = false;
            grpToppings.Enabled = false;
            grpPizzaVariety.Enabled = false;
            grpStuffing.Enabled = false;
            grpPastaVariety.Enabled = false;
            grpSauces.Enabled = false;
            grpAddOn.Enabled = false;
            grpBurritoSizes.Enabled = true;
            grpBurritoTypes.Enabled = true;
        }

        private void ChkMedium_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (optPizza.Checked)
            {
                Pizza menu = new Pizza();

                string pizzaSize = menu.pizzaSize(size());
                string pizzaToppings = menu.pizzaToppings(toppings());
                string pizzaCrust = menu.pizzaCrust(crust());
                string pizzaVariety = menu.pizzaVariety(variety());
                string pizzaStuffing = menu.pizzaStuffing(stuffing());

                txtDisplayOrder.Text = "your order of a " + pizzaSize + " with " + pizzaToppings + ", " + pizzaCrust + ", " + pizzaVariety + " and " + pizzaStuffing + " will be right out";

            }
            else if (optPasta.Checked)
            {
                Pasta menu = new Pasta();

                string pastaVariety = menu.PastaVariety(varietyPasta());
                string pastaSauce = menu.sauces(pastaSauces());
                string pastaAddOn = menu.addOn(AddOnPasta());

                txtDisplayOrder.Text = "You order of " + pastaVariety + " with " + pastaSauce + " and " + pastaAddOn + " will be right out";
            }

            else 
            {
                Burrito menu = new Burrito();

                string size = menu.burritoSizes(burritoSizes());
                string types = menu.burritotypes(burritoTypes());

                txtDisplayOrder.Text = "Your order of a " + size + " " + types + " will be right out";
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
        private string varietyPasta()
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

        private string pastaSauces()
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

        private string AddOnPasta()
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

        //Burritos
        private string burritoSizes()
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

        private string burritoTypes()
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplayOrder.Clear();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
