using System;

namespace Polygons
{
    public class Circle : IPolygon
    {
        /// <summary>
        /// Radius of circle.
        /// </summary>
        public double R { get; }

        /// <summary>
        /// Constructor to create circle instance by radius.
        /// </summary>
        /// <param name="r">Double positive number.</param>
        /// <exception cref="ArgumentException">Is thrown when radius is negative.</exception>
        public Circle(double r)
        {
            if (r < 0)
            {
                throw new ArgumentException("Radius should be positive number.");
            }

            R = r;
        }

        /// <summary>
        /// Method to calculate area of the circle.
        /// </summary>
        /// <returns>Double value of circle area.</returns>
        public double GetArea() => Math.PI * R * R;
    }
}