using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_and_Stack
{
    public partial class Form1 : Form
    {
        /*
         * Queue is a FIFO (First In First Out) datastructure
         * use the Enqueue method to add a new item (job) to the queue
         * Use the Dequeue method to remove and process the item or job
         * Use the Peek method to see or get the first item
         * 
         * 
         */
        Random rand = new Random();
        Queue<int> intqueue = new Queue<int>();
        Stack<int> intstack = new Stack<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            int x = rand.Next(-99, 100);
            intqueue.Enqueue(x);
            Display(intqueue);
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            try
            {
                int x = intqueue.Dequeue();
                MessageBox.Show("Removed item: " + x);
                Display(intqueue);
            }
            catch(InvalidOperationException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (intqueue.Count > 0)
            {
                int x = intqueue.Peek();
                MessageBox.Show("On first is " + x);
            }
            else MessageBox.Show("There is nothing in the queue");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Display(Queue<int> queue)
        {
            listBox1.Items.Clear();
            foreach(int x in queue)
            {
                listBox1.Items.Add(x);
            }
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            int x = rand.Next(-99, 100);
            intstack.Push(x);
            DisplayStack(intstack);
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (intstack.Count > 0)
            {
                int x = intstack.Pop();
                MessageBox.Show("Popped item " + x);
                DisplayStack(intstack);
            }
            else MessageBox.Show("There is nothing in the stack");
        }

        private void btnStackPeek_Click(object sender, EventArgs e)
        {
            if(intstack.Count > 0)
            {
                int x = intstack.Peek();
                MessageBox.Show("The top item is " + x);
            }
            else MessageBox.Show("There is nothing in the stack");
        }

        private void btnStackClear_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void DisplayStack(Stack<int> stack)
        {
            listBox2.Items.Clear();
            foreach (int x in stack)
            {
                listBox2.Items.Add(x);
            }
        }
    }
}
