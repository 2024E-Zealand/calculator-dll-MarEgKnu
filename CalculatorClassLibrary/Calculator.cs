using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary
{
    /// <summary>
    /// Class library for calculating operations
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Adds two whole numbers together
        /// </summary>
        /// <param name="x">Number 1 to add</param>
        /// <param name="y">Number 2 to add</param>
        /// <returns>The result of the addition</returns>
        public static int Add(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Adds decimal numbers together
        /// </summary>
        /// <param name="x">Number 1 to add</param>
        /// <param name="y">Number 2 to add</param>
        /// <returns>The result of the addition</returns>
        public static double Add(double x, double y)
        {
            return x + y;
        }
        /// <summary>
        /// Subtracts two whole numbers from eachother
        /// </summary>
        /// <param name="x">The number to subtract from</param>
        /// <param name="y">The number that will be subtracted from x</param>
        /// <returns></returns>
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        /// <summary>
        /// Subtracts decimal numbers from eachother
        /// </summary>
        /// <param name="x">The number to subtract from</param>
        /// <param name="y">The number that will be subtracted from x</param>
        /// <returns></returns>
        public static double Subtract(double x, double y)
        {
            return x - y;
        }
        /// <summary>
        /// Multiplies two whole numbers
        /// </summary>
        /// <param name="x">Number 1 to multiply</param>
        /// <param name="y">Number 2 to multiply</param>
        /// <returns></returns>
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        /// <summary>
        /// Multiplies decimal numbers
        /// </summary>
        /// <param name="x">Number 1 to multiply</param>
        /// <param name="y">Number 2 to multiply</param>
        /// <returns></returns>
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
        /// <summary>
        /// Divides decimal numbers
        /// </summary>
        /// <param name="x">Number to be divided</param>
        /// <param name="y">Number to divide by</param>
        /// <returns></returns>
        public static double Divide(double x, double y)
        {
            return x / y;
        }
    }
}
