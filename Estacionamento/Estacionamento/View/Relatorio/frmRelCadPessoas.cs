using Estacionamento.AppUtil;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Estacionamento.View.Relatorio
{
    public partial class frmRelCadPessoas : Form
    {
        public frmRelCadPessoas()
        {
            InitializeComponent();
            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRelCadPessoas_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = Text;
            // TODO: This line of code loads data into the 'dsViewPessoa.vw_pessoa' table. You can move, or remove it, as needed.
            this.vw_pessoaTableAdapter.Fill(this.dsViewPessoa.vw_pessoa);

            this.rvRelCadPessoa.RefreshReport();
        }
    }
}
