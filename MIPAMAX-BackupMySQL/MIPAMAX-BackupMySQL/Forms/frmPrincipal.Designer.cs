namespace MIPAMAX_BackupMySQL
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pAcessoSenha = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAcessoSenha = new System.Windows.Forms.TextBox();
            this.nicBandeja = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMenuBandeja = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pAcessoSenha.SuspendLayout();
            this.cmsMenuBandeja.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfigurar.Location = new System.Drawing.Point(12, 12);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(100, 80);
            this.btnConfigurar.TabIndex = 0;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(224, 12);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(100, 80);
            this.btnParar.TabIndex = 2;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(118, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(100, 80);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(330, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 80);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pAcessoSenha
            // 
            this.pAcessoSenha.Controls.Add(this.label1);
            this.pAcessoSenha.Controls.Add(this.txtAcessoSenha);
            this.pAcessoSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAcessoSenha.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pAcessoSenha.Location = new System.Drawing.Point(0, 0);
            this.pAcessoSenha.Name = "pAcessoSenha";
            this.pAcessoSenha.Size = new System.Drawing.Size(440, 102);
            this.pAcessoSenha.TabIndex = 4;
            this.pAcessoSenha.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "DIGITA A SENHA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAcessoSenha
            // 
            this.txtAcessoSenha.Location = new System.Drawing.Point(5, 61);
            this.txtAcessoSenha.Name = "txtAcessoSenha";
            this.txtAcessoSenha.PasswordChar = '#';
            this.txtAcessoSenha.Size = new System.Drawing.Size(425, 32);
            this.txtAcessoSenha.TabIndex = 0;
            this.txtAcessoSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAcessoSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAcessoSenha_KeyDown);
            // 
            // nicBandeja
            // 
            this.nicBandeja.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nicBandeja.BalloonTipText = "Rodando em segundo plano.";
            this.nicBandeja.BalloonTipTitle = "MIPAMAX - Rotina de Backup para MySQL";
            this.nicBandeja.ContextMenuStrip = this.cmsMenuBandeja;
            this.nicBandeja.Visible = true;
            // 
            // cmsMenuBandeja
            // 
            this.cmsMenuBandeja.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.cmsMenuBandeja.Name = "cmsMenuBandeja";
            this.cmsMenuBandeja.Size = new System.Drawing.Size(110, 48);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 102);
            this.Controls.Add(this.pAcessoSenha);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnConfigurar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIPAMAX - Rotina de Backup para MySQL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.pAcessoSenha.ResumeLayout(false);
            this.pAcessoSenha.PerformLayout();
            this.cmsMenuBandeja.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel pAcessoSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAcessoSenha;
        private System.Windows.Forms.NotifyIcon nicBandeja;
        private System.Windows.Forms.ContextMenuStrip cmsMenuBandeja;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

