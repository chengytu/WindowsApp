using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Focus
{
    public partial class Formdemo : Form
    {
        public Formdemo()
        {
            InitializeComponent();
        }

        private void Formdemo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            int a = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);


            textBox3.Text = a.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
