using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesLib;

namespace Vehical_Tester_Powers
{
    public class Person
    {
        // Fields for the Person
        private string _firstname;
        private string _lastname;
        private List<Vehicle> _vehicleList;

        // Constructor for the Person
        public Person(string firstName, string lastName, List<Vehicle> vehicalList)
        {
            _firstname = firstName;
            _lastname = lastName;
            _vehicleList = vehicalList;
        }

        // Getters and setters
        public string FirstName
        {
            get { return _firstname; }
        }
        public string LastName
        {
            get { return _lastname; }
        }
        public List<Vehicle> VehicleList
        {
            get { return _vehicleList; }
            set { _vehicleList = value; }
        }

        // Method to add a vehicle
        public void Add(Vehicle V)
        {
            VehicleList.Add(V);
        }

        // Method to remove a vehicle
        public void Remove(string vin)
        {
            foreach(Vehicle vehical in VehicleList)
            {
                if(vehical.Vin == vin)
                {
                    VehicleList.Remove(vehical);
                    break;
                }
            }
        }
        // Spaghetti code method that formats the vehicle list text for the override method below
        private string Cars()
        {
            string duck = "";
            for (int i = 0; i < VehicleList.Count; i++)
            {
                duck += "\n" + VehicleList[i].ToString();
            }
            return duck;
        }

        // Override method that formats the text to be readable
        public override string ToString()
        {
            Cars();
            return string.Format("{0} {1} {2}", FirstName, LastName, Cars());
        }
    }
}
