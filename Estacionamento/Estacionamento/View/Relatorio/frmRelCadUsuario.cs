using Estacionamento.AppUtil;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Estacionamento.View.Relatorio
{
    public partial class frmRelCadUsuario : Form
    {
        public frmRelCadUsuario()
        {
            InitializeComponent();
            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void frmRelCadUsuario_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = Text;
            // TODO: This line of code loads data into the 'dataSet1.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.dataSet1.usuario);

            this.rvCadUsuario.RefreshReport();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
