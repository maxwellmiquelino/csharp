namespace Estacionamento.View
{
    partial class frmCadPessoa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadPessoa));
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
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
            this.tbcPessoa = new System.Windows.Forms.TabControl();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRazaoNome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIeRg = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCnpjCpf = new System.Windows.Forms.TextBox();
            this.txtSeqpessoa = new System.Windows.Forms.TextBox();
            this.tpTelefone = new System.Windows.Forms.TabPage();
            this.btnDelTel = new System.Windows.Forms.Button();
            this.btnAddTel = new System.Windows.Forms.Button();
            this.dgvTelefone = new System.Windows.Forms.DataGridView();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelCabecalho.SuspendLayout();
            this.panelBotoes.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.tbcPessoa.SuspendLayout();
            this.tpCadastro.SuspendLayout();
            this.tpTelefone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.SteelBlue;
            this.panelCabecalho.Controls.Add(this.lblTitulo);
            this.panelCabecalho.Controls.Add(this.btnMinimizar);
            this.panelCabecalho.Controls.Add(this.btnNormal);
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(826, 50);
            this.panelCabecalho.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(3, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(682, 40);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnMinimizar.Location = new System.Drawing.Point(691, 8);
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
            this.btnNormal.Location = new System.Drawing.Point(739, 8);
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
            this.btnFechar.Location = new System.Drawing.Point(783, 8);
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
            this.panelBotoes.Location = new System.Drawing.Point(0, 503);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(826, 80);
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
            this.btnVoltar.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnVoltar, "Fecha o formulário.");
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
            this.btnLimpar.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnLimpar, "Limpa os campos do formulário.");
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
            this.btnPesquisar.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnPesquisar, "Pesquisa de pessoas.");
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
            this.btnGravar.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnGravar, "Salva o registro atual.");
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
            this.btnNovo.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnNovo, "Inclui um novo registro.");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // panelForm
            // 
            this.panelForm.AutoScroll = true;
            this.panelForm.Controls.Add(this.tbcPessoa);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelForm.Location = new System.Drawing.Point(0, 50);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(826, 453);
            this.panelForm.TabIndex = 6;
            // 
            // tbcPessoa
            // 
            this.tbcPessoa.Controls.Add(this.tpCadastro);
            this.tbcPessoa.Controls.Add(this.tpTelefone);
            this.tbcPessoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPessoa.Location = new System.Drawing.Point(0, 0);
            this.tbcPessoa.Name = "tbcPessoa";
            this.tbcPessoa.SelectedIndex = 0;
            this.tbcPessoa.Size = new System.Drawing.Size(826, 453);
            this.tbcPessoa.TabIndex = 15;
            // 
            // tpCadastro
            // 
            this.tpCadastro.Controls.Add(this.label1);
            this.tpCadastro.Controls.Add(this.chkAtivo);
            this.tpCadastro.Controls.Add(this.label2);
            this.tpCadastro.Controls.Add(this.cboTipo);
            this.tpCadastro.Controls.Add(this.label3);
            this.tpCadastro.Controls.Add(this.txtUf);
            this.tpCadastro.Controls.Add(this.label13);
            this.tpCadastro.Controls.Add(this.txtCidade);
            this.tpCadastro.Controls.Add(this.label4);
            this.tpCadastro.Controls.Add(this.txtBairro);
            this.tpCadastro.Controls.Add(this.label5);
            this.tpCadastro.Controls.Add(this.txtComplemento);
            this.tpCadastro.Controls.Add(this.label6);
            this.tpCadastro.Controls.Add(this.txtNumero);
            this.tpCadastro.Controls.Add(this.label7);
            this.tpCadastro.Controls.Add(this.txtEndereco);
            this.tpCadastro.Controls.Add(this.label8);
            this.tpCadastro.Controls.Add(this.txtCep);
            this.tpCadastro.Controls.Add(this.label9);
            this.tpCadastro.Controls.Add(this.txtFantasia);
            this.tpCadastro.Controls.Add(this.label10);
            this.tpCadastro.Controls.Add(this.txtRazaoNome);
            this.tpCadastro.Controls.Add(this.label11);
            this.tpCadastro.Controls.Add(this.txtIeRg);
            this.tpCadastro.Controls.Add(this.label12);
            this.tpCadastro.Controls.Add(this.txtCnpjCpf);
            this.tpCadastro.Controls.Add(this.txtSeqpessoa);
            this.tpCadastro.Location = new System.Drawing.Point(4, 33);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastro.Size = new System.Drawing.Size(818, 416);
            this.tpCadastro.TabIndex = 0;
            this.tpCadastro.Text = "Cadastro";
            this.tpCadastro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seq. Pessoa";
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
            this.chkAtivo.Location = new System.Drawing.Point(304, 379);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(166, 34);
            this.chkAtivo.TabIndex = 14;
            this.chkAtivo.Text = "ATIVO";
            this.chkAtivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAtivo.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "CNPJ / CPF";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "FISICA",
            "JURIDICA"});
            this.cboTipo.Location = new System.Drawing.Point(71, 382);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(227, 32);
            this.cboTipo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Razão / Nome";
            // 
            // txtUf
            // 
            this.txtUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUf.Location = new System.Drawing.Point(6, 382);
            this.txtUf.MaxLength = 2;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(59, 29);
            this.txtUf.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(297, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "I.E / RG";
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(313, 323);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(310, 29);
            this.txtCidade.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fantasia";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(8, 323);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(299, 29);
            this.txtBairro.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "CEP";
            // 
            // txtComplemento
            // 
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Location = new System.Drawing.Point(128, 263);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(493, 29);
            this.txtComplemento.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Endereço";
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(6, 263);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(116, 29);
            this.txtNumero.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Número";
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Location = new System.Drawing.Point(130, 204);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(493, 29);
            this.txtEndereco.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Complemento";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(8, 204);
            this.txtCep.MaxLength = 8;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(116, 29);
            this.txtCep.TabIndex = 6;
            this.txtCep.TextChanged += new System.EventHandler(this.txtCep_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bairro";
            // 
            // txtFantasia
            // 
            this.txtFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFantasia.Location = new System.Drawing.Point(8, 145);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(615, 29);
            this.txtFantasia.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cidade";
            // 
            // txtRazaoNome
            // 
            this.txtRazaoNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoNome.Location = new System.Drawing.Point(8, 86);
            this.txtRazaoNome.Name = "txtRazaoNome";
            this.txtRazaoNome.Size = new System.Drawing.Size(615, 29);
            this.txtRazaoNome.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "UF";
            // 
            // txtIeRg
            // 
            this.txtIeRg.Location = new System.Drawing.Point(296, 27);
            this.txtIeRg.MaxLength = 14;
            this.txtIeRg.Name = "txtIeRg";
            this.txtIeRg.Size = new System.Drawing.Size(160, 29);
            this.txtIeRg.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tipo de Pessoa";
            // 
            // txtCnpjCpf
            // 
            this.txtCnpjCpf.Location = new System.Drawing.Point(130, 27);
            this.txtCnpjCpf.MaxLength = 14;
            this.txtCnpjCpf.Name = "txtCnpjCpf";
            this.txtCnpjCpf.Size = new System.Drawing.Size(160, 29);
            this.txtCnpjCpf.TabIndex = 2;
            this.txtCnpjCpf.TextChanged += new System.EventHandler(this.txtCnpjCpf_TextChanged);
            this.txtCnpjCpf.Validated += new System.EventHandler(this.txtCnpjCpf_Validated);
            // 
            // txtSeqpessoa
            // 
            this.txtSeqpessoa.Location = new System.Drawing.Point(8, 27);
            this.txtSeqpessoa.Name = "txtSeqpessoa";
            this.txtSeqpessoa.Size = new System.Drawing.Size(116, 29);
            this.txtSeqpessoa.TabIndex = 1;
            this.txtSeqpessoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSeqpessoa.TextChanged += new System.EventHandler(this.txtSeqpessoa_TextChanged);
            this.txtSeqpessoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeqpessoa_KeyPress);
            // 
            // tpTelefone
            // 
            this.tpTelefone.Controls.Add(this.btnDelTel);
            this.tpTelefone.Controls.Add(this.btnAddTel);
            this.tpTelefone.Controls.Add(this.dgvTelefone);
            this.tpTelefone.Controls.Add(this.txtContato);
            this.tpTelefone.Controls.Add(this.txtTelefone);
            this.tpTelefone.Controls.Add(this.label15);
            this.tpTelefone.Controls.Add(this.label14);
            this.tpTelefone.Location = new System.Drawing.Point(4, 33);
            this.tpTelefone.Name = "tpTelefone";
            this.tpTelefone.Padding = new System.Windows.Forms.Padding(3);
            this.tpTelefone.Size = new System.Drawing.Size(818, 416);
            this.tpTelefone.TabIndex = 1;
            this.tpTelefone.Text = "Telefone";
            this.tpTelefone.UseVisualStyleBackColor = true;
            // 
            // btnDelTel
            // 
            this.btnDelTel.AutoEllipsis = true;
            this.btnDelTel.BackgroundImage = global::Estacionamento.Properties.Resources.Excluir;
            this.btnDelTel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelTel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelTel.FlatAppearance.BorderSize = 0;
            this.btnDelTel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnDelTel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelTel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelTel.Location = new System.Drawing.Point(431, 90);
            this.btnDelTel.Name = "btnDelTel";
            this.btnDelTel.Size = new System.Drawing.Size(30, 29);
            this.btnDelTel.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnDelTel, "Exclui o telefone selecionado na grid.");
            this.btnDelTel.UseVisualStyleBackColor = true;
            this.btnDelTel.Click += new System.EventHandler(this.btnDelTel_Click);
            // 
            // btnAddTel
            // 
            this.btnAddTel.AutoEllipsis = true;
            this.btnAddTel.BackgroundImage = global::Estacionamento.Properties.Resources.Incluir;
            this.btnAddTel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddTel.FlatAppearance.BorderSize = 0;
            this.btnAddTel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnAddTel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddTel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTel.Location = new System.Drawing.Point(395, 89);
            this.btnAddTel.Name = "btnAddTel";
            this.btnAddTel.Size = new System.Drawing.Size(30, 29);
            this.btnAddTel.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnAddTel, "Inclui o telefone no cadastro.");
            this.btnAddTel.UseVisualStyleBackColor = true;
            this.btnAddTel.Click += new System.EventHandler(this.btnAddTel_Click);
            // 
            // dgvTelefone
            // 
            this.dgvTelefone.AllowUserToAddRows = false;
            this.dgvTelefone.AllowUserToDeleteRows = false;
            this.dgvTelefone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefone.Location = new System.Drawing.Point(8, 124);
            this.dgvTelefone.Name = "dgvTelefone";
            this.dgvTelefone.ReadOnly = true;
            this.dgvTelefone.RowHeadersWidth = 5;
            this.dgvTelefone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefone.Size = new System.Drawing.Size(453, 286);
            this.dgvTelefone.TabIndex = 4;
            // 
            // txtContato
            // 
            this.txtContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContato.Location = new System.Drawing.Point(8, 89);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(381, 29);
            this.txtContato.TabIndex = 3;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(8, 30);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(231, 29);
            this.txtTelefone.TabIndex = 2;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 24);
            this.label15.TabIndex = 1;
            this.label15.Text = "Contato";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "Telefone";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // frmCadPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 583);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelBotoes);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadPessoa";
            this.Text = "Cadastro de Pessoas";
            this.Load += new System.EventHandler(this.frmCadPessoa_Load);
            this.Resize += new System.EventHandler(this.frmCadPessoa_Resize);
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.panelBotoes.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.tbcPessoa.ResumeLayout(false);
            this.tpCadastro.ResumeLayout(false);
            this.tpCadastro.PerformLayout();
            this.tpTelefone.ResumeLayout(false);
            this.tpTelefone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Label lblTitulo;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.TextBox txtRazaoNome;
        private System.Windows.Forms.TextBox txtCnpjCpf;
        private System.Windows.Forms.TextBox txtSeqpessoa;
        private System.Windows.Forms.TextBox txtIeRg;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TabControl tbcPessoa;
        private System.Windows.Forms.TabPage tpCadastro;
        private System.Windows.Forms.TabPage tpTelefone;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvTelefone;
        private System.Windows.Forms.Button btnAddTel;
        private System.Windows.Forms.Button btnDelTel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}