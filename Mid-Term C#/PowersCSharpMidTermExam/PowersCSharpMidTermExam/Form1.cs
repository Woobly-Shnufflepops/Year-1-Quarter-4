using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IAgeSpace;

namespace PowersCSharpMidTermExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            preLoad();
        }
        // Question 10
        List<IAgeSpace.IAge> thingList = new List<IAgeSpace.IAge>();
        // Question 15
        List<Animal> animalList = new List<Animal>();

        // Question 11
        public void preLoad()
        {
            thingList.Add(new Person("John", "Wick", new DateTime(1992, 1, 1)));
            thingList.Add(new Person("John", "Bick", new DateTime(1993, 10, 6)));
            thingList.Add(new Person("John", "Nick", new DateTime(1994, 3, 5)));
            thingList.Add(new Person("John", "Lick", new DateTime(1995, 1, 18)));
            thingList.Add(new Person("John", "Rick", new DateTime(1996, 8, 1)));

            thingList.Add(new Tree("Pine", "TwinPinesMall", new DateTime(2000, 2, 9)));
            thingList.Add(new Tree("Pine", "TwinPinesMall", new DateTime(2001, 6, 25)));
            thingList.Add(new Tree("Pine", "TwinPinesMall", new DateTime(1999, 3, 16)));
            thingList.Add(new Tree("Pine", "TwinPinesMall", new DateTime(1972, 7, 8)));
            thingList.Add(new Tree("Pine", "TwinPinesMall", new DateTime(2008, 11, 13)));

            thingList.Add(new Car("Nissan", "Altima", new DateTime(2007, 12, 11)));
            thingList.Add(new Car("Nissan", "Altima", new DateTime(2008, 4, 3)));
            thingList.Add(new Car("Nissan", "Altima", new DateTime(2009, 7, 21)));
            thingList.Add(new Car("Nissan", "Altima", new DateTime(2010, 3, 16)));
            thingList.Add(new Car("Nissan", "Altima", new DateTime(2011, 9, 1)));

            animalList.Add(new Animal("Eagle", "crow", 0));
            animalList.Add(new Animal("Elephant", "elephant", 1));
            animalList.Add(new Animal("Lion", "lion3", 2));
            animalList.Add(new Animal("Tiger", "tiger", 3));
            animalList.Add(new Animal("Whale", "whale", 4));
        }
        
        private void DisplayAll(List<IAge> thing)
        {
            foreach(IAge nounThing in thing)
            {
                Display(nounThing);
            }
        }

        // Question 12
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplayAll(thingList);
        }

        private void Display(IAge IA)
        {
            richTextBox1.AppendText(IA.ToString() + "\n");
        }

        // Question 15
        private void DisplayAnimals(Animal A)
        {
            string type = A.imageFileName;
            string sound = A.voiceFileName;
            int id = A.id;
            richTextBox1.AppendText(string.Format("Animal type: {0} Animal sound: {1} ID: {2}\n", type, sound, id));
        }

        private void DisplayAllAnimals(List<Animal> Animal)
        {
            foreach(Animal AnimalThings in Animal)
            {
                DisplayAnimals(AnimalThings);
            }
        }

        private void btnDisplayAnimals_Click(object sender, EventArgs e)
        {
            DisplayAllAnimals(animalList);
        }

        // Question 16
        private void GetAnimalById(int id)
        {
            if(int.Parse(txtAnimalID.Text) == id)
            {
                richTextBox1.AppendText(animalList[id].ToString() + " " + id);
            }
            
        }

        private void btnAnimalID_Click(object sender, EventArgs e)
        {
            GetAnimalById(int.Parse(txtAnimalID.Text));
        }

        // Question 17
        private void btnPictureAnimal_Click(object sender, EventArgs e)
        {
        }
    }
}
