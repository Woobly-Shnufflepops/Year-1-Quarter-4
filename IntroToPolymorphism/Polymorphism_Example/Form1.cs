using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolymorphicCircularShapesLib;

namespace Polymorphism_Example
{
    public partial class Form1 : Form
    {
        List<Circle> circularShapeList = 
            new List<Circle>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //circle
            Random rand = new Random();
            double r = rand.Next(2, 100);
            //create a Circle object
            Circle circle = new Circle(r);
            //save it to a list
            circularShapeList.Add(circle);
            //display it.
            Display(circle);
        }

        private void btnSphere_Click(object sender, EventArgs e)
        {
            //sphere
            Random rand = new Random();
            double r = rand.Next(2, 100);
            //create a Sphere object
            Sphere sphere = new Sphere(r);
            //save it
            circularShapeList.Add(sphere);
            //display it
            Display(sphere);
        }

        private void btnCylinder_Click(object sender, EventArgs e)
        {
            //cylinder
            Random rand = new Random();
            double r = rand.Next(2, 100);
            double h = rand.Next(1, 100);
            Cylinder cylinder = new Cylinder(r, h);
            circularShapeList.Add(cylinder);
            Display(cylinder);
        }
       

        private void btnCone_Click(object sender, EventArgs e)
        {
            //cone
            Random rand = new Random();
            double r = rand.Next(2, 100);
            double h = rand.Next(1, 100);
            Cone cone = new Cone(r, h);
            circularShapeList.Add(cone);
            Display(cone);

        }

        //display
        private void Display(Circle c)
        {
            string name = c.GetType().Name;
            double peri = c.Perimeter();
            double area = c.Area();
            double vol = c.Volume();
            richTextBox1.AppendText(
                "name: "+ name + 
                "  r:" + c.Radius +
                 "  peri:" + peri.ToString("n") +
                 "  area:" + area.ToString("n") +
                 "  vol:" + vol.ToString("n") + "\n");
            //scroll down
            richTextBox1.ScrollToCaret();
        }
        private void DisplayAll(List<Circle> list)
        {
            richTextBox1.Clear();
            foreach (Circle c in list)
                Display(c);

        }
        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DisplayAll(circularShapeList);
        }
    }
}
///Exercise: redo the RectangularShapes project
///and apply polymorphism principles: virtual,override
