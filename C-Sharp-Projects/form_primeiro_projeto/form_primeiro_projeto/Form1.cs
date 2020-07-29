using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_primeiro_projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            MessageBox.Show("Nome digitado = " + textBox1.Text, "Nome");
        }
    }
}
