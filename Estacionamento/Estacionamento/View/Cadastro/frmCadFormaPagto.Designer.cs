namespace Estacionamento.View
{
    partial class frmCadFormaPagto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadFormaPagto));
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBotoesJanela = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtSeqformapagto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCabecalho.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelBotoesJanela.SuspendLayout();
            this.panelBotoes.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.SteelBlue;
            this.panelCabecalho.Controls.Add(this.panelTitulo);
            this.panelCabecalho.Controls.Add(this.panelBotoesJanela);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(568, 50);
            this.panelCabecalho.TabIndex = 3;
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(439, 50);
            this.panelTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(439, 50);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBotoesJanela
            // 
            this.panelBotoesJanela.Controls.Add(this.btnMinimizar);
            this.panelBotoesJanela.Controls.Add(this.btnNormal);
            this.panelBotoesJanela.Controls.Add(this.btnFechar);
            this.panelBotoesJanela.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBotoesJanela.Location = new System.Drawing.Point(439, 0);
            this.panelBotoesJanela.Name = "panelBotoesJanela";
            this.panelBotoesJanela.Size = new System.Drawing.Size(129, 50);
            this.panelBotoesJanela.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMinimizar.BackgroundImage = global::Estacionamento.Properties.Resources.BotaoMinimizar;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.Enabled = false;
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(4, 8);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(37, 35);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Visible = false;
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNormal.BackgroundImage = global::Estacionamento.Properties.Resources.BotaoMaximizar;
            this.btnNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNormal.Enabled = false;
            this.btnNormal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNormal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.ForeColor = System.Drawing.Color.White;
            this.btnNormal.Location = new System.Drawing.Point(45, 8);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(37, 35);
            this.btnNormal.TabIndex = 1;
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Visible = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.AutoSize = true;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(88, 8);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(37, 35);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panelBotoes
            // 
            this.panelBotoes.BackColor = System.Drawing.Color.DarkGray;
            this.panelBotoes.Controls.Add(this.btnVoltar);
            this.panelBotoes.Controls.Add(this.btnLimpar);
            this.panelBotoes.Controls.Add(this.btnPesquisar);
            this.panelBotoes.Controls.Add(this.btnGravar);
            this.panelBotoes.Controls.Add(this.btnNovo);
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBotoes.Location = new System.Drawing.Point(0, 370);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(568, 80);
            this.panelBotoes.TabIndex = 5;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::Estacionamento.Properties.Resources.Voltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(360, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 80);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::Estacionamento.Properties.Resources.Limpar;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(270, 0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 80);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::Estacionamento.Properties.Resources.Pesquisar;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(180, 0);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(90, 80);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackgroundImage = global::Estacionamento.Properties.Resources.Gravar;
            this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGravar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Location = new System.Drawing.Point(90, 0);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(90, 80);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoEllipsis = true;
            this.btnNovo.BackgroundImage = global::Estacionamento.Properties.Resources.Incluir;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(0, 0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 80);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.chkAtivo);
            this.panelForm.Controls.Add(this.txtDescricao);
            this.panelForm.Controls.Add(this.txtSeqformapagto);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelForm.Location = new System.Drawing.Point(0, 50);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(568, 320);
            this.panelForm.TabIndex = 9;
            // 
            // chkAtivo
            // 
            this.chkAtivo.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAtivo.AutoEllipsis = true;
            this.chkAtivo.BackColor = System.Drawing.Color.Red;
            this.chkAtivo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkAtivo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.chkAtivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.chkAtivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.chkAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAtivo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkAtivo.Location = new System.Drawing.Point(13, 139);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(166, 34);
            this.chkAtivo.TabIndex = 3;
            this.chkAtivo.Text = "ATIVO";
            this.chkAtivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAtivo.UseVisualStyleBackColor = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(12, 104);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(433, 29);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtSeqformapagto
            // 
            this.txtSeqformapagto.Location = new System.Drawing.Point(12, 45);
            this.txtSeqformapagto.Name = "txtSeqformapagto";
            this.txtSeqformapagto.Size = new System.Drawing.Size(163, 29);
            this.txtSeqformapagto.TabIndex = 1;
            this.txtSeqformapagto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSeqformapagto.TextChanged += new System.EventHandler(this.txtSeqformapagto_TextChanged);
            this.txtSeqformapagto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeqformapagto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seq. Forma Pagto.";
            // 
            // frmCadFormaPagto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelBotoes);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadFormaPagto";
            this.Text = "Cadastro de Formas de Pagamentos";
            this.Load += new System.EventHandler(this.frmCadFormaPagto_Load);
            this.Resize += new System.EventHandler(this.frmCadFormaPagto_Resize);
            this.panelCabecalho.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelBotoesJanela.ResumeLayout(false);
            this.panelBotoesJanela.PerformLayout();
            this.panelBotoes.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelBotoesJanela;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtSeqformapagto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAtivo;
    }
}