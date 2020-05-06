using System;
using MIPAMAX_BackupMySQL.Forms;
using System.Windows.Forms;
using Ionic.Zip;
using MySql.Data.MySqlClient;
using System.Data;
using MIPAMAX_BackupMySQL.Classes;
using System.Text;
using System.IO;
using System.Threading;

namespace MIPAMAX_BackupMySQL
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        string camBkp, camBaseDir, dia;
        GerarLog log = new GerarLog();
        int AcessoSenha; // 0 - Configurar, 1 - Sair, 2 - Parar, 3 - Sair pelo Form
        int tempoDiario, tempoMinutos;
        bool cnxErro = false;

        /* Retorna o dia da semana para concatenar com o nome do Arquivo a ser Zipado
         * Ex.: SEGUNDA-BKP.ZIP
         */
        #region retornaDiaSemana
        private string retornaDiaSemana()
        {
            switch(DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    dia = "SEGUNDA-";
                    break;

                case DayOfWeek.Tuesday:
                    dia = "TERCA-";
                    break;

                case DayOfWeek.Wednesday:
                    dia = "QUARTA-";
                    break;

                case DayOfWeek.Thursday:
                    dia = "QUINTA-";
                    break;

                case DayOfWeek.Friday:
                    dia = "SEXTA-";
                    break;

                case DayOfWeek.Saturday:
                    dia = "SABADO-";
                    break;

                case DayOfWeek.Sunday:
                    dia = "DOMINGO-";
                    break;
            }

            return dia;
        }
        #endregion

        /* Inicia o backup e minimiza na bandeja do Windows
         * Tempo de uma tarefa para outra é de 1 minuto multiplicado
         * pela quantidade de minutos na tela de parametros
         */
        #region IniciarTarefa
        private void IniciarTarefa()
        {
            try
            {
                retornarCaminhoBackup();

                if (Properties.Settings.Default.tempo > 0)
                    tempoMinutos = 60000 * Properties.Settings.Default.tempo;

                tempoDiario = 60000;
                //tempoMinutos = 60000;

                btnIniciar.Enabled = false;
                btnParar.Enabled = true;

                Thread threadDiario = new Thread(tarefaDiario);
                threadDiario.Start();

                Thread threadMinutos = new Thread(tarefaMinutos);
                threadMinutos.Start();

                nicBandeja.Icon = Icon;
                nicBandeja.ShowBalloonTip(0);
                this.Hide();
            }
            catch (Exception ex)
            {
                log.criaLog("Erro\n\n" + ex.ToString());
                //MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region EncerrarAplicacao
        /// <summary>
        /// Função para encerrar a aplicação.
        /// </summary>
        private void EncerrarAplicacao()
        {
            if (MessageBox.Show("Deseja encerrar o aplicativo?",
                this.ProductName,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
                Application.ExitThread();
            }
            else
            {
                log.criaLog("Tentativa de fechar o aplicativo.");
            }
        }
        #endregion

        #region retornarCaminhoBackup
        /// <summary>
        /// Traz o caminho onde é gravado os dados do banco.
        /// </summary>
        private void retornarCaminhoBackup()
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection())
                {
                    log.criaLog("Conectando a base de dados.");
                    cnn.ConnectionString = "Server=" + Properties.Settings.Default.serverhost +
                        ";Database=" + Properties.Settings.Default.defaultschema +
                        ";Uid=" + Properties.Settings.Default.username +
                        ";Pwd=" + Properties.Settings.Default.password +
                        ";Port=" + Properties.Settings.Default.porta + ";";
                    cnn.Open();
                    log.criaLog("Base de dados conectado.");
                    MySqlDataAdapter da = new MySqlDataAdapter("SHOW VARIABLES WHERE variable_name = 'datadir'", cnn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tab");
                    camBkp = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                    log.criaLog("Guardado o caminho ( " + camBkp + " ) na variavel.");
                    cnxErro = false;
                }
            }
            catch (Exception ex)
            {
                log.criaLog("Erro\n\n" + ex.ToString());
                cnxErro = true;
                //MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region RetornarCaminhoBaseDir
        private void retornarCaminhoBasedir()
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection())
                {
                    log.criaLog("Conectando a base de dados.");
                    cnn.ConnectionString = "Server=" + Properties.Settings.Default.serverhost +
                        ";Database=" + Properties.Settings.Default.defaultschema +
                        ";Uid=" + Properties.Settings.Default.username +
                        ";Pwd=" + Properties.Settings.Default.password +
                        ";Port=" + Properties.Settings.Default.porta + ";";
                    cnn.Open();
                    log.criaLog("Base de dados conectado.");
                    MySqlDataAdapter da = new MySqlDataAdapter("SHOW VARIABLES WHERE variable_name = 'basedir'", cnn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tab");
                    camBaseDir = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                    log.criaLog("Guardado o caminho ( " + camBaseDir + " ) na variavel.");
                    cnxErro = false;
                }
            }
            catch (Exception ex)
            {
                log.criaLog("Erro\n\n" + ex.ToString());
                cnxErro = true;
                //MessageBox.Show(ex.ToString());
            }
        }
        #endregion 

        /// <summary>
        /// Função privada para geração do backup utilizando Thread
        /// </summary>
        private void TarefaBackupDiario()
        {
            //DateTime.Parse(DateTime.Now.Day.ToString("yyyyMMddHHmmss")
            if (cnxErro)
                retornarCaminhoBackup();

            string ArqZip = retornaDiaSemana() +
                               Properties.Settings.Default.arquivozip;
            string camArqZip = Properties.Settings.Default.caminhobackup + "\\" + ArqZip.Replace("--", "-");

            string camAlternativo = Properties.Settings.Default.caminhobackupalternativo + "\\" + ArqZip.Replace("--", "-");

            log.criaLog("Iniciando a compactação no arquivo.");
            ZipFile zip = new ZipFile(Encoding.Default);
            zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Default;
            zip.CompressionMethod = CompressionMethod.BZip2;
            zip.AddDirectory(camBkp);
            zip.Save(camArqZip);
            zip.Dispose();
            if (Properties.Settings.Default.caminhobackupalternativo.Length > 0)
            {
                File.Copy(camArqZip, camAlternativo);
            }
            log.criaLog("Arquivo compactado salvo com sucesso.");
        }

        // Função para criar o backup a cada minuto
        private void TarefaBackupMinutos()
        {
            if (cnxErro)
                retornarCaminhoBackup();

            string dta = DateTime.Parse(DateTime.Now.ToString()).ToString("yyyyMMddHHmm").ToString();
            string ArqZip = retornaDiaSemana() +
                            dta +
                            Properties.Settings.Default.arquivozip;

            string camArqZip = Properties.Settings.Default.caminhobackup + "\\" + ArqZip;

            string camAlternativo = Properties.Settings.Default.caminhobackupalternativo + "\\" + ArqZip;

            //string comando = @camBaseDir + @"bin\mysqldump.exe -u" + 
            //                 Properties.Settings.Default.username + 
            //                 "-p" + Properties.Settings.Default.password +
            //                 "--routines " + Properties.Settings.Default.defaultschema +
            //                 " > " + @Application.StartupPath + @"\" + dta + "-" + 
            //                 Properties.Settings.Default.defaultschema + "-bkp.sql";

            log.criaLog("Iniciando a compactação no arquivo.");
            //System.Diagnostics.Process proc = new System.Diagnostics.Process();
            //proc.EnableRaisingEvents = false;
            //proc.StartInfo.FileName = comando;
            //proc.Start();
            ZipFile zip = new ZipFile(Encoding.Default);
            zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Default;
            zip.CompressionMethod = CompressionMethod.BZip2;
            zip.AddDirectory(camBkp);
            zip.Save(camArqZip);
            zip.Dispose();
            if (Properties.Settings.Default.caminhobackupalternativo.Length > 0)
            {
                File.Copy(camArqZip, camAlternativo);
            }
            log.criaLog("Arquivo compactado salvo com sucesso.");
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            AcessoSenha = 0;
            pAcessoSenha.Visible = true;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            IniciarTarefa();
        }

        /// <summary>
        /// Executa a Thread em Loop infinito e aguardando o tempo que está na variável.
        /// </summary>
        public void tarefaDiario()
        {
            string HoraConfig, HoraAtual;
            
            while (true)
            {
                HoraConfig = Properties.Settings.Default.horario.ToString();
                HoraAtual = DateTime.Now.ToString("HH:mm");

                if (HoraConfig == HoraAtual)
                    TarefaBackupDiario();

                Thread.Sleep(tempoDiario);
            }
        }

        /// <summary>
        /// Executa a Thread em Loop infinito e aguardando o tempo que está na variável.
        /// </summary>
        public void tarefaMinutos()
        {
            while (true)
            {
                if (Properties.Settings.Default.tempo > 0)
                    TarefaBackupMinutos();

                Thread.Sleep(tempoMinutos);
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.username.Length > 0 &&
                Properties.Settings.Default.password.Length > 0)
            {
                retornarCaminhoBackup();
                //retornarCaminhoBasedir();
            }


            if (Properties.Settings.Default.inicioautomatico)
            {
                timer1.Enabled = true;
            }
            else
            {
                btnConfigurar.Enabled = true;
                btnIniciar.Enabled = true;
                btnParar.Enabled = false;
                btnSair.Enabled = true;
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            AcessoSenha = 2;
            pAcessoSenha.Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            AcessoSenha = 1;
            pAcessoSenha.Visible = true;
        }

        private void txtAcessoSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (txtAcessoSenha.Text != Properties.Settings.Default.acessosenha)
                {
                    MessageBox.Show("Senha não confere, favor verificar.", this.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtAcessoSenha.Text == Properties.Settings.Default.acessosenha && 
                    AcessoSenha == 0)
                {
                    txtAcessoSenha.Text = null;
                    pAcessoSenha.Visible = false;
                    frmConfigurar fConfig = new frmConfigurar();
                    fConfig.ShowDialog();
                }
                else if (txtAcessoSenha.Text == Properties.Settings.Default.acessosenha && 
                    AcessoSenha == 1)
                {
                    txtAcessoSenha.Text = null;
                    EncerrarAplicacao();
                }
                else if (txtAcessoSenha.Text == Properties.Settings.Default.acessosenha.ToString() &&
                    AcessoSenha == 2)
                {
                    try
                    {
                        tempoDiario = 0;
                        tempoMinutos = 0;
                        btnIniciar.Enabled = true;
                        btnParar.Enabled = false;
                        //nicBandeja.Dispose();
                        pAcessoSenha.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        log.criaLog("Erro\n\n" + ex.ToString());
                        //MessageBox.Show(ex.ToString());
                    }
                }
                else if (AcessoSenha == 3)
                {
                    Application.Exit();
                    Application.ExitThread();
                }
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                if (MessageBox.Show("Deseja encerrar o aplicativo?",
                    this.ProductName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    AcessoSenha = 3;
                    pAcessoSenha.Visible = true;
                }
                else
                {
                    e.Cancel = true;
                    log.criaLog("Tentativa de fechar o aplicativo.");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IniciarTarefa();
            timer1.Enabled = false;
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            //Verificando se WindowsState == Minimized
            if (this.WindowState == FormWindowState.Minimized)
            {
                nicBandeja.Icon = Icon;
                nicBandeja.ShowBalloonTip(0);
                this.Hide();
            }
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            log.criaLog("Aplicativo encerrado.");
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            AcessoSenha = 1;
            pAcessoSenha.Visible = true;
        }
    }
}
