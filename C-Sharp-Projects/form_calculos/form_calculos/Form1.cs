using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_calculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lb_valor1_Click(object sender, EventArgs e)
        {

        }

        private void bt_soma_Click(object sender, EventArgs e)
        {
            double v1, v2, soma;
            v1 = double.Parse(tb_v1.Text);
            v2 = double.Parse(tb_v2.Text);
            soma = v1 + v2;
            tb_resultado.Text = soma.ToString();
        }

        private void bt_sub_Click(object sender, EventArgs e)
        {
            double v1, v2, sub;
            v1 = double.Parse(tb_v1.Text);
            v2 = double.Parse(tb_v2.Text);
            sub = v1 - v2;
            tb_resultado.Text = sub.ToString();
        }

        private void bt_div_Click(object sender, EventArgs e)
        {
            double v1, v2, div;
            v1 = double.Parse(tb_v1.Text);
            v2 = double.Parse(tb_v2.Text);
            div = v1 / v2;
            tb_resultado.Text = div.ToString();
        }

        private void bt_mult_Click(object sender, EventArgs e)
        {
            double v1, v2, mult;
            v1 = double.Parse(tb_v1.Text);
            v2 = double.Parse(tb_v2.Text);
            mult = v1 * v2;
            tb_resultado.Text = mult.ToString();
        }

        private void bt_restodivisao_Click(object sender, EventArgs e)
        {
            double v1, v2, resto;
            v1 = double.Parse(tb_v1.Text);
            v2 = double.Parse(tb_v2.Text);
            resto = v1 % v2;
            tb_resultado.Text = resto.ToString();
        }
    }
}
