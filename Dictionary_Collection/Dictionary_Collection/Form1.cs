using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_Collection
{
    public partial class Form1 : Form
    {
        Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }
        private void Initialize()
        {
            Random rand = new Random();
            string[] names = { "John", "Steve", "Karen", "Dan", "Robert", "Michelle", "Sonia", "Lu-Kang", "Johnny", "Cage" };
            for(int i = 0; i < names.Length; i++)
            {
                string id = rand.Next(000000, 999999).ToString();
                int day = rand.Next(1, 29);
                int month = rand.Next(1, 13);
                int currentYear = DateTime.Now.Year;
                int year = rand.Next(currentYear - 50, currentYear-18);
                DateTime dateOfBirth = new DateTime(year, month, day);
                Student student = new Student
                {
                    Name = names[i],
                    DateOfBirth = dateOfBirth,
                    ID = id
                };
                studentDictionary.Add(id, student);
            }
        }

        //Display the content of a dictionary
        //A dictionary is seen as a collection of key-value pairs.
        //The .Net defines a structure called: KeyValuePair, which holds the key and the value
        //So, when you sequence through a dictionary with a foreach loop, the element type should
        //be a keyValuePair
        private void Display(Dictionary<string, Student> dictionary)
        {
            listBox1.Items.Clear();
            foreach(KeyValuePair<string, Student> kvp in dictionary)
            {
                string key = kvp.Key;
                Student student = kvp.Value;
                listBox1.Items.Add(key + "\t" + student.Name + "\t" + student.DateOfBirth.ToString());
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Display(studentDictionary);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*
             * public bool TryGetValue(TKey key, out Tvalue value);
             */
            string key = txtKey.Text;
            Student student;
            if (studentDictionary.TryGetValue(key, out student))
            {
                string data = "Name: " + student.Name + "\n" + "Date of birth: " + student.DateOfBirth.ToString();
                MessageBox.Show(data);
            }
            else MessageBox.Show("No student is found with the given key");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            /*
             * public bool Remove(TKey key)
             */
            string key = txtKey.Text;
            if (studentDictionary.Remove(key))
            {
                //display the dictionary again to verify that the student has been removed
                Display(studentDictionary);
            }
            else MessageBox.Show("No student is found with the given key");
        }
    }
}
/*
 * new project
 * create a Book class
 * fields: _title, _isbn, _author, _price
 * 
 * in form1: create a Dictionary using isbn as a key
 * use method Initialize to populate the dictionary with about 10 books
 * 
 * provide GUI to:
 * display all the books
 * add a new book
 * search for a book
 * and remove a book
 */
