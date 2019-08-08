using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersPolymorphismLib
{
    // 2nd child of Employee class, first child of SalariedEmployee
    public class Manager:SalariedEmployee
    {
        // Constructor
        public Manager(string firstName, string lastName, int employeeID, DateTime dateOfHire, decimal yearlySalary):base(firstName, lastName, employeeID, dateOfHire, yearlySalary)
        {

        }
        
        // Overridden vacation time
        public override double GetAccuredVacation()
        {
            double VacationTime = 0;
            double twoWeeks = 10;
            for(int i = 0; i < GetSeniority(); i++)
            {
                if (i <= 5 && VacationTime < 25)
                {
                    VacationTime += twoWeeks;
                    if (VacationTime > 25)
                    {
                        VacationTime = 25;
                    }
                }
                else if (i > 5 && VacationTime < 25)
                {
                    VacationTime++;
                }
            }
            return VacationTime;
        }
    }
}
