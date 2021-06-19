using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRuleEngine
{
    class ShippingPayment : Payment
    {
        public override string GeneratePaymentSlip()
        {
            return "New Payment Slip Generated for Shipping";
        }

        public override string GenerateDuplicatePaymentSlip(int paymentID, int OldDeptID)
        {
            return "Duplicate Shipping Payment Slip Generated for PaymentID : " + paymentID;
        }

        public override string AgentCommission()
        {
            return "Agent Commission is paid for Shipping";
        }
    }
}
