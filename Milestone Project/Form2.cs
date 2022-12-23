using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Milestone_Project
{
    public partial class ProductName1 : Form
    {
        public ProductName1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductName1_Load(object sender, EventArgs e)
        {

        }

      
        

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // "C:\Users\alcha\OneDrive\Desktop\GCU\CST105\Inventory List.txt"

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog opentext = new OpenFileDialog();
            if (opentext.ShowDialog() == DialogResult.OK)
            {
                string strfilename = (opentext.FileName);
                String filetext = File.ReadAllText(strfilename);
                richTextBox1.Text = filetext;
            }

            //string readText = File.ReadAllText(@"C:\Users\alcha\OneDrive\Desktop\GCU\CST105\Inventory List.txt");
            //Console.WriteLine(readText);

        }
    }
}
