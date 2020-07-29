using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_combo_box_metodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adicionar_cores();
        }

        private void adicionar_cores()
        {
            cb_cores.Items.Add("Rocho");
            cb_cores.Items.Add("Roza");
            cb_cores.Items.Add("Branco");
        }

        private void limpar()
        {
            cb_cores.Items.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_cores.Items[0].ToString());
        }
    }
}
