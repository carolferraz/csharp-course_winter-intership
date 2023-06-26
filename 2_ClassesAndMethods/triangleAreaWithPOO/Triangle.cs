//Dependecy import
using System;

//Class namespace
namespace triangleAreaWithPOO
{
    // Class name
    class Triangle
    {

        //Class fields 
        //The access modifier defined as "public" indicate that the fields and methods can be used in other archives.
        public double A;
        public double B;
        public double C;

        //Class method
        // The type of a method indicate the type of data it will be return. In this case: double. If it don't return anything we may use "void".
        public double Area()
        {
            //Method body
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}