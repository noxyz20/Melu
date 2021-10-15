﻿using Services;
using Services.ServiceContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var t = new TemplateService();
            var list = t.DeSerialize();

            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Name";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

    }
}
