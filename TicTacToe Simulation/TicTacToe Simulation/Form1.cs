using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Simulation
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            int[,] intArray = new int[3, 3];
            //press button to simulate game
            //get new game
            //shoot out array 3 by 3
            //fill the array with a one or a zero
            Random random = new Random();



            for (int row = 0; row < 3; row++)
            {
                label1.Text += "\n| ";
                //int temp = random.Next(0, 2);
                for (int col = 0; col < 3; col++)
                {
                    int i = random.Next(0, 2);

                    if (i == 1)//1 = X
                    {
                        intArray[row, col] = 1;
                        label1.Text += (" X | ");
                    }
                    else if (i == 0)//0 = O
                    {
                        intArray[row, col] = 0;
                        label1.Text += (" O | ");
                    }

                }

                //Once the array is checked if three are in a row
                //if none are  in a  row then it is a draw

            }


            if (intArray[0, 0] == 0 && intArray[0, 1] == 0 && intArray[0, 2] == 0 || intArray[1, 0] == 0 && intArray[1, 1] == 0 && intArray[1, 2] == 0
                || intArray[2, 0] == 0 && intArray[2, 1] == 0 && intArray[2, 2] == 0|| intArray[0, 2] == 0 && intArray[1, 2] == 0 && intArray[2, 2] == 0
                || intArray[0, 0] == 0 && intArray[1, 0] == 0 && intArray[2, 0] == 0|| intArray[0, 1] == 0 && intArray[1, 1] == 0 && intArray[2, 1] == 0 
                || intArray[0, 2] == 0 && intArray[1, 2] == 0 && intArray[2, 2] == 0|| intArray[0, 0] == 0 && intArray[1, 1] == 0 && intArray[2, 2] == 0
                || intArray[0, 2] == 0 && intArray[1, 1] == 0 && intArray[2, 0] == 0)
            {
                label2.Text = ("O is the Winner!");
            }
            else if (intArray[0, 0] == 1 && intArray[0, 1] == 1 && intArray[0, 2] == 1|| intArray[1, 0] == 1 && intArray[1, 1] == 1 && intArray[1, 2] == 1
                || intArray[2, 0] == 1 && intArray[2, 1] == 1 && intArray[2, 2] == 1|| intArray[0, 2] == 1 && intArray[1, 2] == 1 && intArray[2, 2] == 1
                || intArray[0, 0] == 1 && intArray[1, 0] == 1 && intArray[2, 0] == 1|| intArray[0, 1] == 1 && intArray[1, 1] == 1 && intArray[2, 1] == 1
                || intArray[0, 2] == 1 && intArray[1, 2] == 1 && intArray[2, 2] == 1|| intArray[0, 0] == 1 && intArray[1, 1] == 1 && intArray[2, 2] == 1
                || intArray[0, 2] == 1 && intArray[1, 1] == 0 && intArray[2, 0] == 1)
            {
                label2.Text = ("X is the Winner!");
            }
            else
            {
                label2.Text = ("Game was a Tie!");
            }


        }


    }
}
