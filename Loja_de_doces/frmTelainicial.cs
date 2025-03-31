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
    public partial class frmTelainicial : Form
    {
        public frmTelainicial()
        {
            InitializeComponent();
        }

        private void btnAgendamento_Click(object sender, EventArgs e)
        {
            frmAgendar abrir = new frmAgendar();
            abrir.Show();
            this.Hide();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            frmPedidos abrir = new frmPedidos();
            abrir.Show(); 
            this.Hide();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos abrir = new frmProdutos();
            abrir.Show();
            this.Hide();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
