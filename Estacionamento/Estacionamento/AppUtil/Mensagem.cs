using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento.AppUtil
{
    public partial class Mensagem : Form
    {
        #region Variaveis Privadas
        string formCaption = string.Empty;
        string formPrompt = string.Empty;
        int alert = 0;
        string buttomCaption = string.Empty;
        #endregion

        public Mensagem()
        {
            InitializeComponent();
        }

        private void frmMensagem_Load(object sender, EventArgs e)
        {
            this.lblMsg.Text = formPrompt;
            this.Text = formCaption;
            lblTitulo.Text = formCaption;
            btnOK.Text = buttomCaption;

            if (alert == 0)
                panelCabecalho.BackColor = Color.SteelBlue;
            else
                panelCabecalho.BackColor = Color.Red;
        }

        /// <summary>
        /// Mostra mensagem na tela.
        /// </summary>
        /// <param name="titulo">Título da mensagem.</param>
        /// <param name="mensagem">Mensagem para o usuário.</param>
        /// <param name="botao">Texto do botão. Padrão é 'OK'</param>
        /// <param name="alerta">Tipo de alerta : 0 - Informação (padrão), 1 - Erro</param>
        public static void Mostrar(string titulo, string mensagem, string botao, int alerta = 0)
        {
            Mensagem msg = new Mensagem();
            msg.formCaption = titulo;
            msg.formPrompt = mensagem;
            msg.buttomCaption = botao;
            msg.alert = alerta;

            msg.ShowDialog();
        }

        /// <summary>
        /// Mostra mensagem na tela.
        /// </summary>
        /// <param name="titulo">Título da mensagem.</param>
        /// <param name="mensagem">Mensagem para o usuário.</param>
        /// <param name="alerta">Tipo de alerta : 0 - Informação (padrão), 1 - Erro</param>
        public static void Mostrar(string titulo, string mensagem, int alerta = 0)
        {
            Mensagem msg = new Mensagem();
            msg.formCaption = titulo;
            msg.formPrompt = mensagem;
            msg.buttomCaption = "OK";
            msg.alert = alerta;

            msg.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
