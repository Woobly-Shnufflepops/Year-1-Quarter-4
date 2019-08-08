using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehiclesLib;

namespace Vehical_Tester_Powers
{
    public partial class frmVehicalTester : Form
    {
        // Initalize component and loads the data with preLoad
        public frmVehicalTester()
        {
            InitializeComponent();
            preLoad();
        }

        // Creation of the People List
        List<Person> People = new List<Person>();
        // preLoad method which adds in the data
        public void preLoad()
        {
            People.Add(new Person("Jeff", "Goldbloom",
                new List<Vehicle> { new Vehicle("Nissan", "Altima", 2007, 10000.00m, "0000"),
                                    new Vehicle("Nissan","Altima",2017,35999.99m,"0001") }));
            People.Add(new Person("Jeff", "Silverbloom",
                new List<Vehicle> { new Vehicle("Nissan", "Altima", 2007, 10000.00m, "0002"),
                                    new Vehicle("Nissan","Altima",2017,35999.99m,"0004") }));
            People.Add(new Person("Jeff", "Bronzebloom",
                new List<Vehicle> { new Vehicle("Nissan", "Altima", 2007, 10000.00m, "0005"),
                                    new Vehicle("Nissan","Altima",2017,35999.99m,"0006") }));
            People.Add(new Person("Jeff", "Copperbloom",
                new List<Vehicle> { new Vehicle("Nissan", "Altima", 2007, 10000.00m, "0007"),
                                    new Vehicle("Nissan","Altima",2017,35999.99m,"0008") }));
            People.Add(new Person("Jeff", "Platinumbloom",
                new List<Vehicle> { new Vehicle("Nissan", "Altima", 2007, 10000.00m, "0009"),
                                    new Vehicle("Nissan","Altima",2017,35999.99m,"0010") }));
            People.Add(new Person("Jeff", "Brassbloom",
                new List<Vehicle> { new Vehicle("Nissan", "Altima", 2007, 10000.00m, "0011"),
                                    new Vehicle("Nissan","Altima",2017,35999.99m,"0012") }));
            People.Add(new Person("Jeff", "Ironbloom",
                new List<Vehicle> { new Vehicle("Nissan", "Altima", 2007, 10000.00m, "0013"),
                                    new Vehicle("Nissan","Altima",2017,35999.99m,"0014") }));
        }

        // Button that clears the list, then displays the text from the preLoad data
        private void btnDisplayPeopleAndCars_Click(object sender, EventArgs e)
        {
            rchtxtVehicalList.Clear();
            for(int i = 0; i < People.Count; i++)
            {
                rchtxtVehicalList.AppendText(People[i].ToString() + "\n");
            }
        }

        // Method that adds a car to a person at a specific index, then clears the text boxes
        private void btnAddACar_Click(object sender, EventArgs e)
        {
            People[int.Parse(txtPersonIndex.Text)].Add(new Vehicle(txtMake.Text, txtModel.Text, int.Parse(txtYear.Text), decimal.Parse(txtPrice.Text), txtVin.Text));
            txtMake.Clear();
            txtModel.Clear();
            txtPersonIndex.Clear();
            txtPrice.Clear();
            txtVin.Clear();
            txtYear.Clear();
        }

        // Method that updates the price of a car via the vin number and clears the text boxes afterwards
        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < People.Count; i++)
            {
                for(int j = 0; j < People[i].VehicleList.Count; j++)
                {
                    if(txtVinPriceUpdate.Text == People[i].VehicleList[j].Vin)
                    {
                        People[i].VehicleList[j].UpdatPrice(decimal.Parse(txtPriceUpdate.Text));
                    }
                }
            }
            txtVinPriceUpdate.Clear();
            txtPriceUpdate.Clear();
        }

        // Method that removes (sells) a car
        private void btnSellCar_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < People.Count; i++)
            {
                People[i].Remove(txtVinSellCar.Text);
            }
            txtVinSellCar.Clear();
        }
    }
}
