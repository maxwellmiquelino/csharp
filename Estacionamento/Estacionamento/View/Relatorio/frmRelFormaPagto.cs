using Estacionamento.AppUtil;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Estacionamento.View.Relatorio
{
    public partial class frmRelFormaPagto : Form
    {
        public frmRelFormaPagto()
        {
            InitializeComponent();
            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void frmRelFormaPagto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsFormaPagto.formapagto' table. You can move, or remove it, as needed.
            this.formapagtoTableAdapter.Fill(this.dsFormaPagto.formapagto);
            lblTitulo.Text = Text;
            this.rvFormaPagto.RefreshReport();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
