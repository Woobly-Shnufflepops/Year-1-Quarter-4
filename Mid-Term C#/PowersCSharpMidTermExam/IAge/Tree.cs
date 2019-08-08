using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgeSpace
{
    // Question 8
    public class Tree : IAge
    {
        private string _typeOfTree;
        private string _location;
        private DateTime _datePlanted;

        public string typeOfTree { get { return _typeOfTree; } }
        public string location { get { return _location; } }
        public DateTime ImportantDate { get { return _datePlanted; } }

        public Tree(string TypeOfTree, string Location, DateTime DatePlanted)
        {
            _typeOfTree = TypeOfTree;
            _location = Location;
            _datePlanted = DatePlanted;
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
            return string.Format("Type of tree: {0} Location: {1} Date Planted: {2} Age (in days): {3}", typeOfTree, location, ImportantDate, getAge());
        }
    }
}
