using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircularShapesLib;

namespace Inheritance_Example01
{
    public partial class Form1 : Form
    {
        List<Circle> circularShapeList = new List<Circle>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double r = rand.Next(2,100);
            // Create a circle object
            Circle circle = new Circle(r);
            // save it to a list
            circularShapeList.Add(circle);
            // display it
            Display(circle);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void btnSphere_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double r = rand.Next(2, 100);
            // Create a sphere object
            Sphere sphere = new Sphere(r);
            // save it
            circularShapeList.Add(sphere);
            // display it
            Display(sphere);
        }
        private void Display(Circle c)
        {
            richTextBox1.AppendText(c.GetType().Name + ": ");
            if (c is Cylinder)
            {
                Cylinder cy = (Cylinder)c;
                double perimeter = cy.Perimeter();
                double area = cy.Area();
                double volume = cy.Volume();
                richTextBox1.AppendText("radius:" + cy.Radius +
                    " perimeter:" + perimeter.ToString("n") +
                    " Area:" + area.ToString("n") +
                    " Volume:" + volume.ToString("n") + "\n");
                // scroll down
                richTextBox1.ScrollToCaret();
            }
            else if (c is Sphere)
            {
                // Cast c to a sphere, then display sphere
                Sphere s = (Sphere)c;

                double perimeter = s.Perimeter();
                double area = s.Area();
                double volume = s.Volume();
                richTextBox1.AppendText("radius:" + s.Radius +
                    " perimeter:" + perimeter.ToString("n") +
                    " Area:" + area.ToString("n") +
                    " Volume:" + volume.ToString("n") + "\n");
                // scroll down
                richTextBox1.ScrollToCaret();
            }
            
            else
            {
                double perimeter = c.Perimeter();
                double area = c.Area();
                double volume = c.Volume();
                richTextBox1.AppendText("radius:" + c.Radius +
                    " perimeter:" + perimeter.ToString("n") +
                    " Area:" + area.ToString("n") +
                    " Volume:" + volume.ToString("n") + "\n");
                // scroll down
                richTextBox1.ScrollToCaret();
            }
        }

        private void btnCylinder_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double r = rand.Next(2, 100);
            double h = rand.Next(1, 100);
            Cylinder cylinder = new Cylinder(r,h);
            circularShapeList.Add(cylinder);
            Display(cylinder);
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            Display(circularShapeList);
        }
        private void Display(List<Circle> list)
        {
            foreach(Circle c in list)
            {
                Display(c);
            }
        }
    }
}
///Exercise:
///New Project
///Define base calss MyRectangle with length and width
///Define constructor, properties, and methods: Perimeter, Area, Volume
///Define child class Box with: length, width, height
///Add any necessary properties
///Hide any necessary methods
///
///Define child class Pyramid(with rectangular base)
///this class should inherit Box instead
///Define properties if any
///Hide methods if necessary
///
///look up (google) formulas for the above shapes
