using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vários_formulários
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Por favor insira o nome no campo!!", "Aviso!", MessageBoxButtons.OK);
                txtNome.Focus();
                return;
            }

            // else é opcional por causa do return

            txtCaixa.Text += txtNome.Text + ", ";
            txtNome.Clear();
            txtNome.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCaixa.Clear();
            txtNome.Focus();
        }

        private void btnAbrirSegundoForm_Click(object sender, EventArgs e)
        {
            FormSegundo formSegundo = new FormSegundo(txtCaixa.Text);
            formSegundo.ShowDialog();
        }
    }
}
