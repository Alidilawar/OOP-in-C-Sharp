using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
   public class Order
    {
         public string OrderNo { get; set; }
         public string OrderValue { get; set; }
         public string OrderCountry { get; set; }

        public string CreatedOrder()
        {
            ValidateOrderValue();
            ValidateOrderCountry();

            //Order Creation Logic:
            return "Order Created";
        }

        private bool ValidateOrderValue()
        {
            //implementation will go here
            return true;
        }

        private bool ValidateOrderCountry()
        {
            //implementation will go here
            return true;
        }
    }
}
