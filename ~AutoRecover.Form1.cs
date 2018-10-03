using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1051
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                String aclass, bclass, cclass;
                double A, B, C;
                aclass = textBox3.Text;
                bclass = textBox4.Text;
                cclass = textBox5.Text;

                try
                {
                    A = double.Parse(aclass);
                    B = double.Parse(bclass);
                    C = double.Parse(cclass);
                    double cal;
                    cal = A * 15;
                    textBox4.Text = cal.ToString("c");

                    double cal1;
                    cal1 = B * 12;
                    textBox5.Text = cal.ToString("c");

                    double cal2;
                    cal = C * 9;
                    textBox.Text = cal.ToString("c");

                
                { 
                  
                    MessageBox.Show("Please put all values accrately");
                }
                {


                }
            


            private void button2_Click(object sender, EventArgs e)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }

            private void button3_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }

}
    }
}
