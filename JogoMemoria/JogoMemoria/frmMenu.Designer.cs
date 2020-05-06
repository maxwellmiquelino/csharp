namespace JogoMemoria
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
            this.lblJogar = new System.Windows.Forms.Label();
            this.lblAjuda = new System.Windows.Forms.Label();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblJogar
            // 
            this.lblJogar.Font = new System.Drawing.Font("Quartz MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogar.Location = new System.Drawing.Point(256, 176);
            this.lblJogar.Name = "lblJogar";
            this.lblJogar.Size = new System.Drawing.Size(235, 81);
            this.lblJogar.TabIndex = 0;
            this.lblJogar.Text = "jogar";
            this.lblJogar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAjuda
            // 
            this.lblAjuda.Font = new System.Drawing.Font("Quartz MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjuda.Location = new System.Drawing.Point(218, 257);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(305, 81);
            this.lblAjuda.TabIndex = 0;
            this.lblAjuda.Text = "ajuda";
            this.lblAjuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreditos
            // 
            this.lblCreditos.Font = new System.Drawing.Font("Quartz MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditos.Location = new System.Drawing.Point(194, 338);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(359, 81);
            this.lblCreditos.TabIndex = 0;
            this.lblCreditos.Text = "creditos";
            this.lblCreditos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSair
            // 
            this.lblSair.Font = new System.Drawing.Font("Quartz MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.Location = new System.Drawing.Point(270, 419);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(207, 81);
            this.lblSair.TabIndex = 0;
            this.lblSair.Text = "sair";
            this.lblSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 45;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Quartz MS", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(760, 115);
            this.label1.TabIndex = 1;
            this.label1.Text = "jogo da memoria";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(760, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Use a telca \'S\' para mudar para baixo e \'W\' para mudar para cima e \'ENTER\' para s" +
    "elecionar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.lblAjuda);
            this.Controls.Add(this.lblJogar);
            this.KeyPreview = true;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Memoria";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMenu_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblJogar;
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

