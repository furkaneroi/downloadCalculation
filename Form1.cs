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
          
            double hiz = Convert.ToDouble(textBox1.Text)*3600;
            double size = Convert.ToDouble(textBox2.Text)*1024;
            double time =size / hiz;
            time = Math.Round(time, 2);
            textBox3.Text=time.ToString();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
