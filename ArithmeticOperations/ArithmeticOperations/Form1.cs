using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticOperations
{
    public partial class ArithmeticOperations : Form
    {
        public ArithmeticOperations()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtFirstNumber.Text);
            double num2 = double.Parse(txtSecondNumber.Text);
            double sum = num + num2;
            txtResult.Text = sum.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtFirstNumber.Text);
            double num2 = double.Parse(txtSecondNumber.Text);
            double sum = num - num2;
            txtResult.Text = sum.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtFirstNumber.Text);
            double num2 = double.Parse(txtSecondNumber.Text);
            double sum = num * num2;
            txtResult.Text = sum.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtFirstNumber.Text);
            double num2 = double.Parse(txtSecondNumber.Text);
            double sum = num / num2;
            txtResult.Text = sum.ToString();
        }

    }
}
