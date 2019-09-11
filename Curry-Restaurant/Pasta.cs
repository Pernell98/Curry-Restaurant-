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

        public string variety(string variety)
        {
            if(variety.Equals("spaghetti"))
            {
                return variety;
            }
            else if(variety.Equals("angel hair"))
            {
                return variety;
            }
            else
            {
                return variety;

            }
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
