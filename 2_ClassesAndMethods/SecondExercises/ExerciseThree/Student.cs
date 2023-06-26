using System;
using System.Globalization;

namespace ExerciseThree
{
    public class Student
    {
        public string Name;
        public double GradeOne, GradeTwo, GradeThree;

        public double FinalGrade()
        {
            return (GradeOne + GradeTwo + GradeThree);
        }

        public bool Aproved()
        {
            if (FinalGrade() >= 60.00)
            {
                return true;
            } else return false;
        }

        public double RemainingScore()
        {
            if (Aproved())
            {
                return 0.0;
            } else return 60.0 - FinalGrade();
        }
    }
}