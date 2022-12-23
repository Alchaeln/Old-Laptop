using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlchaelNavarro_CST150_Activity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Double mathTime = Double.Parse(textBox1.Text) * .165;
                label4.Text = String.Format("{0:.###}", mathTime, " lbs");

            }

            catch(FormatException)
            {
                label4.Text = (textBox1.Text) + " is not valid. Please enter a number.";
            }

            catch(Exception exception)
            {
                Console.WriteLine(
                    $"Unexpected error:  { exception.Message }");
            }

        }
    }
}
