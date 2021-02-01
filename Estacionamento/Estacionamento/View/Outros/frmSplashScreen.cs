using Estacionamento.AppUtil;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Estacionamento.View
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();

            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        static void Rotina()
        {
            BancoDados.ExisteArquivoBD();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {

            lblMsg.Text = "Gestor para estacionamento de veículos";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Thread verificaBD = new Thread(Rotina);
                lblMsg.Text = "Configurando o banco de dados pela primeira vez ...";
                //inicia a thread
                verificaBD.Start();
                //aguarda o término da thread
                verificaBD.Join();
                timer1.Enabled = false;
                frmLogin frm = new frmLogin();
                frm.Show();
                Hide();

            }
            catch (Exception erro)
            {
                Funcao.GravarLog(sender.ToString() + erro.Message);
            }
        }
    }
}
