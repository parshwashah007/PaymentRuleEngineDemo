using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRuleEngine
{
    class EmailSender
    {
        public string sendEmail(string subject)
        {
            return "Email has been sent for the " + subject;
        }
    }
}
