using Estacionamento.Controller;
using Estacionamento.View.Movto;
using System;
using System.Data;
using System.Windows.Forms;

namespace Estacionamento.AppUtil
{
    public partial class Pesquisar : Form
    {
        private DataTable dt;

        #region Variaveis Privadas
        string formCaption = string.Empty;

        #endregion


        public Pesquisar()
        {
            InitializeComponent();
        }

        private void Pesquisar_Load(object sender, EventArgs e)
        {
            this.Text = formCaption;
            dgvPesquisa.DataSource = dt;
            lblTitulo.Text = Text;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static void MostrarUsuario()
        {
            Pesquisar p = new Pesquisar();
            p.formCaption = "Pesquisa de Usuarios";
            p.dt = UsuarioController.listarUsuario();
            p.ShowDialog();
        }
        public static void MostrarFormaPagto()
        {
            Pesquisar p = new Pesquisar();
            p.formCaption = "Pesquisa de Formas de Pagamentos";
            p.dt = FormaPagtoController.listarFormaPagto();
            p.ShowDialog();
        }

        public static void MostrarPessoa()
        {
            Pesquisar p = new Pesquisar();
            p.formCaption = "Pesquisa de Pessoas";
            p.dt = PessoaController.listarPessoa();
            p.ShowDialog();
        }

        public static void MostrarConvenio()
        {
            Pesquisar p = new Pesquisar();
            p.formCaption = "Pesquisa de Convenios";
            p.dt = ConvenioController.listarConvenio();
            p.ShowDialog();
        }

        public static void MostrarMovtoPlaca()
        {
            Pesquisar p = new Pesquisar();
            p.formCaption = "Pesquisa de Veículos por Placa";
            p.dt = MovimentoController.listarMovtoPlacaAtivo();
            p.ShowDialog();
        }

        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (formCaption == "Pesquisa de Usuarios")
            {
                Properties.Settings.Default.sequencia = dgvPesquisa.CurrentRow.Cells["sequsuario"].Value.ToString();
                Properties.Settings.Default.Save();
                Close();
            }
            else if (formCaption == "Pesquisa de Formas de Pagamentos")
            {
                Properties.Settings.Default.sequencia = dgvPesquisa.CurrentRow.Cells["seqformapagto"].Value.ToString();
                Properties.Settings.Default.Save();
                Close();
            }
            else if (formCaption == "Pesquisa de Pessoas")
            {
                Properties.Settings.Default.sequencia = dgvPesquisa.CurrentRow.Cells["seqpessoa"].Value.ToString();
                Properties.Settings.Default.Save();
                Close();
            }
            else if (formCaption == "Pesquisa de Convenios")
            {
                Properties.Settings.Default.sequencia = dgvPesquisa.CurrentRow.Cells["seqconvenio"].Value.ToString();
                Properties.Settings.Default.Save();
                Close();
            }
            else if (formCaption == "Pesquisa de Veículos por Placa")
            {
                frmMovimento.modo = false;
                Properties.Settings.Default.sequencia = dgvPesquisa.CurrentRow.Cells["seqmovto"].Value.ToString();
                Properties.Settings.Default.Save();
                Close();
            }
        }
    }
}
