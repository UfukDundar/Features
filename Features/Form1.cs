using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Features
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            car car1 = new car();
            car1.MotorPower = 2000;
            car1.Colour = Colours.Red;
            MessageBox.Show(("Vehicle Power: "+ car1.MotorPower).ToString() +  "Color: " + car1.Colour );
        }
    }
}
