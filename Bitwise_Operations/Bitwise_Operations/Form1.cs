using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitwise_Operations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIntToBinary_Click(object sender, EventArgs e)
        {
            try
            {
                //read an integer (decimal number base 10)
                int x = int.Parse(txtBase10.Text);
                //convert to binary (as a string)
                string binary = Convert.ToString(x, 2);
                //Display
                txtBase2.Text = binary;
                //convert to hex
                string hex = Convert.ToString(x, 16);
                //display hex
                txtBase16.Text = hex;
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void btnBinaryToInt_Click(object sender, EventArgs e)
        {
            try
            {
                //read binary
                string binary = txtBase2.Text;
                //conver to decimal (int)
                int x = Convert.ToInt32(binary, 2);
                //display
                txtBase10.Text = x.ToString();
                //conver to hex
                string hex = Convert.ToString(x, 16);
                txtBase16.Text = hex;
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void btnAndBitwiseOperation_Click(object sender, EventArgs e)
        {
            //read binary1 and binary2 as strings
            try
            {
                string binary1 = txtBinary1.Text;
                string binary2 = txtBinary2.Text;
                //convert both to decimal system
                int x1 = Convert.ToInt32(binary1, 2);
                int x2 = Convert.ToInt32(binary2, 2);

                //apply the AND (&) bitwise operation
                int result = x1 & x2;
                //convert back to binary
                string binaryResult = Convert.ToString(result, 2);
                //display
                txtResult.Text = binaryResult;
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }
    }
}
