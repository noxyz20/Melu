using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Configurator
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Colonne1");
            listBox1.Items.Add("Colonne2");
            listBox1.Items.Add("Colonne3");
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            listBox2.Items.Add(listBox1.SelectedItems);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
