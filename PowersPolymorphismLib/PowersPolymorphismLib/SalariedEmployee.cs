using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersPolymorphismLib
{
    // Inherits from Employee Parent
    public class SalariedEmployee:Employee
    {
        // New field
        private decimal _yearlySalary;

        // Constructor with Employee base
        public SalariedEmployee(string firstName, string lastName, int employeeID, DateTime dateOfHire, decimal yearlySalary):base(firstName, lastName, employeeID, dateOfHire)
        {
            _yearlySalary = yearlySalary;
        }

        // New property
        public decimal yearlySalary { get { return _yearlySalary; } }

        // override for the salary for 2 weeks worth of work
        override public decimal GetBiMonthlySalary()
        {
            return yearlySalary / 26;
        }
    }
}
