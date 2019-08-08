using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentsLibrary;

namespace Classes_And_Objects
{
    public partial class Form1 : Form
    {
        //define/create a list of students
        List<Student> studentList = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            PreLoad(); 
        }

        // Method to pre-load the studentList with few students (to have something to work with)
        private void PreLoad()
        {
            Student student = new Student("John", "Connor", 4568792, "Computer Science");
            // add a few courses to this student
            student.AddCourse("CSI_155");
            student.AddCourse("CSI_177");
            // save the student to the studentList
            studentList.Add(student);

            student = new Student("Christine", "Nabatanz", 809555666, "Networking");
            // addd a few courses
            student.AddCourse("Net_444");
            student.AddCourse("Intro_to_Psychology");
            studentList.Add(student);

            student = new Student("Matthew", "Powers", 809568792, "Computer Science");
            student.AddCourse("CSI_154");
            student.AddCourse("CSI_155");
            studentList.Add(student);
        }

        private void btnDisplayList_Click(object sender, EventArgs e)
        {
            //clear display
            richTextBox1.Clear();
            //sequence through the studentList
            foreach(Student student in studentList)
            {
                richTextBox1.AppendText(student.Firstname + " " + student.Lastname + " " + student.ID + "\n");
                // display the courses:
                string[] courses = student.courses;
                foreach (string course in courses)
                {
                    richTextBox1.AppendText("\t" + "\t" + course + "\n");
                }
                // add an extra line to sepereate one student from another
                richTextBox1.AppendText("\n");
            }
        }

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            //read all the student data from the user
            string firstName = txtFN.Text;
            string lastName = txtLN.Text;
            long ID = long.Parse(txtID.Text);
            string program = txtPR.Text;
            //create a student object
            Student student = new Student(firstName, lastName, ID, program);
            //add/save student to the studentList
            studentList.Add(student);
            MessageBox.Show("The student has been added");
            txtFN.Clear();
            txtID.Clear();
            txtLN.Clear();
            txtPR.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add new course to a student
            // 1: get the student using the index
            int index = int.Parse(txtIndex.Text);
            Student student = studentList[index];
            // 2: get the course name
            string course = txtCourseName.Text;
            // 3: add the course to the student
            student.AddCourse(course);
            //optional
            MessageBox.Show("A new course has been added");
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            // Remove a course from a student
            // 1: Get the student using the index
            int index = int.Parse(txtIndexRemove.Text);
            Student student = studentList[index];
            // 2: Get the course name
            string course = txtIndexRemove.Text;
            // 3: Remove the course from the student
            student.RemoveCourse(course);
        }

        private void btnTwoOrLess_Click(object sender, EventArgs e)
        {
            // Display students with 2 or less courses
            // 1: Loop through the students and add them to the rich text box
            foreach(Student student in studentList)
            {
                if(student.courses.Length <= 2)
                {
                    richTextBox1.AppendText(student.Firstname + "\n");
                }
            }
        }
    }
}
//Exercise: Add to this project
//1: Add a way to remove a course from a student
//2: Add a button to display only the student with 2 or less courses
