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
    public partial class form_manipulacao_strings : Form
    {
        public form_manipulacao_strings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = txt_String1.Text.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = txt_String1.Text.ToLower();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = txt_String1.Text.Substring(0, 5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int posicao = txt_String1.Text.IndexOf("Bruno");
            lbl_resultado.Text = posicao.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txt_String1.Text.StartsWith("B"))
            {
                MessageBox.Show("Começa com B");
            }
            else
                MessageBox.Show("Não começa com B");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txt_String1.Text.StartsWith("r"))
            {
                MessageBox.Show("Termina com r");
            }
            else
                MessageBox.Show("Não termina com r");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = txt_String1.Text.PadLeft(30, '*');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = txt_String1.Text.PadRight(30, '*');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = txt_String1.Text.Trim();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = txt_String1.Text.TrimStart();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = txt_String1.Text.TrimEnd();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string[] array_texto = txt_String1.Text.Split(',');

            int array_tamanhho = array_texto.Length;

            for(int i = 0; i< array_tamanhho; i++)
            {
                MessageBox.Show(array_texto[i]);
            }
            lbl_resultado.Text = String.Join(" ", array_texto);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string[] nomes_array = { "Bruno", "Cesar", "Dias" };
            string nome_string = String.Join(" ", nomes_array);
            lbl_resultado.Text = nome_string.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("O conteudo do TextBox é: {0}", txt_String1.Text));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // {0:D} Indica que o parametro seja obrigatoriamente um inteiro
            MessageBox.Show(String.Format("Minha idade é {0:D}", 23));
            // {0:S} Indica que o parametro seja obrigatoriamente um inteiro
            MessageBox.Show(String.Format("Minha idade é {0:S}", "23"));
        }
    }
}
