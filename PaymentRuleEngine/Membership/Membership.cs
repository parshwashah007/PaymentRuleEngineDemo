using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRuleEngine
{
    class Membership
    {
        public string ActivateUpgradeMembership(int id = 0)
        {
            EmailSender es = new EmailSender();
            if (id == 0)
            {
                es.sendEmail("Membership Activation");
                return "Membership is activated";
            }
            else
            {
                es.sendEmail("Membership Upgrade");
                return "Membership with ID - " + id + " is upgraded";
            }
        }
    }
}
