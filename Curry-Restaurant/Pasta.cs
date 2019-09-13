using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curry_Restaurant
{
    class Pasta
    {
        public Pasta()
        {

        }

        public string PastaVariety(string variety)
        {
            if (variety.Equals("Spaghetti"))
            {
                return "Spaghetti";
            }
            else if (variety.Equals("Angel Hair"))
            {
                return "Angel Hair";
            }
            else if (variety.Equals("Rigatoni Stuffed"))
            {
                return "Rigatoni Stuffed";
            }
            else if (variety.Equals("Rigatoni Beef"))
            {
                return "Rigatoni Beef";
            }
            else if (variety.Equals("Rigatoni Sausage"))
            {
                return "Rigatoni Sausage";
            }
            else
                return "Rigatoni Cheese";
        }

        public string meat(string meat)
        {
            if(meat.Equals("italian beef"))
            {
                return meat;
            }
            else if(meat.Equals("italian sausage"))
            {
                return meat;
            }
            else
            {
                return meat;
            }
        }

        public string sauces(string sauces)
        {
            if(sauces.Equals("read"))
            {
                return sauces;
            }
            else
            {
                return sauces;
            }
        }

        public string addOn(string addOn)
        {
            if(addOn.Equals("plain"))
            {
                return addOn;
            }
            else if(addOn.Equals("meatballs"))
            {
                return addOn;
            }
            else
            {
                return addOn;
            }
        }


    }
}
