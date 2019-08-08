using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployees
{
    public abstract class Employee
    {
        private string _fristname;
        private string _lastname;
        private int _employeeID;
        private DateTime _dateOfHire;

        public string firstName { get { return _fristname; } }
        public string lastName { get { return _lastname; } }
        public int employeeID { get { return _employeeID; } }
        public DateTime dateOfHire { get { return _dateOfHire; } }

        public Employee(string firstName, string lastName, int employeeID, DateTime dateOfHire)
        {
            _fristname = firstName;
            _lastname = lastName;
            _employeeID = employeeID;
            _dateOfHire = dateOfHire;
        }

        public abstract decimal GetBiWeeklySalary();

        public int GetAccuredVacation()
        {
            if (dateOfHire.AddYears(3) >= DateTime.Now && dateOfHire.AddYears(1) <= DateTime.Now)
            {
                return 7;
            }
            else if (dateOfHire.AddYears(3) < DateTime.Now && dateOfHire.AddYears(10) > DateTime.Now)
            {
                return 1;
            }
            else return 0;
        }

        public int GetSeniority()
        {
            return int.Parse(DateTime.Now.Year.ToString()) - dateOfHire.Year;
        }
    }
}
