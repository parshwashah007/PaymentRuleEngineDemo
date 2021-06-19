using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRuleEngine
{
    abstract class PaymentFactory
    {
        public abstract Payment GetPaymentClass();
    }
}
