using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRuleEngine
{
    class VideoPayment : Payment
    {
        public override string GeneratePaymentSlip()
        {
            return "New Payment Slip Generated for Video";
        }

        public override string GenerateDuplicatePaymentSlip(int paymentID, int OldDeptID)
        {
            return "Duplicate Video Payment Slip Generated for PaymentID : " + paymentID;
        }
    }
}
