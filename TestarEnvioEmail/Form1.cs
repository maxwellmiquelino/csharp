using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace TestarEnvioEmail
{
    public partial class Form1 : Form
    {
        private string vsAnexo;
        private string vsArquivoJson = $"{Application.StartupPath}\\configuracao.json";

        public Form1()
        {
            InitializeComponent();
        }

        private void DigitarNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != Convert.ToChar(Keys.Back) &&
                e.KeyChar != Convert.ToChar(Keys.Space))
            {
                e.Handled = true;
            }
        }
        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            lblAguarde.Visible = true;
            lblAguarde.BringToFront();
            panelForm.Enabled = false;
            //txtRetorno.Text += $"{DateTime.Now.ToString()} - Enviando do E-mail aguarde\r\n";
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(txtDestinatario.Text);
                mail.From = new MailAddress(txtEmail.Text, "Teste de Envio", System.Text.Encoding.UTF8);
                mail.Subject = txtAssunto.Text;
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                mail.Body = txtMensagem.Text;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = chkHTML.Checked;
                if (!string.IsNullOrEmpty(vsAnexo))
                {
                    mail.Attachments.Add(new Attachment(vsAnexo));
                }

                //mail.Priority = MailPriority.High; //Prioridade do E-Mail

                SmtpClient client = new SmtpClient();  //Adicionando as credenciais do seu e-mail e senha:
                client.Credentials = new System.Net.NetworkCredential(txtEmail.Text, txtPass.Text);
                client.Port = Int32.Parse(txtPort.Text); // Esta porta é a utilizada pelo Gmail para envio
                client.Host = txtSMTP.Text; //Definindo o provedor que irá disparar o e-mail
                client.EnableSsl = chkSSL.Checked; //Gmail trabalha com Server Secured Layer
                await client.SendMailAsync(mail);
                txtRetorno.Text += $"{DateTime.Now.ToString()} - Envio do E-mail com sucesso\r\n";
                lblAguarde.Visible = false;
                panelForm.Enabled = true;
            }
            catch (Exception ex)
            {
                txtRetorno.Text += $"{DateTime.Now.ToString()} - Ocorreu um erro ao enviar : {ex.Message}\r\n";
                lblAguarde.Visible = false;
                panelForm.Enabled = true;
            }
        }

        private void btnAnexo_Click(object sender, EventArgs e)
        {
            ofdArquivo.ShowDialog();
            vsAnexo = string.Empty;
            if (!string.IsNullOrEmpty(ofdArquivo.FileName.ToString()))
            {
                vsAnexo = ofdArquivo.FileName.ToString();
                txtRetorno.Text += $"{DateTime.Now.ToString()} - Anexo : {vsAnexo} \r\n";
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Text = txtUser.Text;
        }

        private void limparLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRetorno.Text = string.Empty;
            vsAnexo = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblAguarde.Visible = false;
            vsAnexo = string.Empty;

            if (File.Exists(vsArquivoJson))
            {
                string jsonString = File.ReadAllText(vsArquivoJson);
                ConfiguracaoEmail email  = JsonConvert.DeserializeObject<ConfiguracaoEmail>(jsonString);
                txtSMTP.Text = email.Domain;
                txtUser.Text = email.User;
                txtPass.Text = email.Password;
                txtEmail.Text = email.EmailAdress;
                txtPort.Text = email.Port.ToString();
                chkSSL.Checked = email.SecuritySSL;
                chkHTML.Checked = email.HtmlBody;
                txtDestinatario.Text = email.From;
                txtAssunto.Text = email.Subject;
                txtRetorno.Text += "Configuração carregado com sucesso !!!\r\n";
            }
        }

        private void btnGravarConfig_Click(object sender, EventArgs e)
        {
            ConfiguracaoEmail email = new ConfiguracaoEmail();
            email.Domain = txtSMTP.Text;
            email.User = txtUser.Text;
            email.Password = txtPass.Text;
            email.EmailAdress = txtEmail.Text;
            email.Port = int.Parse(txtPort.Text);
            email.SecuritySSL = chkSSL.Checked;
            email.HtmlBody = chkHTML.Checked;
            email.From = txtDestinatario.Text;
            email.Subject = txtAssunto.Text;

            string conteudoJson = JsonConvert.SerializeObject(email, Formatting.Indented);
            File.WriteAllText(vsArquivoJson, conteudoJson);
        }
    }
}