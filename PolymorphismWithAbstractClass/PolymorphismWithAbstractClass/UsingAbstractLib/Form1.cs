using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbstractClassLib;

namespace UsingAbstractLib
{
    public partial class Form1 : Form
    {
        List<CircularShape> shapeList = new List<CircularShape>();
        public Form1()
        {
            InitializeComponent();
            //can you create an instance of the
            //CircularShape class?
            //CircularShape cs =
            //    new CircularShape(3.3, 7.7);
            //compiler error: cannot create an
            //instance of an abstract class.


        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DisplayAll(shapeList);
        }
        private void Display(CircularShape c)
        {
            string name = c.GetType().Name;
            double peri = c.Perimeter();
            double area = c.Area();
            double vol = c.Volume();
            richTextBox1.AppendText(
                "name: " + name +
                "  r:" + c.Radius +
                 "  peri:" + peri.ToString("n") +
                 "  area:" + area.ToString("n") +
                 "  vol:" + vol.ToString("n") + "\n");
            //scroll down
            richTextBox1.ScrollToCaret();
        }
        private void DisplayAll(List<CircularShape> list)
        {
            richTextBox1.Clear();
            foreach (CircularShape c in list)
                Display(c);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //circle
            //circle
            Random rand = new Random();
            double r = rand.Next(2, 100);
            //create a Circle object
            Circle circle = new Circle(r);
            //save it to a list
            shapeList.Add(circle);
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
            shapeList.Add(sphere);
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
            shapeList.Add(cylinder);
            Display(cylinder);
        }

        private void btnCone_Click(object sender, EventArgs e)
        {
            //cone
            Random rand = new Random();
            double r = rand.Next(2, 100);
            double h = rand.Next(1, 100);
            Cone cone = new Cone(r, h);
            shapeList.Add(cone);
            Display(cone);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
///Exercise:new projects with Widows app and 
///class library
///Define an abstract class RectangularShape
///with fields: _length, _width, _height
///and abstract methods Area and Volume
///
///Define a class MyRectangle that inherits
///RectangularShape
///Define a class Box that inherits MyRectangle
///Define a class Pyramid that inherits Box
