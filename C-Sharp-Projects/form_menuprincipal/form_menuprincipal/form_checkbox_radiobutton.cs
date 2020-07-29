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
    public partial class form_checkbox_radiobutton : Form
    {
        public form_checkbox_radiobutton()
        {
            InitializeComponent();
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            if (cb_email.Checked == true)
                MessageBox.Show("Sim, confirma");
            else
                MessageBox.Show("Não, falso");
        }
    }
}
