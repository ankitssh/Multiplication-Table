using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplication_Tables
{
    public partial class displayTablebox : Form
    {
        public displayTablebox()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                int num = int.Parse(getNumBox.Text);

                for (int i = 1; i <= 10; i++)
                {
                    listBox1.Items.Add(getNumBox.Text + " times " + i + " = " + (num * i).ToString());

                }

            }
            catch(Exception)
            {
                MessageBox.Show("Invalid input. Please enter a valid input","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void getNumBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
