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

namespace EndLettersET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog opentext = new OpenFileDialog();
            if (opentext.ShowDialog() == DialogResult.OK)
            {
                string strfilename = (opentext.FileName);
                string filetext = File.ReadAllText(strfilename);
                string fileOfWords = filetext;

                fileOfWords = fileOfWords.Replace(",", "");
                fileOfWords = fileOfWords.Replace("!", "");
                string[] strArray = fileOfWords.Split(' ');
                int arrayLength = strArray.Length;

                int count = 0;

                for (int i = 0; i < arrayLength; i++)
                {

                    string end = strArray[i].Substring(strArray[i].Length - 1);

                    if (end == "e")
                    {
                        count++;
                    }
                    else if (end == "t")
                    {
                        count++;
                    }

                }

                label1.Text = ("There are " + count + " words that end in a T or an E");



            }
            
        }
    }
}
