using Milestone_Project_CST150.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_Project_CST150
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text))
                return;

         
            listBox1.Items.Add(textBox1.Text + "\t" + textBox2.Text + "\t\t\t(" + textBox3.Text + ")\t\t" + textBox4.Text);
                
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);

                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            const string sPath = @"C:\Users\alcha\OneDrive\Desktop\InventoryListLids.txt";


            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in listBox1.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }

            SaveFile.Close();

            MessageBox.Show("Inventory saved!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                textBox5.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            try
            {
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, textBox5.Text);
            }
            catch { }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear();
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                if (listBox1.Items[i].ToString().ToLower().Contains(textBox6.Text.ToLower()))
                {
                    listBox1.SetSelected(i, true);
                }
            }

            textBox5.Clear();

        }
    }
}
