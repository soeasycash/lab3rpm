using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3rpm
{
    abstract class Triangle
    {
        protected double SideA;
        protected double SideB;
        protected double AngleAB;

        public Triangle(double sideA, double sideB, double angleAB)
        {
            SideA = sideA;
            SideB = sideB;
            AngleAB = angleAB;
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
    class RightTriangle : Triangle
    {
        public RightTriangle(double sideA, double sideB) : base(sideA, sideB, 90) { }

        public override double CalculateArea()
        {
            return 0.5 * SideA * SideB;
        }

        public override double CalculatePerimeter()
        {
            return SideA + SideB + Math.Sqrt(SideA * SideA + SideB * SideB);
        }
    }

    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double side, double baseAngle) : base(side, side, baseAngle) { }

        public override double CalculateArea()
        {
            return 0.5 * SideA * SideA * Math.Sin(AngleAB);
        }

        public override double CalculatePerimeter()
        {
            return 2 * SideA + SideA * Math.Sin(AngleAB);
        }
    }

    class EquilateralTriangle : IsoscelesTriangle
    {
        public EquilateralTriangle(double side) : base(side, 60) { }

        public override double CalculateArea()
        {
            double n = SideA*Math.Sqrt(3)/2;
            return SideA * n / 2;
        }

        public override double CalculatePerimeter()
        {
            return SideA + SideA + SideA;
        }
    }

}
