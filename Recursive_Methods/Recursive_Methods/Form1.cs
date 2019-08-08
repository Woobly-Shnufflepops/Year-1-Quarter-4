using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursive_Methods
{
    public partial class Form1 : Form
    {
        /*
         Recursive Methods
         -------------------
         Definition: A recursive method is a method that calls itself.
         */
        public Form1()
        {
            InitializeComponent();
        }
        // non-recursive (normal) method that displays a consecutive list of numbers
        private void nonRecursiveDisplay(int n)
        {
            // display all integers between 1 and n
            for(int i = 1; i <= n; i++)
            {
                listBox1.Items.Add(i);
            }
        }
        // Recursive method that displays a consecutive list of numbers
        private void recursiveDisplay(int n)
        {
            if(n <= 0)
            {
                return;
            }
            // display all integers between 1 and n
            //listBox1.Items.Add(n);
            recursiveDisplay(n-1);
            //display on the returns
            listBox1.Items.Add(n);
            //or
            //if(n > 0)
            //{
            //    listBox1.Items.Add(n);
            //    recursiveDisplay(n - 1);
            //}
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnNormalMethod_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            nonRecursiveDisplay(10);
        }

        private void btnRecursiveMethod_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            recursiveDisplay(10);
        }

        // A recursive method must have an if statement with some condition.
        // Run the recsive call only when the condition is true or stop the recursive calls when the condition is true

        //=============================================================================================================
        // Factorial Example:
        private int Factorial(int n)
        {
            int counter = 1;
            for(int i = n; i > 0; i--)
            {
                counter *= i;
            }
            return counter;
        }

        private void btnFactorialNormal_Click(object sender, EventArgs e)
        {
            int result = Factorial(5);
            listBox1.Items.Add(result);
        }

        private int RecursiveFactorial(int n)
        {
            if (n == 1) return 1;
            // Facotiral(n) = n * factorial(n-1);
            int result = n * RecursiveFactorial(n - 1);
            return result;
        }

        private void starDisplay(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                richTextBox1.AppendText("*");
            }
        }
        private void btnStars_Click(object sender, EventArgs e)
        {
            int n;
            int.TryParse(textBox1.Text, out n);
            richTextBox1.Clear();
            for(int i = 1; i <= n; i++)
            {
                starDisplay(i);
                richTextBox1.AppendText("\n");
            }
        }

        private void recursiveStars(int i, int n)
        {
            if (i > n) return;
            recursiveStar(i);
            richTextBox1.AppendText("\n");
            recursiveStars(i + 1, n);
        }

        private void recursiveStar(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                richTextBox1.AppendText("*");
            }
        }
        private void btnStarRecursive_Click(object sender, EventArgs e)
        {
            int n;
            int.TryParse(textBox1.Text, out n);
            richTextBox1.Clear();
            recursiveStars(1, n);
        }

        private void ReverseStars(int n)
        {
            for(int i = n; i > 0; i--)
            {
                richTextBox1.AppendText("*");
            }
        }

        private void btnStarReverse_Click(object sender, EventArgs e)
        {
            int n;
            int.TryParse(textBox1.Text, out n);
            richTextBox1.Clear();
            for(int i = n; i > 0; i--)
            {
                ReverseStars(i);
                richTextBox1.AppendText("\n");
            }
        }

        private void recursiveReverseStars(int n)
        {
            if (n == 0) return;
            recursiveReverseStar(n);
            richTextBox1.AppendText("\n");
            recursiveReverseStars(n - 1);
        }

        private void recursiveReverseStar(int n)
        {
            for(int i = n; i > 0; i--)
            {
                richTextBox1.AppendText("*");
            }
        }

        private void btnReverseStarsRecursion_Click(object sender, EventArgs e)
        {
            int n;
            int.TryParse(textBox1.Text, out n);
            richTextBox1.Clear();
            recursiveReverseStars(n);
        }

        int[] array0 = { 2, 3, 5, 6, 7, 9, 7, 6, 5, 3, 2 };
        int[] array1 = { 4, 8, 6, 9, 2, 3, 4, 7, 8, 1, 1, 22, 56 };
        int[] array3 = { 2, 3, 5, 6, 5, 9, 9, 5, 6, 5, 3, 2 };
        int[] array4 = { 4, 8, 8, 9, 2, 3, 4, 7, 8, 1, 1, 22, 56 };

        private void btnPalindrome_Click(object sender, EventArgs e)
        {
            bool r1 = IsPalindrome(array0);
            bool r2 = IsPalindrome(array1);
            bool r3 = IsPalindrome(array3);
            bool r4 = IsPalindrome(array4);
            richTextBox1.Text = "Is array 1 a palindrome: " + r1 + "\n" + "Is array 2 a palindrome: " + r2 + "\n" + "Is array 3 a palindrome: " + r3 + "\n" + "Is array 4 a palindrome: " + r4;
        }
        private bool IsPalindrome(int[] array)
        {
            int mid = array.Length / 2;
            int first = 0;
            int last = array.Length - 1;
            for(int i = 0; i < mid; i++)
            {
                if (array[first] != array[last]) return false;
                first++;
                last--; 
            }
            return true;
        }

        private void btnRecursivePalindrome_Click(object sender, EventArgs e)
        {

        }
    }
}
