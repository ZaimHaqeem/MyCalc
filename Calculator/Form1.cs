using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string No1Str;
            string No2Str;

            No1Str = textBox1.Text;
            No2Str = textBox2.Text;

            double No1Dbl;
            double No2Dbl;

            try
            {
                No1Dbl = Convert.ToDouble(No1Str);
                No2Dbl = Convert.ToDouble(No2Str);
            }
            catch
            {
                ResultLabel.Text = "Please give correct value";
                    return;
            }
            double ResultDbl;

            ResultDbl = No1Dbl + No2Dbl;

            string ResultStr;

            ResultStr = Convert.ToString(ResultDbl);
            ResultLabel.Text = "Result: "+ResultStr;
        }

       

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string No1Str;
            string No2Str;

            No1Str = textBox1.Text;
            No2Str = textBox2.Text;

            double No1Dbl;
            double No2Dbl;

            try
            {
                No1Dbl = Convert.ToDouble(No1Str);
                No2Dbl = Convert.ToDouble(No2Str);
            }
            catch
            {
                ResultLabel.Text = "Please give correct value";
                return;
            }
            double ResultDbl;

            ResultDbl = No1Dbl * No2Dbl;

            string ResultStr;

            ResultStr = Convert.ToString(ResultDbl);
            ResultLabel.Text = "Result: " + ResultStr;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string No1Str;
            string No2Str;

            No1Str = textBox1.Text;
            No2Str = textBox2.Text;

            double No1Dbl;
            double No2Dbl;

            try
            {
                No1Dbl = Convert.ToDouble(No1Str);
                No2Dbl = Convert.ToDouble(No2Str);
            }
            catch
            {
                ResultLabel.Text = "Please give correct value";
                return;
            }
            double ResultDbl;

            ResultDbl = No1Dbl - No2Dbl;

            string ResultStr;

            ResultStr = Convert.ToString(ResultDbl);
            ResultLabel.Text = "Result: " + ResultStr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string No1Str;
            string No2Str;

            No1Str = textBox1.Text;
            No2Str = textBox2.Text;

            double No1Dbl;
            double No2Dbl;

            try
            {
                No1Dbl = Convert.ToDouble(No1Str);
                No2Dbl = Convert.ToDouble(No2Str);
            }
            catch
            {
                ResultLabel.Text = "Please give correct value";
                return;
            }
            double ResultDbl;

            ResultDbl = No1Dbl / No2Dbl;

            string ResultStr;

            ResultStr = Convert.ToString(ResultDbl);
            ResultLabel.Text = "Result: " + ResultStr;
        }
    }
}
