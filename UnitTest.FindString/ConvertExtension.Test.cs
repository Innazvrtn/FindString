using FindString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace UnitTest.FindString
{
    [TestClass]
    public class ConvertExtensionTest
    {
        [TestMethod]
        public void ConvertToDoubleCheckForTypeCorrectType()
        {
            var list = "1.1,2,3";
            var result = list.ConvertToDouble();
            Assert.IsInstanceOfType(result, typeof(List<double>));
        }

        [TestMethod]
        public void ConvertToDoubleCheckForValueCorrectValue()
        {
            var list = "1.1,2,3";
            var expect = new List<double> { 1.1, 2, 3 };
            var result = list.ConvertToDouble();
            CollectionAssert.AreEqual(result, expect);
        }

        [TestMethod]
        public void ConvertToDoubleCheckForIncorectFormatReturnNull()
        {
            var list = "1.1A,2,3";
            var result = list.ConvertToDouble();
            Assert.IsNull(result);
        }
    }
}
