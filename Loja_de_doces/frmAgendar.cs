using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_de_doces
{
    public partial class frmAgendar : Form
    {
        public frmAgendar()
        {
            InitializeComponent();
            DesabilitarCampos();
        }
        public void DesabilitarCampos()
        {
            txtComplemento.Enabled = false;
            txtEndereco.Enabled = false;
            txtNome.Enabled = false;
            txtValor.Enabled = false;
            mkbTelcel.Enabled = false;
            dtpPrazo.Enabled = false;
            btnCadastrar.Enabled = false;
            btnLimpar.Enabled = false;
            btnNovo.Enabled = true;
        }
        public void HabilitarCampos()
        {
            txtComplemento.Enabled=true;
            txtEndereco.Enabled=true;
            txtNome.Enabled=true;
            txtValor.Enabled=true;
            mkbTelcel.Enabled=true;
            dtpPrazo.Enabled=true;
            btnCadastrar.Enabled=true;
            btnLimpar.Enabled=true;
            btnNovo.Enabled = false;

        }
        public void LimparCampos()
        {
            txtValor.Clear();
            txtEndereco.Clear();
            txtNome.Clear();
            txtComplemento.Clear();
            mkbTelcel.Clear();
            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmTelainicial abrir = new frmTelainicial();
            abrir.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }
    }
}
