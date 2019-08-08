using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IComparable_Interface
{
    /*
     IComparable<T> interface
      
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            preload();
        }
        List<Cylinder> cylinderList = new List<Cylinder>();
        List<int> numbers = new List<int>();

        private void preload()
        {
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                double R = rand.Next(2, 12);
                double H = rand.Next(2, 20);
                Cylinder cy = new Cylinder(R, H);
                cylinderList.Add(cy);
                // load numbers
                numbers.Add(rand.Next(100, 500));
            }
        }

        private void Display(List<int> list)
        {
            richTextBox1.Clear();
            foreach(int x in list)
            {
                richTextBox1.AppendText(x + "\n");
            }
        }
        void Display(List<Cylinder> list)
        {
            richTextBox1.Clear();
            foreach (Cylinder cy in list)
            {
                richTextBox1.AppendText(cy.radius + "\t" + cy.height + "\t" + cy.Area().ToString("n") + "\t" + cy.Volume().ToString("n") + "\n");
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            int x, y;
            // read x and y
            int.TryParse(txtX.Text, out x);
            int.TryParse(txtY.Text, out y);

            // compare x to y
            // we want to know if x is > y, x < y, or x == y
            // we can achieve this with CompareTo
            int result = x.CompareTo(y);
            // by definition of the CompareTo as stated in the msdn documenatation
            // if the result is negative, then x < y
            // if the result is postive, then x > y
            // if the result is zero, then x == y
            if (result > 0) richTextBox1.Text = "x is greater than y";
            else if (result < 0) richTextBox1.Text = "x is less than y";
            else richTextBox1.Text = "x is equal to y";
        }

        private void btnCompareStrings_Click(object sender, EventArgs e)
        {
            string string1, string2;
            string1 = txtString1.Text;
            string2 = txtString2.Text;

            int results = string.Compare(string1, string2);
            if (results > 0) richTextBox1.Text = "string1 is greater than string2";
            else if (results < 0) richTextBox1.Text = "string1 is less than string2";
            else richTextBox1.Text = "string 1 equals string2";
        }

        private void btnRadiusHeight_Click(object sender, EventArgs e)
        {
            double radius1, radius2, height1, height2;
            double.TryParse(txtRadius1.Text, out radius1);
            double.TryParse(txtRadius2.Text, out radius2);
            double.TryParse(txtHeight1.Text, out height1);
            double.TryParse(txtHeight2.Text, out height2);
            //create two cylinder objects
            Cylinder cylinder1 = new Cylinder(radius1, height1);
            Cylinder cylinder2 = new Cylinder(radius2, height2);
            //Compare them based on volume
            double result = cylinder1.CompareTo(cylinder2);

            if (result > 0) richTextBox1.Text = "Cylinder1 has a greater volume than cylinder2";
            else if (result < 0) richTextBox1.Text = "Cylinder1 has a lesser volume than cylinder2";
            else richTextBox1.Text = "Cylinder 1 has the same volume as cylinder2";
        }

        private void btnSortByVolume_Click(object sender, EventArgs e)
        {
            // use the .net Sort method defined in the List<T> class
            cylinderList.Sort();
            // default sort relies on the fact that your class implements IComparable<T>
            Display(cylinderList);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Display(cylinderList);
        }

        private void btnDisplayNums_Click(object sender, EventArgs e)
        {
            Display(numbers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            Display(numbers);
        }

        private void btnIcomparer_Click(object sender, EventArgs e)
        {
            // sort the cylinderList by area
            // use
            /*
            public void Sort(Icomparer<T> comparer)
            */
            CylinderAreaComparer comparer = new CylinderAreaComparer();
            cylinderList.Sort(comparer);

            Display(cylinderList);
        }
    }
}
///Exercise
///Add a Person class with _name and _dateOfBirth
///and a method GetAge() that returns the age of the person
///Add GUI to create 2 person objects and compare them using the CompareTo based on age
///Display if older, younger, or the same age
