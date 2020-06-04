using CadastroClientes.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes.View
{
    public partial class frmPesquisa : Form
    {
        public frmPesquisa()
        {
            InitializeComponent();
        }

        private void frmPesquisa_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            dgvPesquisa.DataSource = PessoaController.listarPessoa();
        }
    }
}
