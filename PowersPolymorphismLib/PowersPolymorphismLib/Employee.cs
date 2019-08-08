using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersPolymorphismLib
{
    // Base class
    public abstract class Employee
    {
        // Fields
        private string _fristname;
        private string _lastname;
        private int _employeeID;
        private DateTime _dateOfHire;

        // Properties
        public string firstName { get { return _fristname; } }
        public string lastName { get { return _lastname; } }
        public int employeeID { get { return _employeeID; } }
        public DateTime dateOfHire { get { return _dateOfHire; } }

        // Constructor
        public Employee(string firstName, string lastName, int employeeID, DateTime dateOfHire)
        {
            _fristname = firstName;
            _lastname = lastName;
            _employeeID = employeeID;
            _dateOfHire = dateOfHire;
        }

        // Method to override
        public abstract decimal GetBiMonthlySalary();

        // Gets the vacation time earned by an employee based on how long they've been working
        public virtual double GetAccuredVacation()
        {
            double VacationTime = 0;
            double week = 5;
            double day = 1;
            for (int i = 0; i < GetSeniority(); i++)
            {
                if (i <= 3 && i >= 1)
                {
                    VacationTime += week;
                }
                else if (i > 3 && i < 10)
                {
                    VacationTime += day;
                }
            }
            return VacationTime;
        }

        // Gets how long an employee has been working for however many years
        public int GetSeniority()
        {
            return int.Parse(DateTime.Now.Year.ToString()) - dateOfHire.Year;
        }
    }
}
