using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRuleEngine
{
    abstract class Payment : ICommission, IFirstAidVideo
    {
        public abstract string GeneratePaymentSlip();
        public abstract string GenerateDuplicatePaymentSlip(int paymentID, int OldDeptID);

        public virtual string AgentCommission()
        {
            return "Agent Commission is paid";
        }

        public string attachFirstAidVideo()
        {
            return "First Aid video is attached";
        }
    }
}
