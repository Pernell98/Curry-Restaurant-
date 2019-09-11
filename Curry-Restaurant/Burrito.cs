using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curry_Restaurant
{
    class Burrito
    {
        public Burrito()
        {

        }

        public string sizes(string sizes)
        {
            if(sizes.Equals("petit"))
            {
                return sizes;
            }
            else if(sizes.Equals("average"))
            {
                return sizes;
            }
            else
            {
                return sizes;
            }
        }

        public string types(string types)
        {
            if(types.Equals("machaca"))
            {
                return types;
            }
            else if(types.Equals("polo"))
            {
                return types;
            }
            else
            {
                return types;
            }
        }
    }
}
