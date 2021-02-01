namespace Estacionamento.View.Relatorio
{
    partial class frmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBotoesJanela = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnMovimentacao = new System.Windows.Forms.Button();
            this.btnFormaPagto = new System.Windows.Forms.Button();
            this.btnParametros = new System.Windows.Forms.Button();
            this.btnCadUsuario = new System.Windows.Forms.Button();
            this.btnRelCadPessoas = new System.Windows.Forms.Button();
            this.btnRelCadUsuario = new System.Windows.Forms.Button();
            this.panelCabecalho.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelBotoesJanela.SuspendLayout();
            this.panelMenu.SuspendLayout();
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
            this.panelCabecalho.Size = new System.Drawing.Size(510, 50);
            this.panelCabecalho.TabIndex = 5;
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(381, 50);
            this.panelTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(381, 50);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBotoesJanela
            // 
            this.panelBotoesJanela.Controls.Add(this.btnMinimizar);
            this.panelBotoesJanela.Controls.Add(this.btnNormal);
            this.panelBotoesJanela.Controls.Add(this.btnFechar);
            this.panelBotoesJanela.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBotoesJanela.Location = new System.Drawing.Point(381, 0);
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
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.panelMenu.Controls.Add(this.btnRelatorio);
            this.panelMenu.Controls.Add(this.btnMovimentacao);
            this.panelMenu.Controls.Add(this.btnFormaPagto);
            this.panelMenu.Controls.Add(this.btnParametros);
            this.panelMenu.Controls.Add(this.btnCadUsuario);
            this.panelMenu.Controls.Add(this.btnRelCadPessoas);
            this.panelMenu.Controls.Add(this.btnRelCadUsuario);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 50);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(510, 400);
            this.panelMenu.TabIndex = 6;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.Location = new System.Drawing.Point(0, 270);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(510, 45);
            this.btnRelatorio.TabIndex = 6;
            this.btnRelatorio.UseVisualStyleBackColor = false;
            // 
            // btnMovimentacao
            // 
            this.btnMovimentacao.BackColor = System.Drawing.Color.Transparent;
            this.btnMovimentacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovimentacao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMovimentacao.FlatAppearance.BorderSize = 0;
            this.btnMovimentacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnMovimentacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimentacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovimentacao.Location = new System.Drawing.Point(0, 225);
            this.btnMovimentacao.Name = "btnMovimentacao";
            this.btnMovimentacao.Size = new System.Drawing.Size(510, 45);
            this.btnMovimentacao.TabIndex = 5;
            this.btnMovimentacao.Text = "MOVIMENTAÇÃO";
            this.btnMovimentacao.UseVisualStyleBackColor = false;
            this.btnMovimentacao.Click += new System.EventHandler(this.btnMovimentacao_Click);
            // 
            // btnFormaPagto
            // 
            this.btnFormaPagto.BackColor = System.Drawing.Color.Transparent;
            this.btnFormaPagto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormaPagto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFormaPagto.FlatAppearance.BorderSize = 0;
            this.btnFormaPagto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnFormaPagto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnFormaPagto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormaPagto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormaPagto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormaPagto.Location = new System.Drawing.Point(0, 180);
            this.btnFormaPagto.Name = "btnFormaPagto";
            this.btnFormaPagto.Size = new System.Drawing.Size(510, 45);
            this.btnFormaPagto.TabIndex = 4;
            this.btnFormaPagto.Tag = "";
            this.btnFormaPagto.Text = "MODELOS DE VEÍCULOS";
            this.btnFormaPagto.UseVisualStyleBackColor = false;
            this.btnFormaPagto.Click += new System.EventHandler(this.btnFormaPagto_Click);
            // 
            // btnParametros
            // 
            this.btnParametros.BackColor = System.Drawing.Color.Transparent;
            this.btnParametros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParametros.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnParametros.FlatAppearance.BorderSize = 0;
            this.btnParametros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnParametros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnParametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParametros.Location = new System.Drawing.Point(0, 135);
            this.btnParametros.Name = "btnParametros";
            this.btnParametros.Size = new System.Drawing.Size(510, 45);
            this.btnParametros.TabIndex = 3;
            this.btnParametros.Text = "MARCAS DE VEÍCULOS";
            this.btnParametros.UseVisualStyleBackColor = false;
            this.btnParametros.Click += new System.EventHandler(this.btnParametros_Click);
            // 
            // btnCadUsuario
            // 
            this.btnCadUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnCadUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadUsuario.FlatAppearance.BorderSize = 0;
            this.btnCadUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnCadUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCadUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadUsuario.Location = new System.Drawing.Point(0, 90);
            this.btnCadUsuario.Name = "btnCadUsuario";
            this.btnCadUsuario.Size = new System.Drawing.Size(510, 45);
            this.btnCadUsuario.TabIndex = 2;
            this.btnCadUsuario.Text = "CADASTRO DE FORMAS DE PAGAMENTOS";
            this.btnCadUsuario.UseVisualStyleBackColor = false;
            this.btnCadUsuario.Click += new System.EventHandler(this.btnCadUsuario_Click);
            // 
            // btnRelCadPessoas
            // 
            this.btnRelCadPessoas.BackColor = System.Drawing.Color.Transparent;
            this.btnRelCadPessoas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelCadPessoas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRelCadPessoas.FlatAppearance.BorderSize = 0;
            this.btnRelCadPessoas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnRelCadPessoas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRelCadPessoas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelCadPessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelCadPessoas.ForeColor = System.Drawing.Color.Black;
            this.btnRelCadPessoas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelCadPessoas.Location = new System.Drawing.Point(0, 45);
            this.btnRelCadPessoas.Name = "btnRelCadPessoas";
            this.btnRelCadPessoas.Size = new System.Drawing.Size(510, 45);
            this.btnRelCadPessoas.TabIndex = 1;
            this.btnRelCadPessoas.Text = "CADASTRO DE PESSOAS";
            this.btnRelCadPessoas.UseVisualStyleBackColor = false;
            this.btnRelCadPessoas.Click += new System.EventHandler(this.btnRelCadPessoas_Click);
            // 
            // btnRelCadUsuario
            // 
            this.btnRelCadUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnRelCadUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelCadUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRelCadUsuario.FlatAppearance.BorderSize = 0;
            this.btnRelCadUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnRelCadUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRelCadUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelCadUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelCadUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnRelCadUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelCadUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnRelCadUsuario.Name = "btnRelCadUsuario";
            this.btnRelCadUsuario.Size = new System.Drawing.Size(510, 45);
            this.btnRelCadUsuario.TabIndex = 0;
            this.btnRelCadUsuario.Text = "CADASTRO DE USUÁRIO";
            this.btnRelCadUsuario.UseVisualStyleBackColor = false;
            this.btnRelCadUsuario.Click += new System.EventHandler(this.btnRelCadUsuario_Click);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorio";
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            this.Resize += new System.EventHandler(this.frmRelatorio_Resize);
            this.panelCabecalho.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelBotoesJanela.ResumeLayout(false);
            this.panelBotoesJanela.PerformLayout();
            this.panelMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnMovimentacao;
        private System.Windows.Forms.Button btnFormaPagto;
        private System.Windows.Forms.Button btnParametros;
        private System.Windows.Forms.Button btnCadUsuario;
        private System.Windows.Forms.Button btnRelCadPessoas;
        private System.Windows.Forms.Button btnRelCadUsuario;
    }
}