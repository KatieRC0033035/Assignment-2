using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {// hides the text on the labels where the answer goes
        public Form1()
        {
            InitializeComponent();
            label29.Text = "";
            label30.Text = "";
            label31.Text = "";
            label32.Text = "";
            label33.Text = "";
            label34.Text = "";
            label35.Text = "";
            label36.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //works out the total of 2 resistors in a series circuit
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double stwo1 = Convert.ToDouble(textBox1.Text);
                double stwo2 = Convert.ToDouble(textBox2.Text);

                double a = stwo1 + stwo2;
                label29.Text = a.ToString("0.00") + "Ω";
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        //works out the total of 3 resistors in a series circuit
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double sthree1 = Convert.ToDouble(textBox3.Text);
                double sthree2 = Convert.ToDouble(textBox4.Text);
                double sthree3 = Convert.ToDouble(textBox5.Text);

                double a = sthree1 + sthree2 + sthree3;
                label30.Text = a.ToString("0.00") + "Ω";
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        //works out the total of 4 resistors in a series circuit
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double sfour1 = Convert.ToDouble(textBox6.Text);
                double sfour2 = Convert.ToDouble(textBox7.Text);
                double sfour3 = Convert.ToDouble(textBox8.Text);
                double sfour4 = Convert.ToDouble(textBox9.Text);

                double a = sfour1 + sfour2 + sfour3 + sfour4;
                label31.Text = a.ToString("0.00") + "Ω";
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        //works out the total of 5 resistors in a series circuit
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double sfive1 = Convert.ToDouble(textBox10.Text);
                double sfive2 = Convert.ToDouble(textBox11.Text);
                double sfive3 = Convert.ToDouble(textBox12.Text);
                double sfive4 = Convert.ToDouble(textBox13.Text);
                double sfive5 = Convert.ToDouble(textBox14.Text);

                double a = sfive1 + sfive2 + sfive3 + sfive4 + sfive5;
                label32.Text = a.ToString("0.00") + "Ω";
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        //works out the total of 2 resistors in a parallel circuit
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double ptwo1 = Convert.ToDouble(textBox15.Text);
                double ptwo2 = Convert.ToDouble(textBox16.Text);

                double a = (1.0 / ptwo1) + (1.0 / ptwo2);
                label33.Text = a.ToString("0.00") + "Ω";
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        //works out the total of 3 resistors in a parallel circuit
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double pthree1 = Convert.ToDouble(textBox17.Text);
                double pthree2 = Convert.ToDouble(textBox18.Text);
                double pthree3 = Convert.ToDouble(textBox19.Text);

                double a = (1.0 / pthree1) + (1.0 / pthree2) + (1.0 / pthree3);
                label34.Text = a.ToString("0.00") + "Ω";
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        //works out the total of 4 resistors in a parallel circuit
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                double pfour1 = Convert.ToDouble(textBox20.Text);
                double pfour2 = Convert.ToDouble(textBox21.Text);
                double pfour3 = Convert.ToDouble(textBox22.Text);
                double pfour4 = Convert.ToDouble(textBox23.Text);

                double a = (1.0 / pfour1) + (1.0 / pfour2) + (1.0 / pfour3) + (1.0 / pfour4);
                label35.Text = a.ToString("0.00") + "Ω";
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        //works out the total of 5 resistors in a parallel circuit
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                double pfive1 = Convert.ToDouble(textBox24.Text);
                double pfive2 = Convert.ToDouble(textBox25.Text);
                double pfive3 = Convert.ToDouble(textBox26.Text);
                double pfive4 = Convert.ToDouble(textBox27.Text);
                double pfive5 = Convert.ToDouble(textBox28.Text);

                double a = (1.0 / pfive1) + (1.0 / pfive2) + (1.0 / pfive3) + (1.0 / pfive4) + (1.0 / pfive5);
                label36.Text = a.ToString("0.00") + "Ω";
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
