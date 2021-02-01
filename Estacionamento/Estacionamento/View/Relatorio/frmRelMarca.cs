using Estacionamento.AppUtil;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Estacionamento.View.Relatorio
{
    public partial class frmRelMarca : Form
    {
        public frmRelMarca()
        {
            InitializeComponent();
            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRelMarca_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = Text;

            // TODO: This line of code loads data into the 'dsMarca.marca' table. You can move, or remove it, as needed.
            this.marcaTableAdapter.Fill(this.dsMarca.marca);

            this.rvMarca.RefreshReport();
        }
    }
}
