using ExercisesCore.Ex_WorkerContracts.Enums;
using System.Collections.Generic;

namespace ExercisesCore.Ex_WorkerContracts.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        private List<HourContract> Contracts = new List<HourContract>();

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
            double totalContractSalary = 0;
            List<HourContract> tempContracts = Contracts.FindAll(x => x.Date.Year == year && x.Date.Month == month);
            foreach (HourContract item in tempContracts)
            {
                totalContractSalary += item.totalValue();
            }

            return totalContractSalary + BaseSalary;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nDepartment: {Department.Name}";
        }

    }
}
