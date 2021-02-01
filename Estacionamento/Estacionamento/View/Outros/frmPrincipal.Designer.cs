/*
 * Created by SharpDevelop.
 * User: maxwell.miquelino
 * Date: 28/04/2020
 * Time: 08:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Estacionamento
{
	partial class frmPrincipal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnConvenio = new System.Windows.Forms.Button();
            this.btnFormaPagto = new System.Windows.Forms.Button();
            this.btnParametros = new System.Windows.Forms.Button();
            this.btnCadUsuario = new System.Windows.Forms.Button();
            this.btnMovto = new System.Windows.Forms.Button();
            this.btnCadPessoa = new System.Windows.Forms.Button();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.DarkGray;
            this.panelCabecalho.Controls.Add(this.lblTitulo);
            this.panelCabecalho.Controls.Add(this.picIcon);
            this.panelCabecalho.Controls.Add(this.btnMinimizar);
            this.panelCabecalho.Controls.Add(this.btnNormal);
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(1024, 50);
            this.panelCabecalho.TabIndex = 0;
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(49, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(834, 40);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // picIcon
            // 
            this.picIcon.Image = global::Estacionamento.Properties.Resources.icon;
            this.picIcon.Location = new System.Drawing.Point(3, 3);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(40, 40);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 1;
            this.picIcon.TabStop = false;
            this.picIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = global::Estacionamento.Properties.Resources.BotaoMinimizar;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(889, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.BackgroundImage = global::Estacionamento.Properties.Resources.BotaoMaximizar;
            this.btnNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNormal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNormal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.ForeColor = System.Drawing.Color.White;
            this.btnNormal.Location = new System.Drawing.Point(935, 5);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(40, 40);
            this.btnNormal.TabIndex = 1;
            this.btnNormal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(981, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 40);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelMenu.Controls.Add(this.btnSair);
            this.panelMenu.Controls.Add(this.btnRelatorio);
            this.panelMenu.Controls.Add(this.btnConvenio);
            this.panelMenu.Controls.Add(this.btnFormaPagto);
            this.panelMenu.Controls.Add(this.btnParametros);
            this.panelMenu.Controls.Add(this.btnCadUsuario);
            this.panelMenu.Controls.Add(this.btnMovto);
            this.panelMenu.Controls.Add(this.btnCadPessoa);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 50);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(228, 650);
            this.panelMenu.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 315);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(228, 45);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "SAIR";
            this.toolTip1.SetToolTip(this.btnSair, "Fechar o sistema.");
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
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
            this.btnRelatorio.Size = new System.Drawing.Size(228, 45);
            this.btnRelatorio.TabIndex = 6;
            this.btnRelatorio.Text = "RELATÓRIOS";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnConvenio
            // 
            this.btnConvenio.BackColor = System.Drawing.Color.Transparent;
            this.btnConvenio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConvenio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConvenio.FlatAppearance.BorderSize = 0;
            this.btnConvenio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnConvenio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnConvenio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvenio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvenio.Location = new System.Drawing.Point(0, 225);
            this.btnConvenio.Name = "btnConvenio";
            this.btnConvenio.Size = new System.Drawing.Size(228, 45);
            this.btnConvenio.TabIndex = 5;
            this.btnConvenio.Text = "CONVENIO";
            this.toolTip1.SetToolTip(this.btnConvenio, "Cadastro de formas de pagamentos.");
            this.btnConvenio.UseVisualStyleBackColor = false;
            this.btnConvenio.Click += new System.EventHandler(this.btnConvenio_Click);
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
            this.btnFormaPagto.Size = new System.Drawing.Size(228, 45);
            this.btnFormaPagto.TabIndex = 4;
            this.btnFormaPagto.Tag = "";
            this.btnFormaPagto.Text = "FORMA PAGTO";
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
            this.btnParametros.Size = new System.Drawing.Size(228, 45);
            this.btnParametros.TabIndex = 3;
            this.btnParametros.Text = "PARAMETROS";
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
            this.btnCadUsuario.Size = new System.Drawing.Size(228, 45);
            this.btnCadUsuario.TabIndex = 2;
            this.btnCadUsuario.Text = "USUÁRIO";
            this.toolTip1.SetToolTip(this.btnCadUsuario, "Cadastro de usuários.");
            this.btnCadUsuario.UseVisualStyleBackColor = false;
            this.btnCadUsuario.Click += new System.EventHandler(this.btnCadUsuario_Click);
            // 
            // btnMovto
            // 
            this.btnMovto.BackColor = System.Drawing.Color.Transparent;
            this.btnMovto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMovto.FlatAppearance.BorderSize = 0;
            this.btnMovto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnMovto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMovto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovto.ForeColor = System.Drawing.Color.Black;
            this.btnMovto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovto.Location = new System.Drawing.Point(0, 45);
            this.btnMovto.Name = "btnMovto";
            this.btnMovto.Size = new System.Drawing.Size(228, 45);
            this.btnMovto.TabIndex = 1;
            this.btnMovto.Text = "MOVIMENTAÇÃO";
            this.toolTip1.SetToolTip(this.btnMovto, "Movimentação de entrada e saída de veículos.");
            this.btnMovto.UseVisualStyleBackColor = false;
            this.btnMovto.Click += new System.EventHandler(this.btnMovto_Click);
            // 
            // btnCadPessoa
            // 
            this.btnCadPessoa.BackColor = System.Drawing.Color.Transparent;
            this.btnCadPessoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadPessoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadPessoa.FlatAppearance.BorderSize = 0;
            this.btnCadPessoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnCadPessoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCadPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadPessoa.ForeColor = System.Drawing.Color.Black;
            this.btnCadPessoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadPessoa.Location = new System.Drawing.Point(0, 0);
            this.btnCadPessoa.Name = "btnCadPessoa";
            this.btnCadPessoa.Size = new System.Drawing.Size(228, 45);
            this.btnCadPessoa.TabIndex = 0;
            this.btnCadPessoa.Text = "PESSOA";
            this.toolTip1.SetToolTip(this.btnCadPessoa, "Cadastro de pessoas.");
            this.btnCadPessoa.UseVisualStyleBackColor = false;
            this.btnCadPessoa.Click += new System.EventHandler(this.btnCadEmpresa_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(228, 50);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(796, 650);
            this.panelConteudo.TabIndex = 2;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor para Estacionamento";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.panelCabecalho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		private System.Windows.Forms.Panel panelCabecalho;
		private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCadPessoa;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Button btnParametros;
        private System.Windows.Forms.Button btnCadUsuario;
        private System.Windows.Forms.Button btnMovto;
        private System.Windows.Forms.Button btnConvenio;
        private System.Windows.Forms.Button btnFormaPagto;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnSair;
    }
}
