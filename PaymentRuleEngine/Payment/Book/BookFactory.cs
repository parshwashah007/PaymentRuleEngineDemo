using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRuleEngine
{
    class BookFactory : PaymentFactory
    {
        public override Payment GetPaymentClass()
        {
            return new BookPayment();
        }
    }
}