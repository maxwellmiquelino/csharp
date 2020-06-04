namespace CadastroClientes
{
    partial class frmCadCliente
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
            this.lblSeqpessoa = new System.Windows.Forms.Label();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.lblRgIe = new System.Windows.Forms.Label();
            this.lblNomeRazao = new System.Windows.Forms.Label();
            this.lblFantasia = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.gpbBotoes = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.txtNomeRazao = new System.Windows.Forms.TextBox();
            this.txtRgIe = new System.Windows.Forms.TextBox();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.txtSeqpessoa = new System.Windows.Forms.TextBox();
            this.panelForm.SuspendLayout();
            this.gpbBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSeqpessoa
            // 
            this.lblSeqpessoa.AutoSize = true;
            this.lblSeqpessoa.Location = new System.Drawing.Point(10, 9);
            this.lblSeqpessoa.Name = "lblSeqpessoa";
            this.lblSeqpessoa.Size = new System.Drawing.Size(105, 24);
            this.lblSeqpessoa.TabIndex = 0;
            this.lblSeqpessoa.Text = "Seqpessoa";
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(12, 68);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(110, 24);
            this.lblCpfCnpj.TabIndex = 0;
            this.lblCpfCnpj.Text = "CPF / CNPJ";
            // 
            // lblRgIe
            // 
            this.lblRgIe.AutoSize = true;
            this.lblRgIe.Location = new System.Drawing.Point(183, 68);
            this.lblRgIe.Name = "lblRgIe";
            this.lblRgIe.Size = new System.Drawing.Size(69, 24);
            this.lblRgIe.TabIndex = 0;
            this.lblRgIe.Text = "RG / IE";
            // 
            // lblNomeRazao
            // 
            this.lblNomeRazao.AutoSize = true;
            this.lblNomeRazao.Location = new System.Drawing.Point(12, 127);
            this.lblNomeRazao.Name = "lblNomeRazao";
            this.lblNomeRazao.Size = new System.Drawing.Size(130, 24);
            this.lblNomeRazao.TabIndex = 0;
            this.lblNomeRazao.Text = "Nome / Razão";
            // 
            // lblFantasia
            // 
            this.lblFantasia.AutoSize = true;
            this.lblFantasia.Location = new System.Drawing.Point(12, 186);
            this.lblFantasia.Name = "lblFantasia";
            this.lblFantasia.Size = new System.Drawing.Size(80, 24);
            this.lblFantasia.TabIndex = 0;
            this.lblFantasia.Text = "Fantasia";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(118, 245);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(94, 24);
            this.lblEndereco.TabIndex = 0;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(13, 304);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(79, 24);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(98, 304);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(129, 24);
            this.lblComplemento.TabIndex = 0;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(360, 304);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(59, 24);
            this.lblBairro.TabIndex = 0;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(13, 363);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(70, 24);
            this.lblCidade.TabIndex = 0;
            this.lblCidade.Text = "Cidade";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(360, 363);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(35, 24);
            this.lblUf.TabIndex = 0;
            this.lblUf.Text = "UF";
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(401, 363);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(111, 24);
            this.lblTipoCliente.TabIndex = 0;
            this.lblTipoCliente.Text = "Tipo Cliente";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(12, 245);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(48, 24);
            this.lblCep.TabIndex = 0;
            this.lblCep.Text = "CEP";
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.gpbBotoes);
            this.panelForm.Controls.Add(this.chkAtivo);
            this.panelForm.Controls.Add(this.cboTipoCliente);
            this.panelForm.Controls.Add(this.txtUf);
            this.panelForm.Controls.Add(this.txtCidade);
            this.panelForm.Controls.Add(this.txtBairro);
            this.panelForm.Controls.Add(this.txtComplemento);
            this.panelForm.Controls.Add(this.txtNumero);
            this.panelForm.Controls.Add(this.txtEndereco);
            this.panelForm.Controls.Add(this.txtCep);
            this.panelForm.Controls.Add(this.txtFantasia);
            this.panelForm.Controls.Add(this.txtNomeRazao);
            this.panelForm.Controls.Add(this.txtRgIe);
            this.panelForm.Controls.Add(this.txtCpfCnpj);
            this.panelForm.Controls.Add(this.txtSeqpessoa);
            this.panelForm.Controls.Add(this.lblCidade);
            this.panelForm.Controls.Add(this.lblCep);
            this.panelForm.Controls.Add(this.lblSeqpessoa);
            this.panelForm.Controls.Add(this.lblTipoCliente);
            this.panelForm.Controls.Add(this.lblCpfCnpj);
            this.panelForm.Controls.Add(this.lblUf);
            this.panelForm.Controls.Add(this.lblRgIe);
            this.panelForm.Controls.Add(this.lblNomeRazao);
            this.panelForm.Controls.Add(this.lblBairro);
            this.panelForm.Controls.Add(this.lblFantasia);
            this.panelForm.Controls.Add(this.lblComplemento);
            this.panelForm.Controls.Add(this.lblEndereco);
            this.panelForm.Controls.Add(this.lblNumero);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(800, 450);
            this.panelForm.TabIndex = 13;
            // 
            // gpbBotoes
            // 
            this.gpbBotoes.Controls.Add(this.btnLimpar);
            this.gpbBotoes.Controls.Add(this.btnPesquisar);
            this.gpbBotoes.Controls.Add(this.btnGravar);
            this.gpbBotoes.Controls.Add(this.btnNovo);
            this.gpbBotoes.Location = new System.Drawing.Point(364, 15);
            this.gpbBotoes.Name = "gpbBotoes";
            this.gpbBotoes.Size = new System.Drawing.Size(424, 136);
            this.gpbBotoes.TabIndex = 15;
            this.gpbBotoes.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(214, 70);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(204, 56);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(214, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(204, 56);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(6, 70);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(204, 56);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(6, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(204, 56);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(623, 391);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(86, 28);
            this.chkAtivo.TabIndex = 14;
            this.chkAtivo.Text = "ATIVO";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTipoCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Items.AddRange(new object[] {
            "PESSOA FÍSICA",
            "PESSOA JURÍDICA"});
            this.cboTipoCliente.Location = new System.Drawing.Point(401, 390);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(216, 32);
            this.cboTipoCliente.TabIndex = 13;
            // 
            // txtUf
            // 
            this.txtUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUf.Location = new System.Drawing.Point(362, 390);
            this.txtUf.MaxLength = 2;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(33, 29);
            this.txtUf.TabIndex = 12;
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(12, 390);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(344, 29);
            this.txtCidade.TabIndex = 11;
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(364, 331);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(426, 29);
            this.txtBairro.TabIndex = 10;
            // 
            // txtComplemento
            // 
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Location = new System.Drawing.Point(98, 331);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(258, 29);
            this.txtComplemento.TabIndex = 9;
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(12, 331);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(80, 29);
            this.txtNumero.TabIndex = 8;
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Location = new System.Drawing.Point(118, 272);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(670, 29);
            this.txtEndereco.TabIndex = 7;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(12, 272);
            this.txtCep.MaxLength = 8;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 29);
            this.txtCep.TabIndex = 6;
            this.txtCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFantasia
            // 
            this.txtFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFantasia.Location = new System.Drawing.Point(12, 213);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(776, 29);
            this.txtFantasia.TabIndex = 5;
            // 
            // txtNomeRazao
            // 
            this.txtNomeRazao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNomeRazao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeRazao.Location = new System.Drawing.Point(12, 154);
            this.txtNomeRazao.Name = "txtNomeRazao";
            this.txtNomeRazao.Size = new System.Drawing.Size(776, 29);
            this.txtNomeRazao.TabIndex = 4;
            // 
            // txtRgIe
            // 
            this.txtRgIe.Location = new System.Drawing.Point(187, 95);
            this.txtRgIe.MaxLength = 14;
            this.txtRgIe.Name = "txtRgIe";
            this.txtRgIe.Size = new System.Drawing.Size(169, 29);
            this.txtRgIe.TabIndex = 3;
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(12, 95);
            this.txtCpfCnpj.MaxLength = 14;
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(169, 29);
            this.txtCpfCnpj.TabIndex = 2;
            // 
            // txtSeqpessoa
            // 
            this.txtSeqpessoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSeqpessoa.Location = new System.Drawing.Point(12, 36);
            this.txtSeqpessoa.Name = "txtSeqpessoa";
            this.txtSeqpessoa.Size = new System.Drawing.Size(100, 29);
            this.txtSeqpessoa.TabIndex = 1;
            this.txtSeqpessoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmCadCliente_Load);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.gpbBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSeqpessoa;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.Label lblRgIe;
        private System.Windows.Forms.Label lblNomeRazao;
        private System.Windows.Forms.Label lblFantasia;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.TextBox txtNomeRazao;
        private System.Windows.Forms.TextBox txtRgIe;
        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.TextBox txtSeqpessoa;
        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.GroupBox gpbBotoes;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
    }
}

