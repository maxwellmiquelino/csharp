namespace JogoForca
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblJogar = new System.Windows.Forms.Label();
            this.lblPerguntas = new System.Windows.Forms.Label();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAjuda = new System.Windows.Forms.Label();
            this.pCredito = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecharCredito = new System.Windows.Forms.Label();
            this.pInstrucao = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFecharInstrucao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pCredito.SuspendLayout();
            this.pInstrucao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJogar
            // 
            this.lblJogar.BackColor = System.Drawing.Color.Black;
            this.lblJogar.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogar.ForeColor = System.Drawing.Color.White;
            this.lblJogar.Location = new System.Drawing.Point(12, 113);
            this.lblJogar.Name = "lblJogar";
            this.lblJogar.Size = new System.Drawing.Size(606, 55);
            this.lblJogar.TabIndex = 0;
            this.lblJogar.Text = "JOGAR";
            this.lblJogar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPerguntas
            // 
            this.lblPerguntas.BackColor = System.Drawing.Color.Black;
            this.lblPerguntas.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerguntas.ForeColor = System.Drawing.Color.White;
            this.lblPerguntas.Location = new System.Drawing.Point(12, 168);
            this.lblPerguntas.Name = "lblPerguntas";
            this.lblPerguntas.Size = new System.Drawing.Size(606, 55);
            this.lblPerguntas.TabIndex = 0;
            this.lblPerguntas.Text = "PERGUNTAS";
            this.lblPerguntas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreditos
            // 
            this.lblCreditos.BackColor = System.Drawing.Color.Black;
            this.lblCreditos.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditos.ForeColor = System.Drawing.Color.White;
            this.lblCreditos.Location = new System.Drawing.Point(12, 223);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(606, 55);
            this.lblCreditos.TabIndex = 0;
            this.lblCreditos.Text = "CREDITOS";
            this.lblCreditos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSair
            // 
            this.lblSair.BackColor = System.Drawing.Color.Black;
            this.lblSair.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.ForeColor = System.Drawing.Color.White;
            this.lblSair.Location = new System.Drawing.Point(12, 333);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(606, 55);
            this.lblSair.TabIndex = 0;
            this.lblSair.Text = "SAIR";
            this.lblSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSair.DoubleClick += new System.EventHandler(this.lblSair_DoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "JOGO DA FORCA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(12, 9);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(93, 101);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(12, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(606, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Use as setas cima e para baixo e \'ENTER\' para selecionar!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAjuda
            // 
            this.lblAjuda.BackColor = System.Drawing.Color.Black;
            this.lblAjuda.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjuda.ForeColor = System.Drawing.Color.White;
            this.lblAjuda.Location = new System.Drawing.Point(12, 278);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(606, 55);
            this.lblAjuda.TabIndex = 3;
            this.lblAjuda.Text = "AJUDA";
            this.lblAjuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pCredito
            // 
            this.pCredito.BackColor = System.Drawing.Color.Silver;
            this.pCredito.Controls.Add(this.label2);
            this.pCredito.Controls.Add(this.lblFecharCredito);
            this.pCredito.Location = new System.Drawing.Point(103, 136);
            this.pCredito.Name = "pCredito";
            this.pCredito.Size = new System.Drawing.Size(443, 217);
            this.pCredito.TabIndex = 4;
            this.pCredito.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 98);
            this.label2.TabIndex = 1;
            this.label2.Text = "Programação, Design e Som por Maxwell Miquelino";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecharCredito
            // 
            this.lblFecharCredito.AutoSize = true;
            this.lblFecharCredito.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecharCredito.Location = new System.Drawing.Point(409, 0);
            this.lblFecharCredito.Name = "lblFecharCredito";
            this.lblFecharCredito.Size = new System.Drawing.Size(34, 36);
            this.lblFecharCredito.TabIndex = 0;
            this.lblFecharCredito.Text = "X";
            this.lblFecharCredito.Click += new System.EventHandler(this.lblFecharCredito_Click);
            // 
            // pInstrucao
            // 
            this.pInstrucao.BackColor = System.Drawing.Color.Silver;
            this.pInstrucao.Controls.Add(this.label5);
            this.pInstrucao.Controls.Add(this.lblFecharInstrucao);
            this.pInstrucao.Location = new System.Drawing.Point(93, 113);
            this.pInstrucao.Name = "pInstrucao";
            this.pInstrucao.Size = new System.Drawing.Size(453, 290);
            this.pInstrucao.TabIndex = 2;
            this.pInstrucao.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(447, 204);
            this.label5.TabIndex = 1;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // lblFecharInstrucao
            // 
            this.lblFecharInstrucao.AutoSize = true;
            this.lblFecharInstrucao.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecharInstrucao.Location = new System.Drawing.Point(416, 0);
            this.lblFecharInstrucao.Name = "lblFecharInstrucao";
            this.lblFecharInstrucao.Size = new System.Drawing.Size(34, 36);
            this.lblFecharInstrucao.TabIndex = 0;
            this.lblFecharInstrucao.Text = "X";
            this.lblFecharInstrucao.Click += new System.EventHandler(this.lblFecharInstrucao_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(630, 448);
            this.Controls.Add(this.pInstrucao);
            this.Controls.Add(this.pCredito);
            this.Controls.Add(this.lblAjuda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.lblPerguntas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJogar);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desenvolvido por Maxwell";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMenu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pCredito.ResumeLayout(false);
            this.pCredito.PerformLayout();
            this.pInstrucao.ResumeLayout(false);
            this.pInstrucao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblJogar;
        private System.Windows.Forms.Label lblPerguntas;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.Panel pCredito;
        private System.Windows.Forms.Label lblFecharCredito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pInstrucao;
        private System.Windows.Forms.Label lblFecharInstrucao;
        private System.Windows.Forms.Label label5;
    }
}