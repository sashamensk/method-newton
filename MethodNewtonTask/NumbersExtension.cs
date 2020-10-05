using System;

#pragma warning disable CA1707

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
        /// degree is less than or equal to zero.
        /// -or- 
        /// accuracy is less than zero.
        /// -or- 
        /// accuracy is more than `Epsilon`.
        /// </exception>
        public static double FindNthRoot(double number, int degree, double accuracy)
        {
            if (double.IsInfinity(number) || double.IsNaN(number))
            {
                throw new ArgumentException($"{nameof(number)} is not a valid.");
            }

            if (accuracy < 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(accuracy)} can not be less than zero.");
            }

            if (accuracy > NumbersExtension.AppSettings.Epsilon)
            {
                throw new ArgumentOutOfRangeException($"{nameof(accuracy)} should be less " +
                                                      $"than {nameof(NumbersExtension.AppSettings.Epsilon)}");
            }

            if (degree < 1)
            {
                throw new ArgumentException($"{nameof(degree)} must be positive.");
            }

            if (number < 0.0 && degree % 2 == 0)
            {
                throw new ArgumentException($"It is impossible to calculate an ever {nameof(degree)}" +
                                            $"if {nameof(number)} is negative.");
            }

            double previousApproximation = 1;
            double currentApproximation = (1 / (double)degree) * (((double)(degree - 1) *
                                                                   previousApproximation) + (number / Math.Pow(previousApproximation, degree - 1)));

            while (Math.Abs(currentApproximation - previousApproximation) > accuracy)
            {
                previousApproximation = currentApproximation;
                currentApproximation = (1 / (double)degree) * (((double)(degree - 1) *
                                                                previousApproximation) + (number / Math.Pow(previousApproximation, degree - 1)));
            }

            return currentApproximation;
        }
    }
}