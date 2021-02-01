using Estacionamento.AppUtil;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace Estacionamento.View.Relatorio
{
    public partial class frmRelatorio : Form
    {
        private DataTable dataTable = new DataTable();

        public frmRelatorio()
        {
            InitializeComponent();

            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = Text;
            dataTable = null;
        }

        private void btnRelCadUsuario_Click(object sender, EventArgs e)
        {
            frmRelCadUsuario frm = new frmRelCadUsuario();
            frm.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRelatorio_Resize(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void btnRelCadPessoas_Click(object sender, EventArgs e)
        {
            frmRelCadPessoas frm = new frmRelCadPessoas();
            frm.ShowDialog();
        }

        private void btnCadUsuario_Click(object sender, EventArgs e)
        {
            frmRelFormaPagto frm = new frmRelFormaPagto();
            frm.ShowDialog();
        }

        private void btnParametros_Click(object sender, EventArgs e)
        {
            frmRelMarca frm = new frmRelMarca();
            frm.ShowDialog();
        }

        private void btnFormaPagto_Click(object sender, EventArgs e)
        {
            frmRelModelo frm = new frmRelModelo();
            frm.ShowDialog();
        }

        private void btnMovimentacao_Click(object sender, EventArgs e)
        {
            frmRelMovimentacao frm = new frmRelMovimentacao();
            frm.ShowDialog();
        }
    }
}
