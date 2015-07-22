/**
 * Copyright 2015 Marc Rufer, d-fens GmbH
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

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
