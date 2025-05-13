using System;

namespace ShapeLibrary
{
    public class Triangle : IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("All sides must be positive");

            if (!IsValidTriangle(sideA, sideB, sideC))
                throw new ArgumentException("Invalid triangle: sum of any two sides must be greater than the third side");

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double CalculateArea()
        {
            // Using Heron's formula
            double s = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
        }

        public bool IsRightTriangle()
        {
            // Using Pythagorean theorem
            double[] sides = { _sideA, _sideB, _sideC };
            Array.Sort(sides);
            
            // Check if a² + b² = c² (with some tolerance for floating-point arithmetic)
            return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 1e-10;
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
} 