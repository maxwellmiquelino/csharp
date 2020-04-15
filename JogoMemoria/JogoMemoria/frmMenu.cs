using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace JogoMemoria
{
    public partial class frmMenu : Form
    {
        private int _TamMax = 48;
        private int _TamMin = 36;
        private bool flag;
        private float x = 0;
        private int selecao = 0;
        private SoundPlayer snd = new SoundPlayer(Application.StartupPath + "\\menu.wav");

        public frmMenu()
        {
            InitializeComponent();
        }

        private void MontaLabel(Label lbl)
        {
            lbl.ForeColor = Color.DarkRed;
            if (lbl.Font.Size <= _TamMax && lbl.Font.Size > _TamMin && !flag)
            {
                x = lbl.Font.Size - 1;
                lbl.Font = new Font(lbl.Font.FontFamily, x);
                if (lbl.Font.Size == _TamMin)
                    flag = true;
            }
            else if (lbl.Font.Size > (_TamMin - 1) && flag)
            {
                x = lbl.Font.Size + 1;
                lbl.Font = new Font(lbl.Font.FontFamily, x);
                if (lbl.Font.Size == _TamMax)
                    flag = false;
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            // Centralizando os Labels
            lblJogar.Left = (this.Width - lblJogar.Width) / 2;
            lblAjuda.Left = (this.Width - lblAjuda.Width) / 2;
            lblCreditos.Left = (this.Width - lblCreditos.Width) / 2;
            lblSair.Left = (this.Width - lblSair.Width) / 2;

            selecao = 1;
        }

        private void frmMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            flag = false;
            if (e.KeyChar == 115)
            {
                snd.Play();
                selecao++;
                if (selecao == 5)
                    selecao = 1;
            }
            if (e.KeyChar == 119)
            {
                snd.Play();
                selecao--;
                if (selecao == 0)
                    selecao = 4;
            }

            if (e.KeyChar == 13)
            {
                switch (selecao)
                {
                    case 1:
                        {
                            frmJogo fJogo = new frmJogo();
                            fJogo.ShowDialog();
                            break;
                        }
                    case 2:
                        {
                            MessageBox.Show("Ajuda\n\n" +
                                "1 - Selecione o nível do jogo onde tenha as opçoes Facil,Médio e Difícil\n" +
                                "2 - Clique no botão Novo jogo\n" +
                                "3 - Clique no botão Inicar para sortear as figuras e liberar o tempo para jogar"+
                                "\n\nTempos\n\nFácil = 60 Segundos\nMédio = 45 Segundos\nDifícil = 30 Segundos",
                                "Jogo da Memória", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    case 3:
                        {
                            MessageBox.Show("Créditos\n\n" +
                                "Programação, Design e Som por Maxwell",
                                "Jogo da Memória", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    case 4:
                        {
                            this.Close();
                            break;
                        }

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (selecao == 1)
            {
                MontaLabel(lblJogar);
                lblAjuda.Font = new Font(lblAjuda.Font.FontFamily, _TamMax);
                lblAjuda.ForeColor = Color.Black;
                lblCreditos.Font = new Font(lblCreditos.Font.FontFamily, _TamMax);
                lblCreditos.ForeColor = Color.Black;
                lblSair.Font = new Font(lblSair.Font.FontFamily, _TamMax);
                lblSair.ForeColor = Color.Black;
            }
            else if (selecao == 2)
            {
                MontaLabel(lblAjuda);
                lblJogar.Font = new Font(lblJogar.Font.FontFamily, _TamMax);
                lblJogar.ForeColor = Color.Black;
                lblCreditos.Font = new Font(lblCreditos.Font.FontFamily, _TamMax);
                lblCreditos.ForeColor = Color.Black;
                lblSair.Font = new Font(lblSair.Font.FontFamily, _TamMax);
                lblSair.ForeColor = Color.Black;
            }
            else if (selecao == 3)
            {
                MontaLabel(lblCreditos);
                lblAjuda.Font = new Font(lblAjuda.Font.FontFamily, _TamMax);
                lblAjuda.ForeColor = Color.Black;
                lblJogar.Font = new Font(lblJogar.Font.FontFamily, _TamMax);
                lblJogar.ForeColor = Color.Black;
                lblSair.Font = new Font(lblSair.Font.FontFamily, _TamMax);
                lblSair.ForeColor = Color.Black;
            }
            else if (selecao == 4)
            {
                MontaLabel(lblSair);
                lblAjuda.Font = new Font(lblAjuda.Font.FontFamily, _TamMax);
                lblAjuda.ForeColor = Color.Black;
                lblCreditos.Font = new Font(lblCreditos.Font.FontFamily, _TamMax);
                lblCreditos.ForeColor = Color.Black;
                lblJogar.Font = new Font(lblJogar.Font.FontFamily, _TamMax);
                lblJogar.ForeColor = Color.Black;
            }
        }
    }
}
