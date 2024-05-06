namespace TestarEnvioEmail
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblAguarde = new System.Windows.Forms.Label();
            this.btnAnexo = new System.Windows.Forms.Button();
            this.btnGravarConfig = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.chkHTML = new System.Windows.Forms.CheckBox();
            this.chkSSL = new System.Windows.Forms.CheckBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtRetorno = new System.Windows.Forms.TextBox();
            this.cmsRetorno = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.limparLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtSMTP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelForm.SuspendLayout();
            this.cmsRetorno.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMTP :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuário :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Senha :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "E-mail De :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Porta :";
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.statusStrip1);
            this.panelForm.Controls.Add(this.lblAguarde);
            this.panelForm.Controls.Add(this.btnAnexo);
            this.panelForm.Controls.Add(this.btnGravarConfig);
            this.panelForm.Controls.Add(this.btnEnviar);
            this.panelForm.Controls.Add(this.chkHTML);
            this.panelForm.Controls.Add(this.chkSSL);
            this.panelForm.Controls.Add(this.txtPort);
            this.panelForm.Controls.Add(this.txtRetorno);
            this.panelForm.Controls.Add(this.txtMensagem);
            this.panelForm.Controls.Add(this.txtAssunto);
            this.panelForm.Controls.Add(this.txtDestinatario);
            this.panelForm.Controls.Add(this.txtEmail);
            this.panelForm.Controls.Add(this.txtPass);
            this.panelForm.Controls.Add(this.txtUser);
            this.panelForm.Controls.Add(this.txtSMTP);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.label8);
            this.panelForm.Controls.Add(this.label7);
            this.panelForm.Controls.Add(this.label6);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(848, 672);
            this.panelForm.TabIndex = 5;
            // 
            // lblAguarde
            // 
            this.lblAguarde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAguarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAguarde.Location = new System.Drawing.Point(12, 267);
            this.lblAguarde.Name = "lblAguarde";
            this.lblAguarde.Size = new System.Drawing.Size(824, 56);
            this.lblAguarde.TabIndex = 11;
            this.lblAguarde.Text = "Enviando e-mail aguarde por favor . . .";
            this.lblAguarde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAguarde.Visible = false;
            // 
            // btnAnexo
            // 
            this.btnAnexo.Location = new System.Drawing.Point(387, 142);
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Size = new System.Drawing.Size(77, 26);
            this.btnAnexo.TabIndex = 10;
            this.btnAnexo.Text = "Anexo";
            this.btnAnexo.UseVisualStyleBackColor = true;
            this.btnAnexo.Click += new System.EventHandler(this.btnAnexo_Click);
            // 
            // btnGravarConfig
            // 
            this.btnGravarConfig.Location = new System.Drawing.Point(162, 171);
            this.btnGravarConfig.Name = "btnGravarConfig";
            this.btnGravarConfig.Size = new System.Drawing.Size(302, 35);
            this.btnGravarConfig.TabIndex = 10;
            this.btnGravarConfig.Text = "Gravar Configuração";
            this.btnGravarConfig.UseVisualStyleBackColor = true;
            this.btnGravarConfig.Click += new System.EventHandler(this.btnGravarConfig_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(304, 142);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(77, 26);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // chkHTML
            // 
            this.chkHTML.AutoSize = true;
            this.chkHTML.Location = new System.Drawing.Point(227, 144);
            this.chkHTML.Name = "chkHTML";
            this.chkHTML.Size = new System.Drawing.Size(71, 24);
            this.chkHTML.TabIndex = 6;
            this.chkHTML.Text = "HTML";
            this.chkHTML.UseVisualStyleBackColor = true;
            // 
            // chkSSL
            // 
            this.chkSSL.AutoSize = true;
            this.chkSSL.Location = new System.Drawing.Point(162, 144);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(59, 24);
            this.chkSSL.TabIndex = 6;
            this.chkSSL.Text = "SSL";
            this.chkSSL.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(99, 142);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(57, 26);
            this.txtPort.TabIndex = 5;
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitarNumeros);
            // 
            // txtRetorno
            // 
            this.txtRetorno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRetorno.ContextMenuStrip = this.cmsRetorno;
            this.txtRetorno.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetorno.Location = new System.Drawing.Point(470, 14);
            this.txtRetorno.Multiline = true;
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.ReadOnly = true;
            this.txtRetorno.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRetorno.Size = new System.Drawing.Size(365, 633);
            this.txtRetorno.TabIndex = 5;
            // 
            // cmsRetorno
            // 
            this.cmsRetorno.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparLogToolStripMenuItem});
            this.cmsRetorno.Name = "cmsRetorno";
            this.cmsRetorno.Size = new System.Drawing.Size(135, 26);
            // 
            // limparLogToolStripMenuItem
            // 
            this.limparLogToolStripMenuItem.Name = "limparLogToolStripMenuItem";
            this.limparLogToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.limparLogToolStripMenuItem.Text = "Limpar Log";
            this.limparLogToolStripMenuItem.Click += new System.EventHandler(this.limparLogToolStripMenuItem_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMensagem.Location = new System.Drawing.Point(12, 316);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(452, 331);
            this.txtMensagem.TabIndex = 9;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(12, 264);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(452, 26);
            this.txtAssunto.TabIndex = 8;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtDestinatario.Location = new System.Drawing.Point(12, 212);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(452, 26);
            this.txtDestinatario.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(99, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(365, 26);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(99, 78);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(365, 26);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtUser.Location = new System.Drawing.Point(99, 46);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(365, 26);
            this.txtUser.TabIndex = 2;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // txtSMTP
            // 
            this.txtSMTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtSMTP.Location = new System.Drawing.Point(100, 14);
            this.txtSMTP.Name = "txtSMTP";
            this.txtSMTP.Size = new System.Drawing.Size(364, 26);
            this.txtSMTP.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mensagem";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Assunto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Destinatário";
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.Filter = "Todos os Arquivos|*.*";
            this.ofdArquivo.Title = "Selecionar Arquivo";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 650);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(848, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(241, 17);
            this.toolStripStatusLabel1.Text = "Desenvolvido por Maxwell Duarte Miquelino";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 672);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste de E-mail";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.cmsRetorno.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtSMTP;
        private System.Windows.Forms.CheckBox chkSSL;
        private System.Windows.Forms.TextBox txtRetorno;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.CheckBox chkHTML;
        private System.Windows.Forms.Button btnAnexo;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
        private System.Windows.Forms.ContextMenuStrip cmsRetorno;
        private System.Windows.Forms.ToolStripMenuItem limparLogToolStripMenuItem;
        private System.Windows.Forms.Label lblAguarde;
        private System.Windows.Forms.Button btnGravarConfig;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

