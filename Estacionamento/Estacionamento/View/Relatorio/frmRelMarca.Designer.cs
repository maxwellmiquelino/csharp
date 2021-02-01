namespace Estacionamento.View.Relatorio
{
    partial class frmRelMarca
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelMarca));
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBotoesJanela = new System.Windows.Forms.Panel();
            this.rvMarca = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dsMarca = new Estacionamento.dsMarca();
            this.dsMarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaTableAdapter = new Estacionamento.dsMarcaTableAdapters.marcaTableAdapter();
            this.panelCabecalho.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelBotoesJanela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
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
            this.panelCabecalho.Size = new System.Drawing.Size(665, 50);
            this.panelCabecalho.TabIndex = 7;
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(536, 50);
            this.panelTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(536, 50);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBotoesJanela
            // 
            this.panelBotoesJanela.Controls.Add(this.btnMinimizar);
            this.panelBotoesJanela.Controls.Add(this.btnNormal);
            this.panelBotoesJanela.Controls.Add(this.btnFechar);
            this.panelBotoesJanela.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBotoesJanela.Location = new System.Drawing.Point(536, 0);
            this.panelBotoesJanela.Name = "panelBotoesJanela";
            this.panelBotoesJanela.Size = new System.Drawing.Size(129, 50);
            this.panelBotoesJanela.TabIndex = 2;
            // 
            // rvMarca
            // 
            this.rvMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsMarca";
            reportDataSource1.Value = this.marcaBindingSource;
            this.rvMarca.LocalReport.DataSources.Add(reportDataSource1);
            this.rvMarca.LocalReport.ReportEmbeddedResource = "Estacionamento.View.Relatorio.relMarcaVeiculo.rdlc";
            this.rvMarca.Location = new System.Drawing.Point(0, 50);
            this.rvMarca.Name = "rvMarca";
            this.rvMarca.ServerReport.BearerToken = null;
            this.rvMarca.ShowBackButton = false;
            this.rvMarca.ShowContextMenu = false;
            this.rvMarca.ShowCredentialPrompts = false;
            this.rvMarca.ShowDocumentMapButton = false;
            this.rvMarca.ShowFindControls = false;
            this.rvMarca.ShowParameterPrompts = false;
            this.rvMarca.ShowProgress = false;
            this.rvMarca.ShowPromptAreaButton = false;
            this.rvMarca.ShowRefreshButton = false;
            this.rvMarca.ShowStopButton = false;
            this.rvMarca.Size = new System.Drawing.Size(665, 400);
            this.rvMarca.TabIndex = 8;
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
            // dsMarca
            // 
            this.dsMarca.DataSetName = "dsMarca";
            this.dsMarca.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsMarcaBindingSource
            // 
            this.dsMarcaBindingSource.DataMember = "marca";
            this.dsMarcaBindingSource.DataSource = this.dsMarca;
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "marca";
            this.marcaBindingSource.DataSource = this.dsMarca;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.rvMarca);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Marca de Veículo";
            this.Load += new System.EventHandler(this.frmRelMarca_Load);
            this.panelCabecalho.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelBotoesJanela.ResumeLayout(false);
            this.panelBotoesJanela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
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
        private Microsoft.Reporting.WinForms.ReportViewer rvMarca;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private dsMarca dsMarca;
        private System.Windows.Forms.BindingSource dsMarcaBindingSource;
        private dsMarcaTableAdapters.marcaTableAdapter marcaTableAdapter;
    }
}