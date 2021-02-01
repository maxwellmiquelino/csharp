using Estacionamento.AppUtil;
using Estacionamento.Controller;
using Estacionamento.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Estacionamento.View
{
    public partial class frmCadFormaPagto : Form
    {
        private bool modo;
        public frmCadFormaPagto()
        {
            InitializeComponent();

            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

            LimparCampos();
            LiberarCampos(true, false, false);
            LiberarBotoes(true, false, true, true);
        }

        private void LimparCampos()
        {
            txtSeqformapagto.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            chkAtivo.Checked = false;
            Properties.Settings.Default.sequencia = string.Empty;
            Properties.Settings.Default.Save();
            modo = false;
        }

        private void LiberarCampos(bool seqformapagto, bool descricao, bool ativo)
        {
            txtSeqformapagto.Enabled = seqformapagto;
            txtDescricao.Enabled = descricao;
            chkAtivo.Enabled = ativo;
        }

        private void LiberarBotoes(bool novo, bool gravar, bool pesquisar, bool limpar)
        {
            btnNovo.Enabled = novo;
            btnGravar.Enabled = gravar;
            btnPesquisar.Enabled = pesquisar;
            btnLimpar.Enabled = limpar;
        }

        private void PesquisarFormaPagto(string seqformapagto)
        {
            modo = false;

            foreach (var formaPagto in FormaPagtoController.listarFormaPagtoBySeqformapagto(seqformapagto))
            {
                txtSeqformapagto.Text = formaPagto.Seqformapagto.ToString();
                txtDescricao.Text = formaPagto.Descricao.ToString();
                chkAtivo.Checked = formaPagto.Ativo;
            }

            LiberarBotoes(false, true, false, true);
            LiberarCampos(false, true, true);
            txtDescricao.Focus();
        }

        private void frmCadFormaPagto_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = Text;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            LiberarCampos(false, true, true);
            LiberarBotoes(false, true, false, true);
            modo = true;
            txtDescricao.Focus();
            txtSeqformapagto.Text = FormaPagtoController.GetSeqFormaPagto().ToString();
            chkAtivo.Checked = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            LiberarCampos(true, false, false);
            LiberarBotoes(true, false, true, true);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                FormaPagto formaPagto = new FormaPagto();
                formaPagto.Seqformapagto = int.Parse(txtSeqformapagto.Text);
                formaPagto.Descricao = txtDescricao.Text;
                formaPagto.Ativo = chkAtivo.Checked;
                formaPagto.Ultnome = Properties.Settings.Default.ultnome;

                if (modo)
                {
                    if (FormaPagtoController.insert(formaPagto))
                    {
                        Mensagem.Mostrar("Sucesso !!!", "Dados inserido com sucesso !!!");
                    }
                }
                else
                {
                    if (FormaPagtoController.update(formaPagto))
                    {
                        Mensagem.Mostrar("Sucesso !!!", "Dados atualizado com sucesso !!!");
                    }
                }
                LimparCampos();
                LiberarCampos(true, false, false);
                LiberarBotoes(true, false, true, true);
            }
            else
            {
                Mensagem.Mostrar("Erro na validação", "Favor verificar os dados do cadastro!!!", "CONFIRMAR", 1);
            }
        }

        private bool ValidarFormulario()
        {
            bool retorno = true; ;

            if (txtDescricao.Text.Length == 0)
                retorno = false;

            return retorno;
        }

        private void txtSeqformapagto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Deixa digitar somente numero e usar BACKSPACE
            // *********************************************
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtSeqformapagto.Text.Length > 0)
            {
                PesquisarFormaPagto(txtSeqformapagto.Text);
            }
            else
            {
                Pesquisar.MostrarFormaPagto();
                txtSeqformapagto.Text = Properties.Settings.Default.sequencia;
            }
            modo = false;
        }

        private void txtSeqformapagto_TextChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.sequencia.Length > 0)
            {
                PesquisarFormaPagto(txtSeqformapagto.Text);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCadFormaPagto_Resize(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }
    }
}
