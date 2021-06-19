using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRuleEngine
{
    class ShippingFactory : PaymentFactory
    {
        public override Payment GetPaymentClass()
        {
            return new ShippingPayment();
        }
    }
}
