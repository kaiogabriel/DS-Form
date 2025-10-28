using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoADS
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        public void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtIdade.Enabled = false;
            txtCodigo.Enabled = false;
        }
        public void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtIdade.Enabled = true;
            txtCodigo.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.ResetText();
            txtIdade.ResetText();
            txtCodigo.ResetText();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }
    }
}
