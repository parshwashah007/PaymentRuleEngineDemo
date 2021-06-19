using System;

namespace PaymentRuleEngine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PaymentFactory factory = null;
            Console.WriteLine("Choose from below options: \n" +
                                "1. Payment for Physical Product\n" +
                                "2. Payment for Book\n" +
                                "3. Payment for Ski Video\n" +
                                "4. Payment for Membership Activation\n" +
                                "5. Payment for Membership Upgrade");
            string option = Console.ReadLine();
            Payment p = null;
            Membership m = null;

            switch (option)
            {
                case "1":
                    factory = new ShippingFactory();
                    p = factory.GetPaymentClass();
                    Console.WriteLine(p.GeneratePaymentSlip());
                    Console.WriteLine(p.AgentCommission());
                    break;
                case "2":
                    factory = new BookFactory();
                    p = factory.GetPaymentClass();
                    Console.WriteLine(p.GeneratePaymentSlip());
                    Console.WriteLine(p.GenerateDuplicatePaymentSlip(111, 1));
                    Console.WriteLine(p.AgentCommission());
                    break;
                case "3":
                    factory = new VideoFactory();
                    p = factory.GetPaymentClass();
                    Console.WriteLine(p.GeneratePaymentSlip());
                    Console.WriteLine(p.attachFirstAidVideo());
                    break;
                case "4":
                    m = new Membership();
                    Console.WriteLine(m.ActivateUpgradeMembership());
                    break;
                case "5":
                    m = new Membership();
                    Console.WriteLine(m.ActivateUpgradeMembership(100));
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
