using System;
using System.Collections.Generic;
using FindString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.FindString
{
    [TestClass]
    public class LineWithElementTest
    {
        [TestMethod]
        public void CalculatedSumCorrectValue()
        {
            var list = new LineWithElements("1.1,2,3", 1);
            var expect = 6.1;
            list.CalculatedSum();
            Assert.AreEqual(list.SumOfElements, expect);
        }
        [TestMethod]
        public void CalculatedSumFromIncorectFormatReturnNull()
        {
            var list = new LineWithElements("1.1,2A,3", 1);
            var expect = 6.1;
            list.CalculatedSum();
            Assert.IsNull(list.SumOfElements);
        }
    }
}
