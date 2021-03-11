using System;

namespace MethodNewtonTask
{
    public static class NumbersExtension
    {
        /// <summary>
        /// Initializes static members of the <see cref="NumbersExtension"/> class.
        /// </summary>
        public static readonly AppSettings AppSettings = new AppSettings { Epsilon = double.Epsilon };

        /// <summary>
        /// Find n-th root of number with the given accuracy.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <param name="degree">Root degree.</param>
        /// <param name="accuracy">Accuracy value.</param>
        /// <returns> n-th root of number.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when number is negative and n degree is even.
        /// -or- 
        /// degree is less than zero
        /// -or-
        /// number is NaN, double.NegativeInfinity, double.PositiveInfinity.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when accuracy is less than zero.
        /// -or- 
        /// accuracy is more than `Epsilon`.
        /// </exception>
        public static double FindNthRoot(double number, int degree, double accuracy)
        {
            if (number < 0 && degree % 2 == 0)
            {
                throw new ArgumentException($"{nameof(number)}  is less than zero and degreee is even");
            }

            if (degree < 0)
            {
                throw new ArgumentException($"{nameof(degree)} is less than zero");
            }

            if (double.IsNaN(number) || double.IsInfinity(number))
            {
                throw new ArgumentException($"{nameof(number)} is NaN, double.NegativeInfinity, double.PositiveInfinity");
            }

            if (accuracy < 0 || accuracy > AppSettings.Epsilon)
            {
                throw new ArgumentOutOfRangeException($"{nameof(accuracy)}");
            }

            Random rand = new Random();
            double temp = rand.Next(10);
            double intMax = 2147483647;
            double nnthRoot = 0.0;
            while (intMax > accuracy)
            {
                nnthRoot = (((degree - 1.0) * temp) + (number / Math.Pow(temp, degree - 1))) / (double)degree;
                intMax = Math.Abs(nnthRoot - temp);
                temp = nnthRoot;
            }

            return nnthRoot;
        }
    }    
}
