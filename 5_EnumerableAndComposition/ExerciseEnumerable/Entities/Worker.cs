using ExerciseEnumeration.Entities.Enums;
using System.Collections.Generic;

namespace ExerciseEnumeration.Entities
{
    class Worker
    {
        public string Name { get; set;}
        public WorkerLevel Level{ get; set;}
        public double BaseSalary { get; set;}
        public Department Department { get; set;} //Objects in memory: When we instanciated a object with type Worker, it will have this prop associated to then.
        public List<HourContract> Contracts { get; set;} = new List<HourContract>(); //We have multiples contracts by worker, then we create a list with the type with the name of out class 'HourContract' and the instanciate it, to garantie this will not be null.


        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department) //Note that we are not adding the List to the constructor of the object, because it's not usual to pass as a parameter a multiple propriety. The list starts empty, and we will adding object as it's needed.
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}