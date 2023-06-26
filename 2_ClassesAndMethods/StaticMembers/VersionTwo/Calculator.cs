using System;

namespace StaticMembers
{
    class Calculator
    {
        public double Pi = 3.14;

        public double Circle(double radius)
        {
            return 2.0 * Pi * radius;
        }

        public double Volume(double radius)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(radius, 3);
        }
    }
}