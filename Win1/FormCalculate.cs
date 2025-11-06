using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win1
{
    public partial class FormCalculate : Form
    {
        public FormCalculate()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private double summ(double a, double b)
        {
            return a + b;
        }
        private double substraction(double a, double b)
        {
            return a - b;
        }
        private double multplication(double a, double b)
        {
            return a * b;
        }
        private double division(double a, double b)
        {
            return a / b;
        }


        private void summbtn_Click(object sender, EventArgs e)
        {
            if (name1txt.Text.Trim() == "" || name2txt.Text.Trim() == "")
            {
                MessageBox.Show("Your need to write UserName or Password");
                return;
            }
            name3txt.Text = Convert.ToString(summ(Convert.ToDouble(name1txt.Text), Convert.ToDouble(name2txt.Text)));
        }

        private void substractionbtn_Click(object sender, EventArgs e)
        {
            if (name1txt.Text.Trim() == "" || name2txt.Text.Trim() == "")
            {
                MessageBox.Show("Your need to write UserName or Password");
                return;
            }
            name3txt.Text = Convert.ToString(substraction(Convert.ToDouble(name1txt.Text), Convert.ToDouble(name2txt.Text)));
        }

        private void multplicationbtn_Click(object sender, EventArgs e)
        {
            if (name1txt.Text.Trim() == "" || name2txt.Text.Trim() == "")
            {
                MessageBox.Show("Your need to write UserName or Password");
                return;
            }
            name3txt.Text = Convert.ToString(multplication(Convert.ToDouble(name1txt.Text), Convert.ToDouble(name2txt.Text)));
        }

        private void divisionbtn_Click(object sender, EventArgs e)
        {
            if (name1txt.Text.Trim() == "" || name2txt.Text.Trim() == "")
            {
                MessageBox.Show("Your need to write UserName or Password");
                return;
            }
            name3txt.Text = Convert.ToString(division(Convert.ToDouble(name1txt.Text), Convert.ToDouble(name2txt.Text)));
        }
    }
}
