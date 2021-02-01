namespace Estacionamento.View.Relatorio
{
    partial class frmRelMovimentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelMovimentacao));
            this.vw_movimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsViewMovto = new Estacionamento.dsViewMovto();
            this.rvMovto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cboDtaMovto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dsViewMovtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_movimentoTableAdapter = new Estacionamento.dsViewMovtoTableAdapters.vw_movimentoTableAdapter();
            this.fillByFiltroDtaMovimentoToolStrip = new System.Windows.Forms.ToolStrip();
            this.dtamovimentoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dtamovimentoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByFiltroDtaMovimentoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBotoesJanela = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.vw_movimentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsViewMovto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsViewMovtoBindingSource)).BeginInit();
            this.fillByFiltroDtaMovimentoToolStrip.SuspendLayout();
            this.panelCabecalho.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelBotoesJanela.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // vw_movimentoBindingSource
            // 
            this.vw_movimentoBindingSource.DataMember = "vw_movimento";
            this.vw_movimentoBindingSource.DataSource = this.dsViewMovto;
            // 
            // dsViewMovto
            // 
            this.dsViewMovto.DataSetName = "dsViewMovto";
            this.dsViewMovto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvMovto
            // 
            this.rvMovto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "dsMovto";
            reportDataSource1.Value = this.vw_movimentoBindingSource;
            this.rvMovto.LocalReport.DataSources.Add(reportDataSource1);
            this.rvMovto.LocalReport.ReportEmbeddedResource = "Estacionamento.View.Relatorio.relMovimentacao.rdlc";
            this.rvMovto.Location = new System.Drawing.Point(12, 68);
            this.rvMovto.Name = "rvMovto";
            this.rvMovto.ServerReport.BearerToken = null;
            this.rvMovto.ShowBackButton = false;
            this.rvMovto.ShowContextMenu = false;
            this.rvMovto.ShowCredentialPrompts = false;
            this.rvMovto.ShowDocumentMapButton = false;
            this.rvMovto.ShowFindControls = false;
            this.rvMovto.ShowParameterPrompts = false;
            this.rvMovto.ShowProgress = false;
            this.rvMovto.ShowPromptAreaButton = false;
            this.rvMovto.Size = new System.Drawing.Size(784, 345);
            this.rvMovto.TabIndex = 0;
            // 
            // cboDtaMovto
            // 
            this.cboDtaMovto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDtaMovto.FormattingEnabled = true;
            this.cboDtaMovto.Location = new System.Drawing.Point(12, 30);
            this.cboDtaMovto.Name = "cboDtaMovto";
            this.cboDtaMovto.Size = new System.Drawing.Size(172, 32);
            this.cboDtaMovto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data de Movimento";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(190, 30);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(93, 32);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dsViewMovtoBindingSource
            // 
            this.dsViewMovtoBindingSource.DataMember = "vw_movimento";
            this.dsViewMovtoBindingSource.DataSource = this.dsViewMovto;
            // 
            // vw_movimentoTableAdapter
            // 
            this.vw_movimentoTableAdapter.ClearBeforeFill = true;
            // 
            // fillByFiltroDtaMovimentoToolStrip
            // 
            this.fillByFiltroDtaMovimentoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dtamovimentoToolStripLabel,
            this.dtamovimentoToolStripTextBox,
            this.fillByFiltroDtaMovimentoToolStripButton});
            this.fillByFiltroDtaMovimentoToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByFiltroDtaMovimentoToolStrip.Name = "fillByFiltroDtaMovimentoToolStrip";
            this.fillByFiltroDtaMovimentoToolStrip.Size = new System.Drawing.Size(808, 25);
            this.fillByFiltroDtaMovimentoToolStrip.TabIndex = 4;
            this.fillByFiltroDtaMovimentoToolStrip.Text = "fillByFiltroDtaMovimentoToolStrip";
            this.fillByFiltroDtaMovimentoToolStrip.Visible = false;
            // 
            // dtamovimentoToolStripLabel
            // 
            this.dtamovimentoToolStripLabel.Name = "dtamovimentoToolStripLabel";
            this.dtamovimentoToolStripLabel.Size = new System.Drawing.Size(89, 22);
            this.dtamovimentoToolStripLabel.Text = "dtamovimento:";
            // 
            // dtamovimentoToolStripTextBox
            // 
            this.dtamovimentoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtamovimentoToolStripTextBox.Name = "dtamovimentoToolStripTextBox";
            this.dtamovimentoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByFiltroDtaMovimentoToolStripButton
            // 
            this.fillByFiltroDtaMovimentoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByFiltroDtaMovimentoToolStripButton.Name = "fillByFiltroDtaMovimentoToolStripButton";
            this.fillByFiltroDtaMovimentoToolStripButton.Size = new System.Drawing.Size(146, 22);
            this.fillByFiltroDtaMovimentoToolStripButton.Text = "FillByFiltroDtaMovimento";
            this.fillByFiltroDtaMovimentoToolStripButton.Click += new System.EventHandler(this.fillByFiltroDtaMovimentoToolStripButton_Click);
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.SteelBlue;
            this.panelCabecalho.Controls.Add(this.panelTitulo);
            this.panelCabecalho.Controls.Add(this.panelBotoesJanela);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(808, 50);
            this.panelCabecalho.TabIndex = 8;
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(679, 50);
            this.panelTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(679, 50);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBotoesJanela
            // 
            this.panelBotoesJanela.Controls.Add(this.btnMinimizar);
            this.panelBotoesJanela.Controls.Add(this.btnNormal);
            this.panelBotoesJanela.Controls.Add(this.btnFechar);
            this.panelBotoesJanela.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBotoesJanela.Location = new System.Drawing.Point(679, 0);
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
            // panelForm
            // 
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.rvMovto);
            this.panelForm.Controls.Add(this.cboDtaMovto);
            this.panelForm.Controls.Add(this.btnMostrar);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 50);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(808, 425);
            this.panelForm.TabIndex = 9;
            // 
            // frmRelMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 475);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelCabecalho);
            this.Controls.Add(this.fillByFiltroDtaMovimentoToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelMovimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Fluxo de Caixa";
            this.Load += new System.EventHandler(this.frmRelMovimentacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vw_movimentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsViewMovto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsViewMovtoBindingSource)).EndInit();
            this.fillByFiltroDtaMovimentoToolStrip.ResumeLayout(false);
            this.fillByFiltroDtaMovimentoToolStrip.PerformLayout();
            this.panelCabecalho.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelBotoesJanela.ResumeLayout(false);
            this.panelBotoesJanela.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvMovto;
        private System.Windows.Forms.BindingSource vw_movimentoBindingSource;
        private dsViewMovto dsViewMovto;
        private System.Windows.Forms.BindingSource dsViewMovtoBindingSource;
        private dsViewMovtoTableAdapters.vw_movimentoTableAdapter vw_movimentoTableAdapter;
        private System.Windows.Forms.ComboBox cboDtaMovto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ToolStrip fillByFiltroDtaMovimentoToolStrip;
        private System.Windows.Forms.ToolStripLabel dtamovimentoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dtamovimentoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByFiltroDtaMovimentoToolStripButton;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelBotoesJanela;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panelForm;
    }
}