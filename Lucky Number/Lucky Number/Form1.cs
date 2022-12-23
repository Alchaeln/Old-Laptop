using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 1950; i <= DateTime.Today.Year; i++)
            {
                comboBox1.Items.Add(i);
            }


 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = int.Parse(comboBox1.Text);
            comboBox3.Items.Clear();
            if ((comboBox2.Text == "February" && year % 4 == 0)) //if(cmbMonth.SelectedIndex.Equals(specify index))
            {
                for (int i = 0; i < 30; i++)
                {
                    comboBox3.Items.Add(i.ToString());
                }
            }
            else if (comboBox2.Text == "February")
            {
                for (int i = 0; i < 29; i++)
                {
                    comboBox3.Items.Add(i.ToString());
                }
            }
            else
            {
                for (int i = 1; i < 32; i++)
                {
                    comboBox3.Items.Add(i.ToString());
                }
            }


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = int.Parse(comboBox1.Text);
            comboBox3.Items.Clear();
            if ((comboBox2.Text == "February" && year % 4 == 0)) //if(cmbMonth.SelectedIndex.Equals(specify index))
            {
                for (int i = 0; i < 30; i++)
                {
                    comboBox3.Items.Add(i.ToString());
                }
            }
            else if (comboBox2.Text == "February")
            {
                for (int i = 0; i < 29; i++)
                {
                    comboBox3.Items.Add(i.ToString());
                }
            }
            else
            {
                for (int i = 1; i < 32; i++)
                {
                    comboBox3.Items.Add(i.ToString());
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formTwo = new Form2();
            formTwo.Show();

            Random random = new Random();
            int randomNum = random.Next(0,1000);

            formTwo.LabelText = (randomNum + "");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
