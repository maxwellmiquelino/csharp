namespace Estacionamento.AppUtil
{
    partial class Mensagem
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
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.panelCabecalho.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.SteelBlue;
            this.panelCabecalho.Controls.Add(this.lblTitulo);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(800, 50);
            this.panelCabecalho.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 50);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.lblMsg);
            this.panelForm.Controls.Add(this.panel1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 50);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(800, 400);
            this.panelForm.TabIndex = 4;
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(12, 12);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(776, 294);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 81);
            this.panel1.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(251, 8);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(311, 65);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Mensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mensagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMensagem_Load);
            this.panelCabecalho.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblMsg;
    }
}