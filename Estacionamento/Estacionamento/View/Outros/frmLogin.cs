using Estacionamento.AppUtil;
using Estacionamento.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Estacionamento.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            txtUsuario.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = Text;
            txtUsuario.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (UsuarioController.listarUsuarioByLogin(txtUsuario.Text.Trim(), Funcao.Encrypt(txtSenha.Text.Trim())))
            {
                Properties.Settings.Default.ultnome = txtUsuario.Text;
                Properties.Settings.Default.Save();
                frmPrincipal frm = new frmPrincipal();
                frm.Show();
                Close();
            }
            else
            {
                Mensagem.Mostrar("Erro na validação", "Usuário ou senha incorreto, favor verificar", 1);
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                btnOk.PerformClick();
        }
    }
}
