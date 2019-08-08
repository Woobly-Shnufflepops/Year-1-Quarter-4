using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLib
{
    public class Vehicle
    {
        // Fields for the vheicles
        private string _make;
        private string _model;
        private int _year;
        private decimal _price;
        private string _vin;

        // Properties for the vehicles
        public Vehicle(string make, string model, int year, decimal price, string vin)
        {
            _make = make;
            _model = model;
            _year = year;
            _price = price;
            _vin = vin;
        }

        // Getters and setters
        public string Make
        {
            get { return _make; }
        }
        public string Model
        {
            get { return _model; }
        }
        public int Year
        {
            get { return _year; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Vin
        {
            get { return _vin; }
        }

        // Method to update the price of a vehical
        public void UpdatPrice(decimal newPrice)
        {
            Price = newPrice;
        }

        // Override to format the text
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", Make, Model, Year, Price, Vin);
        }
    }
}
