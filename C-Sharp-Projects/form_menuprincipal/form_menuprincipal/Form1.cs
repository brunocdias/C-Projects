using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_menuprincipal
{
    public partial class Form1 : Form
    {
        DateTime data_hora;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;
            lb_data_hora.Text = "Data: " +data_hora.ToLongDateString() + "Hora: " + data_hora.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_data_hora frm_dt_hr = new form_data_hora();
            frm_dt_hr.Show();
        }

        private void dataEHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void checkBoxRadioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_checkbox_radiobutton frm_ckbx_rb = new form_checkbox_radiobutton();
            frm_ckbx_rb.Show();
        }

        private void máscarasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_mascaras frm_mask = new form_mascaras();
            frm_mask.Show();
        }

        private void stringsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_manipulacao_strings frm_string = new form_manipulacao_strings();
            frm_string.Show();
        }
    }
}
