using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace biz.dfch.CS.Development.Process.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddReturnsSumOfTwoNumbers()
        {
            Assert.AreEqual(15, Calculator.add(7, 8));
        }

        [TestMethod]
        public void SubractReturnsDifferenceOfTheTwoPassedNumbers()
        {
            Assert.AreEqual(2, Calculator.subtract(10, 8));
        }
    }
}
