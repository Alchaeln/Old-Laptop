using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_9_CST150
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void showMeters(int numMillimeters) { }


        private void button1_Click(object sender, EventArgs e)
        {

            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            int sum = n1 + n2;

            label1.Text = ("Sum is " + sum);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n3 = double.Parse(textBox3.Text);
            double n4 = double.Parse(textBox4.Text);
            double n5 = double.Parse(textBox5.Text);
            double n6 = double.Parse(textBox6.Text);
            double n7 = double.Parse(textBox7.Text);
            double averageOfFive = ((n3 + n4 + n5 + n6 + n7) / 5);

            label3.Text = ("Average is " + averageOfFive);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int n1 = int.Parse(textBox8.Text);
            int n2 = int.Parse(textBox9.Text);
            int n3 = int.Parse(textBox10.Text);

            if ((n1 + n2 + n3) % 3 == 0)
            {
                label4.Text = ("The three numbers sum is divisible by three!");
            }
            else
                label4.Text = ("The three numbers sum is not divisible by three!");
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n1 = textBox11.Text.Length;
            int n2 = textBox12.Text.Length;

            if( n1 < n2)
            {
                label7.Text = (textBox11.Text + " is the one with fewer characters!" );
            }
            else
                label7.Text = (textBox12.Text + " is the one with fewer characters!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n1 = rnd.Next(0, 100);
            int n2 = rnd.Next(0, 100);

            int sum = n1 + n2;

            label9.Text = (
                "The first random number is " + n1 + "\n" +
                "The second radom number is " + n2 + "\n" +
                "The sum of the two random numbers is " + sum);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox13.Text);
            double n2 = double.Parse(textBox14.Text);
            double n3 = double.Parse(textBox15.Text);
            double n4 = double.Parse(textBox16.Text);
            double n5 = double.Parse(textBox17.Text);


            double[] arr = { n1, n2, n3, n4, n5 };


                int i;
                double max = arr[0];

            for (i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {

                    max = arr[i];
                }
            }

            label11.Text = ("Max is " + max);

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] arr1;          

            arr1 = new int[50];  

            int arrayLength = arr1.Length;

       
            for (int i = 0; i < arrayLength; i++)
            {
                arr1[i] = i;
                label13.Text += arr1[i] + " ";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool a = true;
            bool b = false;

            if (a && b) {
                label14.Text = "True";
            }
              else{
                label14.Text = "False";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox18.Text);
            double n2 = double.Parse(textBox19.Text);

            double product = n1 * n2;

            label15.Text = "Product of both numbers is " + product;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox20.Text);
            int n2 = int.Parse(textBox21.Text);
            int n3 = int.Parse(textBox22.Text);
            int n4 = int.Parse(textBox23.Text);
            int n5 = int.Parse(textBox24.Text);
            int n6 = int.Parse(textBox25.Text);

            int[,] array2D = new int[3, 2] { { n1, n2 }, { n3, n4 }, { n5, n6 } };

            int num1 = (array2D[0, 0]);
            int num2 = (array2D[0, 1]);
            int num3 = (array2D[1, 0]);
            int num4 = (array2D[1, 1]);
            int num5 = (array2D[2, 0]);
            int num6 = (array2D[2, 1]);

            int average = (num1 + num2 + num3+ num4 + num5 + num6)/6;
           
            label19.Text = "Average of entries is " + average;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
