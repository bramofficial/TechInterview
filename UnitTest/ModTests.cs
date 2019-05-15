using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using modBy;

namespace UnitTest
{
    [TestClass]
    public class ModTests
    {
        [TestMethod]
        public void ModBy_15Case()
        {
            // Unit test the 15 case, aka mod by 3 and 5 should return correctly
            modBy_class mod = new modBy_class();

            // Sending in our input data. 100 upper bounds, 2 pairs, mod by 3, and mod by 5
            using (StringReader sr = new StringReader(string.Format("100{0}2{0}3{0}By 3{0}5{0}By 5{0}", Environment.NewLine)))
            {
                Console.SetIn(sr);
                mod.getValues();
            }

            // the expected value of modding 15 by 3 and 5, using the above input
            string actual = "By 3 By 5 ";
            string[] values = mod.checkMod();

            // verify they are the same in order to pass the test
            Assert.AreEqual(actual, values[14]);

        }
    }
}
