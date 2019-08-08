// Author: Matthew Powers
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowersPolymorphismLib;

namespace PowersPolymorphism
{
    public partial class Form1 : Form
    {
        // Calls the initalize and the preload method
        public Form1()
        {
            InitializeComponent();
            preLoad();
        }

        // List of employees
        List<Employee> CompanyEmployees = new List<Employee>();
        // Preloaded information to mess around with
        public void preLoad()
        {
            CompanyEmployees.Add(new SalariedEmployee("John", "Jacob", 00, new DateTime(2015, 1, 1), 26000m));
            CompanyEmployees.Add(new SalariedEmployee("John", "Jacob", 01, new DateTime(2002, 1, 1), 26000m));
            CompanyEmployees.Add(new SalariedEmployee("John", "Jacob", 02, new DateTime(2002, 1, 1), 26000m));
            CompanyEmployees.Add(new SalariedEmployee("John", "Jacob", 03, new DateTime(2002, 1, 1), 26000m));
            CompanyEmployees.Add(new SalariedEmployee("John", "Jacob", 04, new DateTime(2002, 1, 1), 26000m));

            CompanyEmployees.Add(new HourlyEmployee("Jim", "Job", 05, new DateTime(2016, 1, 1), 11.00m, 80));
            CompanyEmployees.Add(new HourlyEmployee("Jim", "Job", 06, new DateTime(1980, 1, 1), 11.00m, 80));
            CompanyEmployees.Add(new HourlyEmployee("Jim", "Job", 07, new DateTime(2001, 1, 1), 11.00m, 80));
            CompanyEmployees.Add(new HourlyEmployee("Jim", "Job", 08, new DateTime(2001, 1, 1), 11.00m, 80));
            CompanyEmployees.Add(new HourlyEmployee("Jim", "Job", 09, new DateTime(2001, 1, 1), 11.00m, 80));

            CompanyEmployees.Add(new Manager("Rebecca", "Black", 10, new DateTime(2017, 1, 1), 35000m));
            CompanyEmployees.Add(new Manager("Rebecca", "Black", 11, new DateTime(2006, 1, 1), 35000m));
            CompanyEmployees.Add(new Manager("Rebecca", "Black", 12, new DateTime(1980, 1, 1), 35000m));
        }

        // Button that adds the correct employee type, throws an error if one of the 3 isn't in the accepted types
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (txtEmployeeType.Text == "HourlyEmployee")
            {
                CompanyEmployees.Add(new HourlyEmployee(txtFirstName.Text, txtLastName.Text, int.Parse(txtIDNumber.Text), DateTime.Parse(txtDateHired.Text), decimal.Parse(txtWage.Text), double.Parse(txtHours.Text)));
            }
            else if (txtEmployeeType.Text == "Manager")
            {
                CompanyEmployees.Add(new Manager(txtFirstName.Text, txtLastName.Text, int.Parse(txtIDNumber.Text), DateTime.Parse(txtDateHired.Text), decimal.Parse(txtWage.Text)));
            }
            else if (txtEmployeeType.Text == "SalariedEmployee")
            {
                CompanyEmployees.Add(new SalariedEmployee(txtFirstName.Text, txtLastName.Text, int.Parse(txtIDNumber.Text), DateTime.Parse(txtDateHired.Text), decimal.Parse(txtWage.Text)));
            }
            else MessageBox.Show("Invalid Employee type, please type either 'HourlyEmployee', 'Manager', or 'SalariedEmployee'");
        }

        // method that calls DisplayEmployees into a loop, displaying them all to the rich text box
        private void btnDisplayEmployees_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach(Employee Yee in CompanyEmployees)
            {
                DisplayEmployees(Yee);
            }
        }

        // Method that sorts the information of the employee into a single line
        private void DisplayEmployees(Employee e)
        {
            string employeeType = e.GetType().Name;
            string fName = e.firstName;
            string lName = e.lastName;
            int ID = e.employeeID;
            DateTime hired = e.dateOfHire;
            decimal wage = decimal.Parse(e.GetBiMonthlySalary().ToString("n"));
            int Senority = e.GetSeniority();
            double vacationTime = e.GetAccuredVacation();

            richTextBox1.AppendText(string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", employeeType, fName, lName, ID, hired, wage, Senority, vacationTime));
            richTextBox1.AppendText("\n");
        }

        // Button that gets the senority of anybody who is at, or over, the age listed in the text box
        private void btnSenority_Click(object sender, EventArgs e)
        {
            foreach(Employee Yee in CompanyEmployees)
            {
                if (int.Parse(txtYearsWorked.Text) <= Yee.GetSeniority())
                {
                    DisplayEmployees(Yee);
                }
            }
            
        }
    }
}
