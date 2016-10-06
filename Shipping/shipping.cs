using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shippingnamespace
{
    public class shipping
    {
        private decimal standard_rate;
        private decimal overnight_rate;
        private decimal total_charge;

        public shipping()
        {
            standard_rate = 20.0m;
            overnight_rate = 50.00m;
        }

        public decimal Total_Charges(decimal tp)
        {
            if (tp >= 25 && tp <= 99)
            {
                total_charge = (standard_rate + tp) - (0.05m * (standard_rate + tp));
            }
            else if (tp >= 50 && tp <= 99)

            { total_charge = (standard_rate + tp) - (0.1m * (standard_rate + tp));
        }
        else if (tp >= 100)
            {total_charge = tp;}
    else
    { total_charge = standard_rate + tp; }

            return total_charge;
    }
    


        public decimal Add_Overnight(decimal tp)
        {
    total_charge = overnight_rate + tp;
    return total_charge;
        }
    }
}
