using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_calculos_1
{
    public partial class Form1 : Form
    {
        double v1, v2, calculo;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_sub_Click(object sender, EventArgs e)
        {
            converter();
            calculo = v1 - v2;
            tb_resultado.Text = calculo.ToString();
        }

        private void bt_div_Click(object sender, EventArgs e)
        {
            converter();
            calculo = v1 / v2;
            tb_resultado.Text = calculo.ToString();
        }

        private void bt_mult_Click(object sender, EventArgs e)
        {
            converter();
            calculo = v1 * v2;
            tb_resultado.Text = calculo.ToString();
        }

        private void bt_restodivisao_Click(object sender, EventArgs e)
        {
            converter();
            calculo = v1 % v2;
            tb_resultado.Text = calculo.ToString();
        }

        private void bt_soma_Click(object sender, EventArgs e)
        {
            converter();
            calculo = v1 + v2;
            tb_resultado.Text = calculo.ToString();
        }

        private void converter()
        {
            try
            {
                v1 = double.Parse(tb_v1.Text);
                v2 = double.Parse(tb_v2.Text);
            }catch(Exception erro)
            {
                MessageBox.Show("Não foi possível converter, erro = "+ erro.Message);
            }
        }
    }
}
