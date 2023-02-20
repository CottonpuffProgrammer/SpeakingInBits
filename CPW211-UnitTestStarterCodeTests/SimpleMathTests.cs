using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Use the DataRow values to test the Add method
            double expectedResult = num1 + num2;

            double returnedResult = SimpleMath.Add(num1, num2);

            Assert.AreEqual(expectedResult, returnedResult);
        }

        [TestMethod]
        [DataRow(3, 2)]
        [DataRow(66, 7)]
        [DataRow(-88, -9)]
        [DataRow(0, -1)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            // Use a few pairs of values to test the Multiply method
            double expectedResult = num1 * num2;

            double returnedResult = SimpleMath.Multiply(num1, num2);

            Assert.AreEqual(expectedResult, returnedResult);
        }

        [TestMethod]
        [DataRow(58, 0)]
        [DataRow(4, 0)]
        [DataRow(-1000000, 0)]
        [DataRow(32345, 0)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            Assert.ThrowsException<ArgumentException>
                (() => SimpleMath.Divide(num1, num2));
        }

        // The TODO asks for essentially the same test for two 
        // different methods, looks slightly redundant but tests 
        // what it needs to test

        // TODO: Test Divide method with two valid 
        [TestMethod]
        [DataRow(3, 8888)]
        [DataRow(5, 95)]
        [DataRow(6, -80)]
        [DataRow(4, -7)]
        public void Divide_TwoNumbers_SuccessfulDivision(double num1, double num2)
        {
            double expectedResult = num1 / num2;

            double returnedResult = SimpleMath.Divide(num1, num2);

            Assert.AreEqual(expectedResult, returnedResult);
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(8, 6)]
        [DataRow(-2, 7)]
        [DataRow(15, -9)]
        [DataRow(3, -107)]
        public void Subtract_TwoNumbers_SuccessfulSubtraction(double num1, double num2)
        {
            double expectedResult = num1 - num2;

            double returnedResult = SimpleMath.Subtract(num1, num2);

            Assert.AreEqual(expectedResult, returnedResult);
        }
    }
}