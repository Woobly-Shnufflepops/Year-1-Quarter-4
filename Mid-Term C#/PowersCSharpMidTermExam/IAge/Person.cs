using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgeSpace
{
    // Question 8
    public class Person : IAge
    {
        private string _firstname;
        private string _lastname;
        private DateTime _dateOfBirth;

        public string firstname { get { return _firstname; } }
        public string lastname { get { return _lastname; } }
         public DateTime ImportantDate { get { return _dateOfBirth; } }

        public Person(string FirstName, string LastName, DateTime DateOfBirth)
        {
            _firstname = FirstName;
            _lastname = LastName;
            _dateOfBirth = DateOfBirth;
        }

        public int getAge()
        {
            DateTime CurrentDate = DateTime.Now;
            long elapsedTicks = CurrentDate.Ticks - ImportantDate.Ticks;
            TimeSpan elapsedSpan = new TimeSpan(elapsedTicks);

            int days = elapsedSpan.Days;
            return days;
        }

        // Question 9
        public override string ToString()
        {
            return string.Format("First name: {0} Last name: {1} Date of birth: {2} Age (in days): {3}", firstname, lastname, ImportantDate, getAge());
        }
    }
}
