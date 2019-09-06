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
            grpSize.Enabled = true;
            grpToppings.Enabled = true;
        }

        private void FrmCurryRestaurant_Load(object sender, EventArgs e)
        {
            optPizza.Checked = false;
        }
    }
}
