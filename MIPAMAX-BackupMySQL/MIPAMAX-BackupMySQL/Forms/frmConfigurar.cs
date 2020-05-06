using System;
using System.Windows.Forms;

namespace MIPAMAX_BackupMySQL.Forms
{
    public partial class frmConfigurar : Form
    {
        public frmConfigurar()
        {
            InitializeComponent();
        }

        private void btnMySQLGravar_Click(object sender, EventArgs e)
        {
            // Validação
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Favor conferir a senha.", "Erro na validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtAcessoSenha.Text != txtAcessoConfirmSenha.Text)
            {
                MessageBox.Show("Favor conferir a senha.", "Erro na validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            if (txtSistemaNomeArquivoZip.Text.Length == 0)
            {
                MessageBox.Show("Nome do arquivo ZIP não informado.", "Erro na validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSistemaNomeArquivoZip.Focus();
                return;
            }

            if (txtSistemaHorario.Text.Contains(":") == false && txtSistemaHorario.Text.Length > 0)
            {
                MessageBox.Show("Formato de hora inválido, favor verificar.", "Erro na validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSistemaHorario.Focus();
                return;
            }

            if (txtSistemaNomeArquivoZip.Text.Contains(".ZIP") == false)
                txtSistemaNomeArquivoZip.Text += ".ZIP";

            if (txtSistemaTempo.Text.Length == 0)
                txtSistemaTempo.Text = "0";
            // Fim da validação


            try
            {
                if (txtSistemaCaminhoBackup.Text.Length == 0)
                    txtSistemaCaminhoBackup.Text = Application.StartupPath;

                Properties.Settings.Default.serverhost = txtServerHost.Text;
                Properties.Settings.Default.defaultschema = txtDefaultSchema.Text;
                Properties.Settings.Default.username = txtUserName.Text;
                Properties.Settings.Default.password = txtPassword.Text;
                Properties.Settings.Default.porta = txtPorta.Text;
                Properties.Settings.Default.horario = txtSistemaHorario.Text;
                Properties.Settings.Default.tempo = int.Parse(txtSistemaTempo.Text);
                Properties.Settings.Default.caminhobackup = txtSistemaCaminhoBackup.Text;
                Properties.Settings.Default.arquivozip = txtSistemaNomeArquivoZip.Text;
                Properties.Settings.Default.caminhobackupalternativo = txtSistemaCaminhoBackupAlternativo.Text;
                Properties.Settings.Default.acessosenha = txtAcessoSenha.Text;
                Properties.Settings.Default.inicioautomatico = chkAcessoInicioAutomatico.Checked;
                Properties.Settings.Default.Save();
                this.Close();
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro na validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmConfigurar_Load(object sender, EventArgs e)
        {
            // Inativa todos os panel
            pMySQL.Visible = false;
            pSistema.Visible = false;
            pAcesso.Visible = false;

            // Carrega as confguracoes
            txtServerHost.Text = Properties.Settings.Default.serverhost;
            txtDefaultSchema.Text = Properties.Settings.Default.defaultschema;
            txtUserName.Text = Properties.Settings.Default.username;
            txtPassword.Text = Properties.Settings.Default.password;
            txtConfirmPassword.Text = txtPassword.Text;
            txtPorta.Text = Properties.Settings.Default.porta;
            txtSistemaHorario.Text = Properties.Settings.Default.horario.ToString();
            txtSistemaTempo.Text = Properties.Settings.Default.tempo.ToString();
            txtSistemaCaminhoBackup.Text = Properties.Settings.Default.caminhobackup;
            txtSistemaNomeArquivoZip.Text = Properties.Settings.Default.arquivozip;
            txtSistemaCaminhoBackupAlternativo.Text = Properties.Settings.Default.caminhobackupalternativo;
            txtAcessoSenha.Text = Properties.Settings.Default.acessosenha;
            txtAcessoConfirmSenha.Text = txtAcessoSenha.Text;
            chkAcessoInicioAutomatico.Checked = Properties.Settings.Default.inicioautomatico;

            if (txtSistemaNomeArquivoZip.Text.Contains(".ZIP") == false)
                txtSistemaNomeArquivoZip.Text += ".ZIP";
        }

        private void tvwMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch(tvwMenu.SelectedNode.Text.ToString())
            {
                case "MySQL":
                    pAcesso.Visible = false;
                    pMySQL.Visible = true;
                    pSistema.Visible = false;
                    break;

                case "Sistema":
                    pAcesso.Visible = false;
                    pMySQL.Visible = false;
                    pSistema.Visible = true;
                    break;
                case "Acesso":
                    pAcesso.Visible = true;
                    pMySQL.Visible = false;
                    pSistema.Visible = false;
                    break;
            }
        }

        private void frmConfigurar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void btnSistemaCaminhoBackup_Click(object sender, EventArgs e)
        {
            fbdCaminhoBackup.RootFolder = Environment.SpecialFolder.MyComputer;
            fbdCaminhoBackup.ShowDialog();

            if (fbdCaminhoBackup.SelectedPath.ToString().Length > 0)
                txtSistemaCaminhoBackup.Text = fbdCaminhoBackup.SelectedPath.ToString();
        }

        private void btnSistemaCaminhoBackupAlternativo_Click(object sender, EventArgs e)
        {
            fbdCaminhoBackupAlternativo.RootFolder = Environment.SpecialFolder.MyComputer;
            fbdCaminhoBackupAlternativo.ShowDialog();

            if (fbdCaminhoBackupAlternativo.SelectedPath.ToString().Length > 0)
                txtSistemaCaminhoBackupAlternativo.Text = fbdCaminhoBackupAlternativo.SelectedPath.ToString();
        }
    }
}
