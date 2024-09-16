using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        [DataTestMethod()]
        [DataRow(0, 5, 5)]
        [DataRow(50, -20, 30)]
        [DataRow(0, 0, 0)]
        [DataRow(-10, -10, -20)]
        public void AddTestInt(int num1, int num2, int expected)
        {
            int result = Calculator.Add(num1, num2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        [DataTestMethod()]
        [DataRow(20.5, 10.5, 31)]
        [DataRow(50.1, -20.1, 30)]
        [DataRow(0, 0, 0)]
        [DataRow(-20.5, -10.4, -30.9)]
        public void AddTestDouble(double num1, double num2, double expected)
        {
            double result = Calculator.Add(num2, num1);
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        [DataTestMethod()]
        [DataRow(20, 10, 10)]
        [DataRow(50, -20, 70)]
        [DataRow(0, 0, 0)]
        [DataRow(-20, -10, -10)]
        public void SubtractTestsInt(int num1, int num2, int expected)
        {
            double result = Calculator.Subtract(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        [DataTestMethod()]
        [DataRow(20.65, 10.65, 10)]
        [DataRow(25.214, 10.553, 14.661)]
        [DataRow(0, 0, 0)]
        [DataRow(10.5, 10, 0.5)]
        [DataRow(-20.456, -10.123, -10.333)]
        public void SubtractTestsDouble(double num1,double num2, double expected)
        {
            double result = Calculator.Subtract(num1, num2);
            Assert.AreEqual(expected, result, 0.0001);
        }
        [TestMethod()]
        [DataTestMethod()]
        [DataRow(100, 10, 1000)]
        [DataRow(0, 1, 0)]
        [DataRow(0, 0, 0)]
        [DataRow(10, 5, 50)]
        [DataRow(-10, 5, -50)]
        [DataRow(-10, -10, 100)]
        public void MultipylTestsInt(int num1, int num2, int expected)
        {
            int result = Calculator.Multiply(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        [DataTestMethod()]
        [DataRow(100.5, 10.1, 1015.05)]
        [DataRow(0, 1.6, 0)]
        [DataRow(0, 0, 0)]
        [DataRow(10.1, 5.15, 52.015)]
        [DataRow(-10.5, 5.10, -53.55)]
        [DataRow(-10, -10, 100)]
        public void MultipylTestsDouble(double num1, double num2, double expected)
        {
            double result = Calculator.Multiply(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        [DataTestMethod()]
        [DataRow(5, 2, 2.5)]
        [DataRow(1, 4, 0.25)]
        [DataRow(10, 3, 3.33333333)]
        [DataRow(50, 10, 5)]
        [DataRow(-10, -20, 0.5)]
        public void DivideTestsDouble(double num1, double num2, double expected)
        {
            double result = Calculator.Divide(num1, num2);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}