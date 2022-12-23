using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Milestone_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ID = Double.Parse(textBox1.Text);
            string description = textBox2.Text;
            double cost = Double.Parse(textBox3.Text);
            double quantity = Double.Parse(textBox4.Text);


            string path = @"C:\Users\alcha\OneDrive\Desktop\InventoryList.txt";
            if (File.Exists(path))
            {
                label5.Text = ("" + ID + description + cost + quantity);
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(ID + "\t");
                    sw.Write(description + "\t\t\t");
                    sw.Write("(" + (cost + ")\t\t"));
                    sw.Write(quantity + "\n");
                    sw.Close();
                }
            }

        }
    }
}
