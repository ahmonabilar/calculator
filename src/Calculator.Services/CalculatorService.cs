using Calculator.Services.Interfaces;

namespace Calculator.Services
{
    /// <summary>
    /// A service that is used to execute the arithmetic operations
    /// </summary>
    public class CalculatorService: ICalculator
    {
        /// <summary>
        /// Adds first and second parameters
        /// </summary>
        /// <param name="first">First number to be added</param>
        /// <param name="second">Second number to be added</param>
        /// <returns>Sum of first and second number</returns>
        public int Add(int first, int second)
        {
            return first + second;
        }

        /// <summary>
        /// Subtracts first and second parameters
        /// </summary>
        /// <param name="first">Used as the minuend</param>
        /// <param name="second">Used as the subtrahend</param>
        /// <returns>Difference between first and second number</returns>
        public int Subtract(int first, int second)
        {
            return first - second;
        }

        /// <summary>
        /// Multiplies first param by second param
        /// </summary>
        /// <param name="first">Used as the multiplicand</param>
        /// <param name="second">Used as the multiplier</param>
        /// <returns>Product of first and second numbers</returns>
        public int Multiply(int first, int second)
        {
            return first * second;
        }

        /// <summary>
        /// Divides dividend by divisor
        /// </summary>
        /// <param name="dividend">Used as dividend in the divide operation</param>
        /// <param name="divisor">Used as divisor in the divide operation</param>
        /// <returns>Quotient</returns>
        public double Divide(int dividend, int divisor)
        {
            return (double)dividend / divisor;
        }
    }
}
