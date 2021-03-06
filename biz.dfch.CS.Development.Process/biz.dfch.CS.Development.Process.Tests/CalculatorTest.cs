﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace biz.dfch.CS.Development.Process.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddReturnsSumOfTwoNumbers()
        {
            Assert.AreEqual(15, Calculator.Add(7, 8));
        }

        [TestMethod]
        public void SubractReturnsDifferenceOfTheTwoPassedNumbers()
        {
            Assert.AreEqual(2, Calculator.Subtract(10, 8));
        }

        [TestMethod]
        public void DivideReturnsQuotientOfTheTwoPassedNumbers()
        {
            Assert.AreEqual(5, Calculator.Divide(10, 2));
        }

        [TestMethod]
        public void MultiplyReturnsProductOfTheTwoPassedNumbers()
        {
            Assert.AreEqual(50, Calculator.Multiply(10, 5));
        }
    }
}
