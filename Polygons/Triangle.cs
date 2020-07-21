using System;

namespace Polygons
{
    public class Triangle : IPolygon
    {
        /// <summary>
        /// First side of triangle.
        /// </summary>
        public double A { get; }
        /// <summary>
        /// Second side of triangle.
        /// </summary>
        public double B { get; }
        /// <summary>
        /// Third side of triangle.
        /// </summary>
        public double C { get; }

        /// <summary>
        /// 
        /// </summary>
        private readonly Lazy<bool> _isRight;

        /// <summary>
        /// 
        /// </summary>
        public bool IsRight => _isRight.Value;

        /// <summary>
        /// Constructor to create triangle instance by two legs and hypotenuse.
        /// </summary>
        /// <param name="a">Double positive number.</param>
        /// <param name="b">Double positive number.</param>
        /// <param name="c">Double positive number.</param>
        /// <exception cref="ArgumentException">Is thrown when triangle with such sides does not exist
        /// or if one or more sides are negative.</exception>
        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("Sides should be positive numbers.");
            }
            
            if (!Exists(a, b, c))
            {
                throw new ArgumentException("Triangle with such sides does not exist.");
            }
            
            A = a;
            B = b;
            C = c;

            // Supposing A and B are legs of triangle.
            _isRight = new Lazy<bool>(CheckIfIsRight);
        }

        /// <summary>
        /// Help method to check whether triangle is right or not.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>True if triangle with such sides exists, else – false.</returns>
        private static bool Exists(double a, double b, double c) => a + b > c && a + c > b && b + c > a;

        private bool CheckIfIsRight() =>
            Math.Abs(Math.Pow(A, 2) + Math.Pow(B, 2) - Math.Pow(C, 2)) < double.Epsilon ||
            Math.Abs(Math.Pow(B, 2) + Math.Pow(C, 2) - Math.Pow(A, 2)) < double.Epsilon ||
            Math.Abs(Math.Pow(A, 2) + Math.Pow(C, 2) - Math.Pow(B, 2)) < double.Epsilon;

        /// <summary>
        /// Method to calculate area of triangle.
        /// </summary>
        /// <returns>Double value of triangle area.</returns>
        public double GetArea()
        {
            if (IsRight)
            {
                return 0.5 * A * B;
            }

            // semi-perimeter
            var p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}