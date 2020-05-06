namespace MIPAMAX_BackupMySQL.Forms
{
    partial class frmConfigurar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Acesso");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("MySQL");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Sistema");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigurar));
            this.txtServerHost = new System.Windows.Forms.TextBox();
            this.txtDefaultSchema = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.pMySQL = new System.Windows.Forms.Panel();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.tvwMenu = new System.Windows.Forms.TreeView();
            this.pSistema = new System.Windows.Forms.Panel();
            this.txtSistemaTempo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSistemaCaminhoBackupAlternativo = new System.Windows.Forms.Button();
            this.txtSistemaCaminhoBackupAlternativo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSistemaNomeArquivoZip = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSistemaCaminhoBackup = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSistemaCaminhoBackup = new System.Windows.Forms.TextBox();
            this.txtSistemaHorario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pAcesso = new System.Windows.Forms.Panel();
            this.chkAcessoInicioAutomatico = new System.Windows.Forms.CheckBox();
            this.txtAcessoConfirmSenha = new System.Windows.Forms.TextBox();
            this.txtAcessoSenha = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fbdCaminhoBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdCaminhoBackupAlternativo = new System.Windows.Forms.FolderBrowserDialog();
            this.pMySQL.SuspendLayout();
            this.pSistema.SuspendLayout();
            this.pAcesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtServerHost
            // 
            this.txtServerHost.Location = new System.Drawing.Point(167, 4);
            this.txtServerHost.Name = "txtServerHost";
            this.txtServerHost.Size = new System.Drawing.Size(196, 26);
            this.txtServerHost.TabIndex = 0;
            // 
            // txtDefaultSchema
            // 
            this.txtDefaultSchema.Location = new System.Drawing.Point(167, 36);
            this.txtDefaultSchema.Name = "txtDefaultSchema";
            this.txtDefaultSchema.Size = new System.Drawing.Size(196, 26);
            this.txtDefaultSchema.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(167, 68);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(196, 26);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(167, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(196, 26);
            this.txtPassword.TabIndex = 3;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(167, 132);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(196, 26);
            this.txtConfirmPassword.TabIndex = 4;
            // 
            // pMySQL
            // 
            this.pMySQL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pMySQL.Controls.Add(this.txtPorta);
            this.pMySQL.Controls.Add(this.label10);
            this.pMySQL.Controls.Add(this.label5);
            this.pMySQL.Controls.Add(this.label4);
            this.pMySQL.Controls.Add(this.label3);
            this.pMySQL.Controls.Add(this.label2);
            this.pMySQL.Controls.Add(this.label1);
            this.pMySQL.Controls.Add(this.txtServerHost);
            this.pMySQL.Controls.Add(this.txtConfirmPassword);
            this.pMySQL.Controls.Add(this.txtDefaultSchema);
            this.pMySQL.Controls.Add(this.txtPassword);
            this.pMySQL.Controls.Add(this.txtUserName);
            this.pMySQL.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pMySQL.Location = new System.Drawing.Point(166, 12);
            this.pMySQL.Name = "pMySQL";
            this.pMySQL.Size = new System.Drawing.Size(374, 217);
            this.pMySQL.TabIndex = 5;
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(167, 163);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(196, 26);
            this.txtPorta.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "PORTA :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "CONF. PWD :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "PASSWORD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "USERNAME :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "DEFAULTSCHEMA :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "SERVERHOST :";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(12, 235);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(528, 39);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnMySQLGravar_Click);
            // 
            // tvwMenu
            // 
            this.tvwMenu.Location = new System.Drawing.Point(12, 9);
            this.tvwMenu.Name = "tvwMenu";
            treeNode1.Name = "nAcesso";
            treeNode1.Text = "Acesso";
            treeNode2.Name = "nMysql";
            treeNode2.Text = "MySQL";
            treeNode3.Name = "nSistema";
            treeNode3.Text = "Sistema";
            this.tvwMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.tvwMenu.Size = new System.Drawing.Size(148, 220);
            this.tvwMenu.TabIndex = 6;
            this.tvwMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwMenu_AfterSelect);
            // 
            // pSistema
            // 
            this.pSistema.Controls.Add(this.txtSistemaTempo);
            this.pSistema.Controls.Add(this.label13);
            this.pSistema.Controls.Add(this.btnSistemaCaminhoBackupAlternativo);
            this.pSistema.Controls.Add(this.txtSistemaCaminhoBackupAlternativo);
            this.pSistema.Controls.Add(this.label9);
            this.pSistema.Controls.Add(this.txtSistemaNomeArquivoZip);
            this.pSistema.Controls.Add(this.label8);
            this.pSistema.Controls.Add(this.btnSistemaCaminhoBackup);
            this.pSistema.Controls.Add(this.label7);
            this.pSistema.Controls.Add(this.txtSistemaCaminhoBackup);
            this.pSistema.Controls.Add(this.txtSistemaHorario);
            this.pSistema.Controls.Add(this.label6);
            this.pSistema.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pSistema.Location = new System.Drawing.Point(166, 12);
            this.pSistema.Name = "pSistema";
            this.pSistema.Size = new System.Drawing.Size(374, 217);
            this.pSistema.TabIndex = 7;
            // 
            // txtSistemaTempo
            // 
            this.txtSistemaTempo.Location = new System.Drawing.Point(117, 78);
            this.txtSistemaTempo.Name = "txtSistemaTempo";
            this.txtSistemaTempo.Size = new System.Drawing.Size(100, 26);
            this.txtSistemaTempo.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(114, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 18);
            this.label13.TabIndex = 9;
            this.label13.Text = "Tempo (M)";
            // 
            // btnSistemaCaminhoBackupAlternativo
            // 
            this.btnSistemaCaminhoBackupAlternativo.Location = new System.Drawing.Point(345, 188);
            this.btnSistemaCaminhoBackupAlternativo.Name = "btnSistemaCaminhoBackupAlternativo";
            this.btnSistemaCaminhoBackupAlternativo.Size = new System.Drawing.Size(26, 25);
            this.btnSistemaCaminhoBackupAlternativo.TabIndex = 8;
            this.btnSistemaCaminhoBackupAlternativo.UseVisualStyleBackColor = true;
            this.btnSistemaCaminhoBackupAlternativo.Click += new System.EventHandler(this.btnSistemaCaminhoBackupAlternativo_Click);
            // 
            // txtSistemaCaminhoBackupAlternativo
            // 
            this.txtSistemaCaminhoBackupAlternativo.Location = new System.Drawing.Point(6, 187);
            this.txtSistemaCaminhoBackupAlternativo.Name = "txtSistemaCaminhoBackupAlternativo";
            this.txtSistemaCaminhoBackupAlternativo.Size = new System.Drawing.Size(338, 26);
            this.txtSistemaCaminhoBackupAlternativo.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(298, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Caminho do Backup alternativo";
            // 
            // txtSistemaNomeArquivoZip
            // 
            this.txtSistemaNomeArquivoZip.Location = new System.Drawing.Point(6, 28);
            this.txtSistemaNomeArquivoZip.Name = "txtSistemaNomeArquivoZip";
            this.txtSistemaNomeArquivoZip.Size = new System.Drawing.Size(357, 26);
            this.txtSistemaNomeArquivoZip.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nome do Arquivo Zip";
            // 
            // btnSistemaCaminhoBackup
            // 
            this.btnSistemaCaminhoBackup.Location = new System.Drawing.Point(345, 136);
            this.btnSistemaCaminhoBackup.Name = "btnSistemaCaminhoBackup";
            this.btnSistemaCaminhoBackup.Size = new System.Drawing.Size(26, 27);
            this.btnSistemaCaminhoBackup.TabIndex = 4;
            this.btnSistemaCaminhoBackup.UseVisualStyleBackColor = true;
            this.btnSistemaCaminhoBackup.Click += new System.EventHandler(this.btnSistemaCaminhoBackup_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Caminho do Backup";
            // 
            // txtSistemaCaminhoBackup
            // 
            this.txtSistemaCaminhoBackup.Location = new System.Drawing.Point(6, 137);
            this.txtSistemaCaminhoBackup.Name = "txtSistemaCaminhoBackup";
            this.txtSistemaCaminhoBackup.Size = new System.Drawing.Size(338, 26);
            this.txtSistemaCaminhoBackup.TabIndex = 3;
            // 
            // txtSistemaHorario
            // 
            this.txtSistemaHorario.Location = new System.Drawing.Point(6, 78);
            this.txtSistemaHorario.Name = "txtSistemaHorario";
            this.txtSistemaHorario.Size = new System.Drawing.Size(105, 26);
            this.txtSistemaHorario.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Horário";
            // 
            // pAcesso
            // 
            this.pAcesso.Controls.Add(this.chkAcessoInicioAutomatico);
            this.pAcesso.Controls.Add(this.txtAcessoConfirmSenha);
            this.pAcesso.Controls.Add(this.txtAcessoSenha);
            this.pAcesso.Controls.Add(this.label12);
            this.pAcesso.Controls.Add(this.label11);
            this.pAcesso.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pAcesso.Location = new System.Drawing.Point(166, 12);
            this.pAcesso.Name = "pAcesso";
            this.pAcesso.Size = new System.Drawing.Size(374, 217);
            this.pAcesso.TabIndex = 11;
            // 
            // chkAcessoInicioAutomatico
            // 
            this.chkAcessoInicioAutomatico.AutoSize = true;
            this.chkAcessoInicioAutomatico.Location = new System.Drawing.Point(6, 117);
            this.chkAcessoInicioAutomatico.Name = "chkAcessoInicioAutomatico";
            this.chkAcessoInicioAutomatico.Size = new System.Drawing.Size(197, 22);
            this.chkAcessoInicioAutomatico.TabIndex = 4;
            this.chkAcessoInicioAutomatico.Text = "Início automático";
            this.chkAcessoInicioAutomatico.UseVisualStyleBackColor = true;
            // 
            // txtAcessoConfirmSenha
            // 
            this.txtAcessoConfirmSenha.Location = new System.Drawing.Point(6, 85);
            this.txtAcessoConfirmSenha.Name = "txtAcessoConfirmSenha";
            this.txtAcessoConfirmSenha.PasswordChar = '*';
            this.txtAcessoConfirmSenha.Size = new System.Drawing.Size(365, 26);
            this.txtAcessoConfirmSenha.TabIndex = 3;
            // 
            // txtAcessoSenha
            // 
            this.txtAcessoSenha.Location = new System.Drawing.Point(6, 35);
            this.txtAcessoSenha.Name = "txtAcessoSenha";
            this.txtAcessoSenha.PasswordChar = '*';
            this.txtAcessoSenha.Size = new System.Drawing.Size(365, 26);
            this.txtAcessoSenha.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Confirmar senha";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Senha de acesso";
            // 
            // frmConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(550, 281);
            this.Controls.Add(this.pAcesso);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.pSistema);
            this.Controls.Add(this.tvwMenu);
            this.Controls.Add(this.pMySQL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfigurar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConfigurar_FormClosed);
            this.Load += new System.EventHandler(this.frmConfigurar_Load);
            this.pMySQL.ResumeLayout(false);
            this.pMySQL.PerformLayout();
            this.pSistema.ResumeLayout(false);
            this.pSistema.PerformLayout();
            this.pAcesso.ResumeLayout(false);
            this.pAcesso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerHost;
        private System.Windows.Forms.TextBox txtDefaultSchema;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Panel pMySQL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TreeView tvwMenu;
        private System.Windows.Forms.Panel pSistema;
        private System.Windows.Forms.TextBox txtSistemaHorario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSistemaCaminhoBackup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSistemaCaminhoBackup;
        private System.Windows.Forms.TextBox txtSistemaNomeArquivoZip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FolderBrowserDialog fbdCaminhoBackup;
        private System.Windows.Forms.TextBox txtSistemaCaminhoBackupAlternativo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSistemaCaminhoBackupAlternativo;
        private System.Windows.Forms.FolderBrowserDialog fbdCaminhoBackupAlternativo;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pAcesso;
        private System.Windows.Forms.TextBox txtAcessoConfirmSenha;
        private System.Windows.Forms.TextBox txtAcessoSenha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSistemaTempo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkAcessoInicioAutomatico;
    }
}