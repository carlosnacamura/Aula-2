using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_2
{
    public partial class Salas : Form
    {
        public Salas()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        { 
            txtNome.Text = "";
            txtAndar.Text = "";
            txtPredio.Text = "";
            chkLab.Checked = false;
            MessageBox.Show("Formulário limpo com sucesso","Mensagem");
        }
    }
}
