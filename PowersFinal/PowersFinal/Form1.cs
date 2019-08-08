//Author: Matthew Powers
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowersFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateStudents();
        }

        //Question 3
        private void btnAccounts_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Account a1 = new Account(0000, 1000);
            Account a2 = new Account(0001, 500);
            Account a3 = new Account(0000, 1000);

            richTextBox1.AppendText("Account a1 account number is the same as account a2's: " + a1.MyEquals(a2.AccountNumber).ToString() + "\n");
            richTextBox1.AppendText("Account a1 account number is the same as account a3's: " + a1.MyEquals(a3.AccountNumber).ToString());
        }

        //Question 4
        int[] randomNums = new int[]{ 24, 33, 83, 01, 10, 11, 77, 6 };
        private int secondLargest(int[] intArray)
        {
            int largest = 0;
            int secondLargest = 0;
            for(int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] > largest) largest = intArray[i];
                if (intArray[i] > secondLargest && intArray[i] != largest) secondLargest = intArray[i];
            }
            return secondLargest;
        }

        private void btnSecondLargest_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText(secondLargest(randomNums).ToString());
        }

        //Question 5
        List<string> randomStrings = new List<string> { "Yes", "No", "Maybe", "So", "Is", "This", "the", "real", "life" };

        private Queue<string> middleOnly(List<string> strList)
        {
            Queue<string> newString = new Queue<string>();
            for(int i = 0; i < strList.Count; i++)
            {
                if (i > 0 && i < strList.Count -1)
                {
                    newString.Enqueue(strList[i]);
                }
            }
            return newString;
        }

        private void btnStrQueue_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText(middleOnly(randomStrings).Count.ToString());
        }

        //Question 6

        int[] moreRandNums = { 9, 8, 7, 23, 111, 58, 457, 91, 88, 1, 84, 33 };
        private void sortAlg(int[] randArr)
        {
            int temp = 0;

            for(int i = 0; i < randArr.Length; i++)
            {
                for(int j = 0; j < randArr.Length - 1; j++)
                {
                    if (randArr[j] > randArr[j + 1])
                    {
                        temp = randArr[j + 1];
                        randArr[j + 1] = randArr[j];
                        randArr[j] = temp;
                    }
                }
            }

            for(int k = 0; k < randArr.Length; k++)
            {
                richTextBox1.AppendText(randArr[k] + " ");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            sortAlg(moreRandNums);
        }

        //Question 7
        // Compares at index 0, which equals 12, to 47, they're not equal, moves to the next index
        // Compares at index 1, which equals 15, to 47, they're not equal, moves to the next index
        // Compares at index 2, which equals 21, to 47, they're not equal, moves to the next index
        // Compares at index 3, which equals 27, to 47, they're not equal, moves to the next index
        // Compares at index 4, which equals 32, to 47, they're not equal, moves to the next index
        // Compares at index 5, which equals 35, to 47, they're not equal, moves to the next index
        // Compares at index 6, which equals 39, to 47, they're not equal, moves to the next index
        // Compares at index 7, which equals 43, to 47, they're not equal, moves to the next index
        // Compares at index 8, which equals 47, to 47, they are equal, and stops

        //Question 8
        Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();
        private void PopulateStudents()
        {
            Student[] newStudents =
             {
                new Student { First = "Svetlana", Last = "Omelchenko", ID = 111, Scores = new List<int> { 97, 92, 81, 60 } },
                new Student { First = "Claire", Last = "O’Donnell", ID = 112, Scores = new List<int> { 75, 84, 91, 39 } },
                new Student { First = "Sven", Last = "Mortensen", ID = 113, Scores = new List<int> { 88, 94, 65, 91 } },
                new Student { First = "Cesar", Last = "Garcia", ID = 114, Scores = new List<int> { 97, 89, 85, 82 } },
                new Student { First = "Debra", Last = "Garcia", ID = 115, Scores = new List<int> { 35, 72, 91, 70 } },
                new Student { First = "Fadi", Last = "Fakhouri", ID = 116, Scores = new List<int> { 99, 86, 90, 94 } },
                new Student { First = "Hanying", Last = "Feng", ID = 117, Scores = new List<int> { 93, 92, 80, 87 } },
                new Student { First = "Hugo", Last = "Garcia", ID = 118, Scores = new List<int> { 92, 90, 83, 78 } },
                new Student { First = "Lance", Last = "Tucker", ID = 119, Scores = new List<int> { 68, 79, 88, 92 } },
                new Student { First = "Terry", Last = "Adams", ID = 120, Scores = new List<int> { 99, 82, 81, 79 } },
                new Student { First = "Eugene", Last = "Zabokritski", ID = 121, Scores = new List<int> { 96, 85, 91, 60 } },
                new Student { First = "Michael", Last = "Tucker", ID = 122, Scores = new List<int> { 94, 92, 91, 91 } },
            };
            for(int i = 0; i < newStudents.Length; i++)
            {
                studentDictionary.Add(newStudents[i].ID, newStudents[i]);
            }
        }

        //Qustion 9

        private void Display()
        {
            richTextBox1.Clear();
            foreach (KeyValuePair<int, Student> kvp in studentDictionary)
            {
                int key = kvp.Key;
                Student student = kvp.Value;
                string scores = "";
                for (int i = 0; i < student.Scores.Count; i++)
                {
                    scores += student.Scores[i] + " ";
                }
                richTextBox1.AppendText(key + "\t" + student.First + "\t" + student.Last + "\t" + scores + "\n");
            }
        }
        private void btnDisplayStudents_Click(object sender, EventArgs e)
        {
            Display();
        }

        //Question 10
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int key = int.Parse(txtKey.Text);
            if (studentDictionary.Remove(key))
            {
                Display();
            }
            else MessageBox.Show("No student found with given key");
        }

        //Question 11
        private void btnSearch_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int key = int.Parse(txtKey2.Text);
            Student student;
            if (studentDictionary.TryGetValue(key, out student))
            {
                string scores = "";
                for (int i = 0; i < student.Scores.Count; i++)
                {
                    scores += student.Scores[i] + " ";
                }
                string data = "First Name: " + student.First + "\n" + "Last Name: " + student.Last + "\n" + "Scores: " + scores;
                richTextBox1.AppendText(data);
            }
            else MessageBox.Show("No student is found with the given key");
        }
    }
}
