using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curry_Restaurant
{
    class Pizza
    {
        private string size;
        public Pizza()
        {

        }
        public string pizzaSize(string text )
        {
            if (text.Equals("Small"))
            {
                return size = "Small";
            }
            else if (text.Equals("Medium"))
            {
                return size = "Meduim";
            }
            else
            {
                return size = "Large";
            }
        }

        public string pizzaToppings(string toppings)
        {
            if (toppings.Equals("sausage"))
            {
                return toppings;
            }
            else if (toppings.Equals("bacon"))
            {
                return toppings;
            }
            else
            {
                return toppings;
            }
        }

        public string pizzaCrust(string crust)
        {
            if (crust.Equals("Thin Crust"))
            {
                return crust;
            }
            else if (crust.Equals("Thick Crust"))
            {
                return crust;
            }
            else
            {
                return crust;
            }

        }

        public string pizzaVariety(string variety)
        {
            if (variety.Equals("baked"))
            {
                return variety;
            }
            else
            {
                return variety;
            }
        }

        public string pizzaStuffing(string stuffing)
        {
            if (stuffing.Equals("plain"))
            {
                return stuffing;
            }
            else if (stuffing.Equals("cheese coated"))
            {
                return stuffing;
            }
            else
            {
                return stuffing;
            }
        }

    }
}