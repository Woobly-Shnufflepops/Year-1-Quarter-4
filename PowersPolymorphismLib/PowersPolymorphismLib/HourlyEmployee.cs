using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersPolymorphismLib
{
    // HourlyEmployee, parent: Employee
    public class HourlyEmployee:Employee
    {
        // new fields
        private decimal _hourlywage;
        private double _numberofhoursWorked;

        // new properties
        public decimal hourlywage { get { return _hourlywage; } }
        public double numberofhoursWorked { get { return _numberofhoursWorked; } }

        // Constructor with base Employee
        public HourlyEmployee(string firstName, string lastName, int employeeID, DateTime dateOfHire, decimal hourlywage, double numberofhoursWorked):base(firstName, lastName, employeeID, dateOfHire)
        {
            _hourlywage = hourlywage;
            _numberofhoursWorked = numberofhoursWorked;
        }

        // Overriding the salary
        public override decimal GetBiMonthlySalary()
        {
            return hourlywage * (decimal)numberofhoursWorked;
        }

        // Vacation method
        public override double GetAccuredVacation()
        {
            double VacationTime = 0;
            double halfDay = 0.5;
            for (int i = 0; i < GetSeniority(); i++)
            {
                if (i >= 5 && i < 20)
                {
                    VacationTime += halfDay;
                }
            }
            return VacationTime;
        }
    }
}
