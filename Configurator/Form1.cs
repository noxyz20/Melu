using DataContracts;
using Services;
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

namespace Configurator
{
    public partial class Form1 : Form
    {

        private List<Functoid> functoids = new List<Functoid>();
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Colonne1");
            listBox1.Items.Add("Colonne2");
            listBox1.Items.Add("Colonne3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var funct = comboBox1.SelectedItem;
            Type f = funct as Type;
            var instance = Activator.CreateInstance(f) as Functoid;
            var inColumnsNames = listBox1.SelectedItems;
            var inColumns = new List<Column>();
            var outColumnsNames = textBox1.Text.Split(",");
            var outColumns = new List<Column>();
            var param = new Parameter()
            {
                value = textBox3.Text
            };
            foreach (String name in inColumnsNames)
            {
                inColumns.Add(new Column()
                {
                    name = name,
                    id = Guid.NewGuid()
                });
            }

            foreach (String name in outColumnsNames)
            {
                outColumns.Add(new Column()
                {
                    name = name,
                    id = Guid.NewGuid()
                });
            }
            instance.inColumns = inColumns;
            instance.outColumns = outColumns;
            instance.parameters = new List<Parameter>()
            {
                param
            };
            foreach (Column col in outColumns)
            {
                listBox2.Items.Add(col.name);
            }

            functoids.Add(instance);
            
            Console.WriteLine();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = FunctoidEnumerator.GetFunctoidClasses();
            comboBox1.DisplayMember = "name";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var template = new Template()
            {
                id = Guid.NewGuid(),
                name = textBox2.Text,
                functoids = functoids
            };

            var templateService = new TemplateService()
            {
                template = template
            };
            templateService.Serialize();
        }
    }
}
