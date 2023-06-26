using System;

namespace ClassesAndMethods{
    public class Rectangle
    {
        public double Base;
        public double Height;

        public double Area()
        {
            return Base * Height;
        }

        public double Perimeter()
        {
            return 2*(Base + Height);
        }

        public double Diagonal()
        {
           return Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Height, 2)); 
        }
    }
}