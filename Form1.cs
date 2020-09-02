using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace down
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double speed = Convert.ToDouble(textBox1.Text) * 3600; //download speed entry
            double size = Convert.ToDouble(textBox2.Text) * 1024; //file size entry
            double time = size / speed; //the proccess to calculate the time that is left
            time = Math.Round(time, 2);


            var timeSpan = TimeSpan.FromHours(time); //converting the double to timespan
            int hours = timeSpan.Hours;
            int minutes = timeSpan.Minutes;


            textBox3.Text =Convert.ToString(hours)+" Hours "+Convert.ToString(minutes)+" Minutes" ;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
