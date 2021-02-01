using Estacionamento.AppUtil;
using Estacionamento.Controller;
using Estacionamento.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Estacionamento.View
{
    public partial class frmCadUsuario : Form
    {
        private bool modo;

        public frmCadUsuario()
        {
            InitializeComponent();
            
            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

            LimparCampos();
            LiberarCampos(true, false, false, false, false, false);
            LiberarBotoes(true, false, true, true);
        }

        private void PesquisarUsuario(string sequsuario)
        {
            modo = false;

            foreach (var usuario in UsuarioController.listarUsuarioBySequsuario(sequsuario))
            {
                txtSequsuario.Text = usuario.Sequsuario.ToString();
                txtNome.Text = usuario.Nome.ToString();
                txtLogin.Text = usuario.Login.ToString();
                txtSenha.Text = usuario.Senha.ToString();
                txtConfSenha.Text = txtSenha.Text;
                chkAtivo.Checked = usuario.Ativo;
            }

            LiberarBotoes(false, true, false, true);
            LiberarCampos(false, true, true, true, true, true);
            txtNome.Focus();
        }

        private void LimparCampos()
        {
            txtSequsuario.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtConfSenha.Text = string.Empty;
            chkAtivo.Checked = false;
            Properties.Settings.Default.sequencia = string.Empty;
            Properties.Settings.Default.Save();
            modo = false;
        }

        private void LiberarCampos(bool sequsuario, bool nome, bool login, bool senha, bool confsenha, bool ativo)
        {
            txtSequsuario.Enabled = sequsuario;
            txtNome.Enabled = nome;
            txtLogin.Enabled = login;
            txtSenha.Enabled = senha;
            txtConfSenha.Enabled = confsenha;
            chkAtivo.Enabled = ativo;
        }

        private void LiberarBotoes(bool novo, bool gravar, bool pesquisar, bool limpar)
        {
            btnNovo.Enabled = novo;
            btnGravar.Enabled = gravar;
            btnPesquisar.Enabled = pesquisar;
            btnLimpar.Enabled = limpar;
        }

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = this.Text;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            LiberarBotoes(true, false, true, true);
            LiberarCampos(true, false, false, false, false, false);
        }

        private bool ValidarCamposFormulario()
        {
            bool retorno = true;

            if (txtNome.Text.Length == 0)
                retorno = false;

            if (txtLogin.Text.Length == 0)
                retorno = false;

            if (txtSenha.Text.Length == 0)
                retorno = false;

            if (txtConfSenha.Text.Length == 0)
                retorno = false;

            if (txtSenha.Text != txtConfSenha.Text)
                retorno = false;

            return retorno;
        }

        private void txtSequsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Deixa digitar somente numero e usar BACKSPACE
            // *********************************************
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            LiberarCampos(false, true, true, true, true, true);
            LiberarBotoes(false, true, false, true);
            modo = true;
            chkAtivo.Checked = true;
            txtNome.Focus();
            txtSequsuario.Text = UsuarioController.GetSeqUsuario().ToString();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            // Valida campos do formuário
            if (ValidarCamposFormulario())
            {
                Usuario usuario = new Usuario();
                usuario.Sequsuario = int.Parse(txtSequsuario.Text);
                usuario.Nome = txtNome.Text;
                usuario.Login = txtLogin.Text;
                usuario.Senha = Funcao.Encrypt(txtSenha.Text);
                usuario.Ativo = chkAtivo.Checked;
                usuario.Ultnome = Properties.Settings.Default.ultnome;

                if (modo)
                {
                    if (UsuarioController.insert(usuario))
                    {
                        Mensagem.Mostrar("Sucesso !!!", "Dados inserido com sucesso !!!");
                    }
                }
                else
                {
                    if (UsuarioController.update(usuario))
                    {
                        Mensagem.Mostrar("Sucesso !!!", "Dados atualizado com sucesso !!!");
                    }
                }
                LimparCampos();
                LiberarCampos(true, false, false, false, false, false);
                LiberarBotoes(true, false, true, true);
            }
            else
            {
                Mensagem.Mostrar("Erro na validação", "Favor verificar os dados do cadastro!!!", "CONFIRMAR", 1);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtSequsuario.Text.Length > 0)
            {
                PesquisarUsuario(txtSequsuario.Text);
            }
            else
            {
                Pesquisar.MostrarUsuario();
                txtSequsuario.Text = Properties.Settings.Default.sequencia;
            }
            modo = false;
        }

        private void txtSequsuario_TextChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.sequencia.Length > 0)
                PesquisarUsuario(txtSequsuario.Text);
        }

        private void frmCadUsuario_Resize(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }
    }
}
