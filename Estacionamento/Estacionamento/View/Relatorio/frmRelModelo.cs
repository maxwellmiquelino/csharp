using Estacionamento.AppUtil;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Estacionamento.View.Relatorio
{
    public partial class frmRelModelo : Form
    {
        public frmRelModelo()
        {
            InitializeComponent();
            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void frmRelModelo_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = Text;

            // TODO: This line of code loads data into the 'dsViewModelo.vw_modelo' table. You can move, or remove it, as needed.
            this.vw_modeloTableAdapter.Fill(this.dsViewModelo.vw_modelo);

            this.rvModelo.RefreshReport();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
