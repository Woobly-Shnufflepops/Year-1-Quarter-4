using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Polymorphism_Interface_Lib;

namespace Interace_Client
{
    public partial class Form1 : Form
    {
        List<IShape> shapeList = new List<IShape>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        private void Display(IShape shape)
        {
            richTextBox1.AppendText(shape.ToString()+"\n");
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double r = rand.Next(2, 100);
            Circle circle = new Circle(r);
            shapeList.Add(circle);
            Display(circle);
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double l = rand.Next(2, 100);
            double w = rand.Next(1, 100);
            MyRectangle rect = new MyRectangle(l, w);
            shapeList.Add(rect);
            Display(rect);
        }
    }
}

///Exercise:
///Complete this project for the remaining classes or shapes. (Add ToString() in each one, then add a button to display the create/save/display the shape
