using Estacionamento.AppUtil;
using Estacionamento.Controller;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Estacionamento.View.Relatorio
{
    public partial class frmRelMovimentacao : Form
    {
        public frmRelMovimentacao()
        {
            InitializeComponent();
            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            CarregarComboBoxDtaMovimento();
        }

        private void CarregarComboBoxDtaMovimento()
        {
            cboDtaMovto.DataSource = MovimentoController.listarMovtoByDtamovimento().Tables[0];
            cboDtaMovto.DisplayMember = "dtamovimento";
            cboDtaMovto.ValueMember = "dtamovimento";
        }

        private void frmRelMovimentacao_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = Text;
            cboDtaMovto.Text = string.Empty;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(cboDtaMovto.Text == string.Empty)
            {
                Mensagem.Mostrar("Estacionamento", "Favor selecionar uma data!!!", "CONFIRMAR", 1);
                return;
            }

            try
            {
                vw_movimentoTableAdapter.FillByDtamovimento(
                    dsViewMovto.vw_movimento, 
                    new DateTime?((DateTime)(Convert.ChangeType(cboDtaMovto.Text.ToString(), 
                    typeof(DateTime)))));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //vw_movimentoTableAdapter.Fill(dsViewMovto.vw_movimento);
            rvMovto.RefreshReport();
        }

        private void fillByDtamovimentoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                vw_movimentoTableAdapter.FillByDtamovimento(dsViewMovto.vw_movimento, new DateTime?((DateTime)(Convert.ChangeType(dtamovimentoToolStripTextBox.Text, typeof(DateTime)))));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fillByFiltroDtaMovimentoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vw_movimentoTableAdapter.FillByFiltroDtaMovimento(dsViewMovto.vw_movimento, new DateTime?(((DateTime)(Convert.ChangeType(dtamovimentoToolStripTextBox.Text, typeof(DateTime))))));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
