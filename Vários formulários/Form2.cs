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
    public partial class FormSegundo : Form
    {
        public FormSegundo(String v)
        {
            InitializeComponent();
            txtCaixa.Text = v;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
