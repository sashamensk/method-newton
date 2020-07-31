using System;

namespace MethodNewtonTask
{
    public static class NumbersExtension
    {
        public static readonly AppSettings AppSettings;

        /// <summary>
        /// Initializes static members of the <see cref="NumbersExtension"/> class.
        /// </summary>
        static NumbersExtension() => AppSettings = new AppSettings { Epsilon = 0.1 };

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
        /// degree is less than or equal to zero.
        /// -or- 
        /// accuracy is less than zero.
        /// -or- 
        /// accuracy is more than `Epsilon`.
        /// </exception>
        public static double FindNthRoot(double number, int degree, double accuracy)
        {
            throw new NotImplementedException("You need to implement this method.");
        }
    }
}