namespace Estacionamento.View.Relatorio
{
    partial class frmRelCadUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelCadUsuario));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Estacionamento.dsUsuario();
            this.usuarioTableAdapter = new Estacionamento.DataSet1TableAdapters.usuarioTableAdapter();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBotoesJanela = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.rvCadUsuario = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panelCabecalho.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelBotoesJanela.SuspendLayout();
            this.SuspendLayout();
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.SteelBlue;
            this.panelCabecalho.Controls.Add(this.panelTitulo);
            this.panelCabecalho.Controls.Add(this.panelBotoesJanela);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(685, 50);
            this.panelCabecalho.TabIndex = 6;
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(556, 50);
            this.panelTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(556, 50);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBotoesJanela
            // 
            this.panelBotoesJanela.Controls.Add(this.btnMinimizar);
            this.panelBotoesJanela.Controls.Add(this.btnNormal);
            this.panelBotoesJanela.Controls.Add(this.btnFechar);
            this.panelBotoesJanela.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBotoesJanela.Location = new System.Drawing.Point(556, 0);
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
            // rvCadUsuario
            // 
            this.rvCadUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsCadUsuario";
            reportDataSource1.Value = this.usuarioBindingSource;
            this.rvCadUsuario.LocalReport.DataSources.Add(reportDataSource1);
            this.rvCadUsuario.LocalReport.ReportEmbeddedResource = "Estacionamento.View.Relatorio.relCadUsuario.rdlc";
            this.rvCadUsuario.Location = new System.Drawing.Point(0, 50);
            this.rvCadUsuario.Name = "rvCadUsuario";
            this.rvCadUsuario.ServerReport.BearerToken = null;
            this.rvCadUsuario.ShowBackButton = false;
            this.rvCadUsuario.ShowContextMenu = false;
            this.rvCadUsuario.ShowCredentialPrompts = false;
            this.rvCadUsuario.ShowDocumentMapButton = false;
            this.rvCadUsuario.ShowFindControls = false;
            this.rvCadUsuario.ShowParameterPrompts = false;
            this.rvCadUsuario.ShowProgress = false;
            this.rvCadUsuario.ShowPromptAreaButton = false;
            this.rvCadUsuario.ShowRefreshButton = false;
            this.rvCadUsuario.ShowStopButton = false;
            this.rvCadUsuario.Size = new System.Drawing.Size(685, 435);
            this.rvCadUsuario.TabIndex = 7;
            // 
            // frmRelCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 485);
            this.Controls.Add(this.rvCadUsuario);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelCadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Cadastro de Usuários";
            this.Load += new System.EventHandler(this.frmRelCadUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panelCabecalho.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelBotoesJanela.ResumeLayout(false);
            this.panelBotoesJanela.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private dsUsuario dataSet1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DataSet1TableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelBotoesJanela;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnFechar;
        private Microsoft.Reporting.WinForms.ReportViewer rvCadUsuario;
    }
}