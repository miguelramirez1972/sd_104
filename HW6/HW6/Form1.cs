using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW6
{
    public partial class Form1 : Form
    {
        double wt;
        double ht;
        double Rlts;

        public Form1()
        {
            InitializeComponent();
        }

        private void Weight_TextChanged(object sender, EventArgs e)
        {
            
            if (!double.TryParse(Weight.Text, out wt))
            {

                MessageBox.Show ("Not Valid.  Must be a rational number.  Enter again: ");

            }
        }

        private void Height_TextChanged(object sender, EventArgs e)
        {
            
            if(!double.TryParse(Height.Text, out ht))
            {
                MessageBox.Show("Not Valid.  Height must be a rational number in inches.  Enter again: ");
            }

        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            //calculations
            Rlts = (wt * 703) / (ht * ht);
            //issues result and message

            if (Rlts < 18.5)
            {
                Results.Text="BMI < 18.5 - Underweight";
            }
            else if (Rlts <= 24.9)
            {
                Results.Text="BMI between 18.5 and 24.9 - Normal";
            }
            else if (Rlts <= 29.9)
            {
                Results.Text = "BMI between 25 and 29.99 - Overweight";
            }
            else
            {
                Results.Text = "BMI >= 30 - Obese";
            }

        }

    }
}
