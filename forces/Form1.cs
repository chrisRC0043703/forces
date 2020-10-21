using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
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
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }
        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }
        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }
        double acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }
        double tan(double x)
        {
            return (Math.Tan(x * Math.PI / 180.0));
        }
        double atan(double x)
        {
            return (Math.Atan(x) * 180 / Math.PI);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //use try -catch to avoid input errors
            try
            {
                //read vaues for force and angle from textboxes 

                double Force = double.Parse(textBox2.Text);
                double Angle = double.Parse(textBox1.Text);
                //calculate Fx and Fy using equations Fx = Fcos and Fy = Fsin
                double Fx = Force * cos(Angle);
                double Fy = Force * sin(Angle);
                //Output solutions to label1 and label2
                label1.Text = "Fx = " + Fx;
                label2.Text = "Fy = " + Fy;
            }
            catch
            {
                MessageBox.Show("Error on input");
                        }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //use try -catch to stop input errors
            try
            {
                //read values from textbox
                double Fx = double.Parse(textBox4.Text);
                double Fy = double.Parse(textBox3.Text);
                //calculate Fx and Fy using equations Fx = Fcos and Fy = Fsin
                double Force = Math.Sqrt(Fx * Fx + Fy * Fy);
                double Angle = atan(Fy / Fx);
                //Output solutions to label7 and label3
                label7.Text = "Fx = " + Angle;
                label3.Text = "Fy = " + Force;
            }
            catch
            {
                MessageBox.Show("Error on input");
            }
        }
        
    }
}
