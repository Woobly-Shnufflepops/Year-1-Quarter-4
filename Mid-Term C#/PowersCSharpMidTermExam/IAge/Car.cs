using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgeSpace
{
    // Question 8
    public class Car : IAge
    {
        private string _make;
        private string _model;
        private DateTime _dateBuilt;

        public string make { get { return _make; } }
        public string model { get { return _model; } }
        public DateTime ImportantDate { get { return _dateBuilt; } }

        public Car(string Make, string Model, DateTime DateBuilt)
        {
            _make = Make;
            _model = Model;
            _dateBuilt = DateBuilt;
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
            return string.Format("Make: {0} Model: {1} Date built: {2} Age (in days) {3}", make, model, ImportantDate, getAge());
        }
    }
}
