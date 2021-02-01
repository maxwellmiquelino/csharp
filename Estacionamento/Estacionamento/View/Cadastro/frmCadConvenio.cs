using Estacionamento.AppUtil;
using Estacionamento.Controller;
using Estacionamento.Model;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Estacionamento.View
{
    public partial class frmCadConvenio : Form
    {
        private bool modo;

        public frmCadConvenio()
        {
            InitializeComponent();

            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

            LimparCampos();
            LiberarCampos(true, false, false);
            LiberarBotoes(true, false, true, true);
        }

        private void PesquisarConvenio(string seqconvenio)
        {
            modo = false;
            foreach (var convenios in ConvenioController.listarConvenioBySeqconvenio(seqconvenio))
            {
                txtSeqpessoa.Text = convenios.Seqpessoa.ToString();
                txtValor.Text = convenios.Valor.ToString();
            }
        }

        private void PesquisarPessoaByCnpjCpf(string seqpessoa)
        {
            modo = false;

            foreach (var pessoas in PessoaController.listarPessoabyCnpjCpf(seqpessoa))
            {
                txtSeqpessoa.Text = pessoas.Seqpessoa.ToString();
                txtRazaoNome.Text = pessoas.Razaonome.ToString();
            }

            txtRazaoNome.Focus();
        }

        private void LimparCampos()
        {
            txtSeqconvenio.Text = string.Empty;
            txtSeqpessoa.Text = string.Empty;
            txtRazaoNome.Text = string.Empty;
            txtValor.Text = string.Empty;
            Properties.Settings.Default.sequencia = string.Empty;
            Properties.Settings.Default.Save();
            modo = false;
        }

        private void LiberarCampos(bool seqconvenio, bool seqpessoa, bool valor)
        {
            txtSeqconvenio.Enabled = seqconvenio;
            txtSeqpessoa.Enabled = seqpessoa;
            txtValor.Enabled = valor;
        }

        private void LiberarBotoes(bool novo, bool gravar, bool pesquisar, bool limpar)
        {
            btnNovo.Enabled = novo;
            btnGravar.Enabled = gravar;
            btnPesquisar.Enabled = pesquisar;
            btnLimpar.Enabled = limpar;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCadConvenio_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = Text;
        }

        private void txtSeqpessoa_TextChanged(object sender, EventArgs e)
        {
            if (txtSeqpessoa.Text.Length == 0)
                txtRazaoNome.Text = string.Empty;
            else if (!modo)
            {
                if (txtSeqpessoa.Text.Length > 0)
                    PesquisarPessoa();
            }
        }

        private void txtSeqconvenio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Deixa digitar somente numero e usar BACKSPACE
            // *********************************************
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Deixa digitar somente numero e usar BACKSPACE
            // *********************************************
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Convenio convenio = new Convenio();
                convenio.Seqconvenio = int.Parse(txtSeqconvenio.Text);
                convenio.Seqpessoa = int.Parse(txtSeqpessoa.Text);
                //convenio.Pessoa.Razaonome = txtRazaoNome.Text;
                convenio.Valor = decimal.Parse(txtValor.Text);
                convenio.Ultnome = Properties.Settings.Default.ultnome;

                if (modo)
                {
                    if (ConvenioController.insert(convenio))
                    {
                        Mensagem.Mostrar("Sucesso !!!", "Dados inserido com sucesso !!!");
                    }
                }
                else
                {
                    if (ConvenioController.update(convenio))
                    {
                        Mensagem.Mostrar("Sucesso !!!", "Dados atualizado com sucesso !!!");
                    }
                }
                LimparCampos();
                LiberarCampos(true, false, false);
                LiberarBotoes(true, false, true, true);
            }
        }

        private bool ValidarFormulario()
        {
            bool retorno = true;

            if (txtSeqpessoa.Text.Length == 0)
                retorno = false;

            if (txtValor.Text.Length == 0)
                retorno = false;

            return retorno;
        }

        private void txtSeqpessoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Deixa digitar somente numero e usar BACKSPACE
            // *********************************************
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtSeqpessoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return ||
                e.KeyCode == Keys.Tab)
            {

            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            LiberarCampos(false, true, true);
            LiberarBotoes(false, true, false, true);
            modo = true;
            txtSeqconvenio.Text = ConvenioController.GetSeqConvenio().ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            LiberarCampos(true, false, false);
            LiberarBotoes(true, false, true, true);
        }

        private void txtSeqpessoa_Validated(object sender, EventArgs e)
        {
            PesquisarPessoa();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtSeqconvenio.Text.Length > 0)
                PesquisarConvenio(txtSeqconvenio.Text);
            else
            {
                Pesquisar.MostrarConvenio();
                txtSeqconvenio.Text = Properties.Settings.Default.sequencia;
            }

            LiberarBotoes(false, true, false, true);
            LiberarCampos(false, true, true);
            txtSeqpessoa.Focus();
        }

        private void PesquisarPessoa()
        {
            try
            {
                if (txtSeqpessoa.Text.Length > 10 && txtSeqpessoa.Text.Length <= 14)
                {
                    PesquisarPessoaByCnpjCpf(txtSeqpessoa.Text);
                    txtValor.Focus();
                }
                else
                {
                    foreach (var pessoa in PessoaController.listarPessoaBySeqpessoa(txtSeqpessoa.Text))
                    {
                        txtSeqpessoa.Text = pessoa.Seqpessoa.ToString();
                        txtRazaoNome.Text = pessoa.Razaonome.ToString();
                    }
                }
            }
            catch (Exception erro)
            {
                Mensagem.Mostrar("Erro", erro.Message, "CONFIRMAR", 1);
            }
        }

        private void txtSeqconvenio_TextChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.sequencia.Length > 0)
                PesquisarConvenio(Properties.Settings.Default.sequencia);
        }

        private void frmCadConvenio_Resize(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }
    }
}
