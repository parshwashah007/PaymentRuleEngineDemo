using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentRuleEngine;

namespace TestPaymentRuleEngine
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader("1");
            Console.SetIn(input);

            Program.Main(new string[] { });

            Assert.AreEqual(string.Format("Choose from below options: \n" +
                                "1. Payment for Physical Product\n" +
                                "2. Payment for Book\n" +
                                "3. Payment for Ski Video\n" +
                                "4. Payment for Membership Activation\n" +
                                "5. Payment for Membership Upgrade{0}" +
                                "New Payment Slip Generated for Shipping{0}" + 
                                "Agent Commission is paid for Shipping{0}", Environment.NewLine), output.ToString());
        }

        [TestMethod]
        public void TestMethod2()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader("2");
            Console.SetIn(input);

            Program.Main(new string[] { });

            Assert.AreEqual(string.Format("Choose from below options: \n" +
                                "1. Payment for Physical Product\n" +
                                "2. Payment for Book\n" +
                                "3. Payment for Ski Video\n" +
                                "4. Payment for Membership Activation\n" +
                                "5. Payment for Membership Upgrade{0}" +
                                "New Payment Slip Generated for Book{0}" +
                                "Duplicate book Payment Slip Generated for Royalty and PaymentID is : 111{0}" +
                                "Agent Commission is paid{0}", Environment.NewLine), output.ToString());
        }

        [TestMethod]
        public void TestMethod3()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader("3");
            Console.SetIn(input);

            Program.Main(new string[] { });

            Assert.AreEqual(string.Format("Choose from below options: \n" +
                                "1. Payment for Physical Product\n" +
                                "2. Payment for Book\n" +
                                "3. Payment for Ski Video\n" +
                                "4. Payment for Membership Activation\n" +
                                "5. Payment for Membership Upgrade{0}" +
                                "New Payment Slip Generated for Video{0}" +
                                "First Aid video is attached{0}", Environment.NewLine), output.ToString());
        }

        [TestMethod]
        public void TestMethod4()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader("4");
            Console.SetIn(input);

            Program.Main(new string[] { });

            Assert.AreEqual(string.Format("Choose from below options: \n" +
                                "1. Payment for Physical Product\n" +
                                "2. Payment for Book\n" +
                                "3. Payment for Ski Video\n" +
                                "4. Payment for Membership Activation\n" +
                                "5. Payment for Membership Upgrade{0}" +
                                "Membership is activated{0}", Environment.NewLine), output.ToString());
        }

        [TestMethod]
        public void TestMethod5()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader("5");
            Console.SetIn(input);

            Program.Main(new string[] { });

            Assert.AreEqual(string.Format("Choose from below options: \n" +
                                "1. Payment for Physical Product\n" +
                                "2. Payment for Book\n" +
                                "3. Payment for Ski Video\n" +
                                "4. Payment for Membership Activation\n" +
                                "5. Payment for Membership Upgrade{0}" +
                                "Membership with ID - 100 is upgraded{0}", Environment.NewLine), output.ToString());
        }
    }
}
