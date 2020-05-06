using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Runtime.InteropServices;

namespace JogoMemoria
{
    public partial class frmJogo : Form
    {
        //[DllImport("winmm.dll")]
        //private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString,
        //int uReturnLength, int hwndCallback);
        //StringBuilder buffer = new StringBuilder(128);

        // Carrega as figuras das Caixas
        private string[] fig = new string[] {Application.StartupPath + "\\fig1.png",
                                              Application.StartupPath + "\\fig2.png",
                                              Application.StartupPath + "\\fig3.png",
                                              Application.StartupPath + "\\fig4.png",
                                              Application.StartupPath + "\\fig5.png"};

        // Carrega as figuras para a Memoria
        private string[] img = { Application.StartupPath + "\\figura1.png", 
                               Application.StartupPath + "\\figura2.png",
                               Application.StartupPath + "\\figura3.png",
                               Application.StartupPath + "\\figura4.png",
                               Application.StartupPath + "\\figura5.png",
                               Application.StartupPath + "\\figura6.png",
                               Application.StartupPath + "\\figura7.png",
                               Application.StartupPath + "\\figura8.png",
                               Application.StartupPath + "\\figura9.png",
                               Application.StartupPath + "\\figura1.png", 
                               Application.StartupPath + "\\figura2.png",
                               Application.StartupPath + "\\figura3.png",
                               Application.StartupPath + "\\figura4.png",
                               Application.StartupPath + "\\figura5.png",
                               Application.StartupPath + "\\figura6.png",
                               Application.StartupPath + "\\figura7.png",
                               Application.StartupPath + "\\figura8.png",
                               Application.StartupPath + "\\figura9.png"};

        // Verifica a Dupla
        private int[] matriz = new int[18];
        private int vez;
        private PictureBox pic1, pic2;
        private int troca = 0;
        private int figura = 0;
        private int acerto;
        private int figA  = 30, figB = 31;
        private bool sequencia = true;
        private bool termina = false;
        private bool dupla = false;
        private bool jogar = false;
        private int tempo;

        public frmJogo()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            lblPontos.Text = "Pontos : 0";
            acerto = 0;
            figA = 30;
            figB = 31;
            vez = 0;

            // Carrega as imagens
            picA.Image = Image.FromFile(fig[0]);
            picB.Image = Image.FromFile(fig[0]);
            picC.Image = Image.FromFile(fig[0]);
            picD.Image = Image.FromFile(fig[0]);
            picE.Image = Image.FromFile(fig[0]);
            picF.Image = Image.FromFile(fig[0]);
            picG.Image = Image.FromFile(fig[0]);
            picH.Image = Image.FromFile(fig[0]);
            picI.Image = Image.FromFile(fig[0]);
            picJ.Image = Image.FromFile(fig[0]);
            picK.Image = Image.FromFile(fig[0]);
            picL.Image = Image.FromFile(fig[0]);
            picM.Image = Image.FromFile(fig[0]);
            picN.Image = Image.FromFile(fig[0]);
            picO.Image = Image.FromFile(fig[0]);
            picP.Image = Image.FromFile(fig[0]);
            picQ.Image = Image.FromFile(fig[0]);
            picR.Image = Image.FromFile(fig[0]);

            // Libera Imagens
            picA.Enabled = true;
            picB.Enabled = true;
            picC.Enabled = true;
            picD.Enabled = true;
            picE.Enabled = true;
            picF.Enabled = true;
            picG.Enabled = true;
            picH.Enabled = true;
            picI.Enabled = true;
            picJ.Enabled = true;
            picK.Enabled = true;
            picL.Enabled = true;
            picM.Enabled = true;
            picN.Enabled = true;
            picO.Enabled = true;
            picP.Enabled = true;
            picQ.Enabled = true;
            picR.Enabled = true;
        }

        private void SortearFiguras()
        {
            int num;
            Random rnd = new Random();
            bool existe = true;
            bool add = false;

            lstNumeros.Items.Clear();

            num = rnd.Next(0, 18);
            lstNumeros.Items.Add(num);

            // Sorteia os numeros
            for (int x = 0; x < 17; x++)
            {
                if (Convert.ToInt32(lstNumeros.Items[x].ToString()) == num)
                    existe = true;
                else
                {
                    existe = false;
                    matriz[x] = num;
                }

                while (existe)
                {
                    num = rnd.Next(0, 18);
                    for (int y = 0; y < lstNumeros.Items.Count; y++)
                    {
                        if (Convert.ToInt32(lstNumeros.Items[y].ToString()) == num)
                        {
                            add = false;
                            break;
                        }
                        else
                            add = true;
                    }
                    if (add)
                    {
                        lstNumeros.Items.Add(num);
                        break;
                    }
                }
            }

            // Carrega os numeros para matriz
            for (int x = 0; x < 18; x++)
                matriz[x] = Convert.ToInt32(lstNumeros.Items[x].ToString());
        }

        private void InibiFigura(PictureBox p1, PictureBox p2)
        {
            p1.Enabled = false;
            p2.Enabled = false;
        }
        
        private void VerificaAcerto()
        {
            if ((figA == (figB - 9)) || ((figB + 9) == figA) && vez == 2)
                dupla = true;
            else
                dupla = false;

            if (dupla)
            {
                InibiFigura(pic1, pic2);
                figA = 30;
                figB = 31;
                vez = 0;
                acerto++;
                lblPontos.Text = "Pontos : " + (acerto * 10);
            }
            else if (dupla == false && vez == 2)
            {
                timer2.Enabled = true;
                vez = 3;
            }

            if (acerto == 9)
            {
                MessageBox.Show("Parabens!", "Jogo da Memória", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovoJogo.Enabled = true;
                btnIniciar.Enabled = false;
            }
        }

        private void mudar(PictureBox pic)
        {
            if (sequencia)
            {
                if (troca == 0)
                {
                    pic.Image = Image.FromFile(fig[0]);
                    troca = 2;
                }
                else if (troca == 2)
                {
                    pic.Image = Image.FromFile(fig[1]);
                    troca = 3;
                }
                else if (troca == 3)
                {
                    pic.Image = Image.FromFile(fig[2]);
                    troca = 4;
                }
                else if (troca == 4)
                {
                    pic.Image = Image.FromFile(fig[3]);
                    troca = 5;
                }
                else if (troca == 5)
                {
                    pic.Image = Image.FromFile(fig[4]);
                    troca = 4;
                    sequencia = false;
                }
            }
            else if (!sequencia)
            {
                if (troca == 1)
                {
                    pic.Image = Image.FromFile(fig[0]);
                    troca = 0;
                    sequencia = true;
                    termina = true;
                }
                else if (troca == 2)
                {
                    pic.Image = Image.FromFile(fig[1]);
                    troca = 1;
                }
                else if (troca == 3)
                {
                    pic.Image = Image.FromFile(fig[2]);
                    troca = 2;
                }
                else if (troca == 4)
                {
                    pic.Image = Image.FromFile(fig[3]);
                    troca = 3;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (figura == 1)
                mudar(picA);
            else if (figura == 2)
                mudar(picB);
            else if (figura == 3)
                mudar(picC);
            else if (figura == 4)
                mudar(picD);
            else if (figura == 5)
                mudar(picE);
            else if (figura == 6)
                mudar(picF);
            else if (figura == 7)
                mudar(picG);
            else if (figura == 8)
                mudar(picH);
            else if (figura == 9)
                mudar(picI);
            else if (figura == 10)
                mudar(picJ);
            else if (figura == 11)
                mudar(picK);
            else if (figura == 12)
                mudar(picL);
            else if (figura == 13)
                mudar(picM);
            else if (figura == 14)
                mudar(picN);
            else if (figura == 15)
                mudar(picO);
            else if (figura == 16)
                mudar(picP);
            else if (figura == 17)
                mudar(picQ);
            else if (figura == 18)
                mudar(picR);

            if (termina)
            {
                timer1.Enabled = false;
                if (figura == 1)
                    picA.Image = Image.FromFile(img[matriz[0]]);
                else if (figura == 2)
                    picB.Image = Image.FromFile(img[matriz[1]]);
                else if (figura == 3)
                    picC.Image = Image.FromFile(img[matriz[2]]);
                else if (figura == 4)
                    picD.Image = Image.FromFile(img[matriz[3]]);
                else if (figura == 5)
                    picE.Image = Image.FromFile(img[matriz[4]]);
                else if (figura == 6)
                    picF.Image = Image.FromFile(img[matriz[5]]);
                else if (figura == 7)
                    picG.Image = Image.FromFile(img[matriz[6]]);
                else if (figura == 8)
                    picH.Image = Image.FromFile(img[matriz[7]]);
                else if (figura == 9)
                    picI.Image = Image.FromFile(img[matriz[8]]);
                else if (figura == 10)
                    picJ.Image = Image.FromFile(img[matriz[9]]);
                else if (figura == 11)
                    picK.Image = Image.FromFile(img[matriz[10]]);
                else if (figura == 12)
                    picL.Image = Image.FromFile(img[matriz[11]]);
                else if (figura == 13)
                    picM.Image = Image.FromFile(img[matriz[12]]);
                else if (figura == 14)
                    picN.Image = Image.FromFile(img[matriz[13]]);
                else if (figura == 15)
                    picO.Image = Image.FromFile(img[matriz[14]]);
                else if (figura == 16)
                    picP.Image = Image.FromFile(img[matriz[15]]);
                else if (figura == 17)
                    picQ.Image = Image.FromFile(img[matriz[16]]);
                else if (figura == 18)
                    picR.Image = Image.FromFile(img[matriz[17]]);
            }
        }

        private void frmJogo_FormClosed(object sender, EventArgs e)
        {
            //mciSendString("close Mp3File", buffer, 128, 0);
            this.Dispose();
        }

        private void picA_Click(object sender, EventArgs e)
        {
            if (vez > 2)
                vez = 0;

            if (vez == 0)
            {
                figA = matriz[0];
                vez = 1;
                pic1 = picA;
            }
            else if (vez == 1)
            {
                figB = matriz[0];
                vez = 2;
                pic2 = picA;
            }

            figura = Convert.ToInt32(picA.Tag);
            termina = false;
            timer1.Enabled = true;
            VerificaAcerto();
        }

        private void picB_Click(object sender, EventArgs e)
        {
            if (vez > 2)
                vez = 0;

            if (vez == 0)
            {
                figA = matriz[1];
                vez = 1;
                pic1 = picB;
            }
            else if (vez == 1)
            {
                figB = matriz[1];
                vez = 2;
                pic2 = picB;
            }

            figura = Convert.ToInt32(picB.Tag);
            termina = false;
            timer1.Enabled = true;
            VerificaAcerto();
        }

        private void picC_Click(object sender, EventArgs e)
        {
            if (vez > 2)
                vez = 0;

            if (vez == 0)
            {
                figA = matriz[2];
                vez = 1;
                pic1 = picC;
            }
            else if (vez == 1)
            {
                figB = matriz[2];
                vez = 2;
                pic2 = picC;
            }

            figura = Convert.ToInt32(picC.Tag);
            termina = false;
            timer1.Enabled = true;
            VerificaAcerto();
        }

        private void picD_Click(object sender, EventArgs e)
        {
            if (vez > 2)
                vez = 0;

            if (vez == 0)
            {
                figA = matriz[3];
                vez = 1;
                pic1 = picD;
            }
            else if (vez == 1)
            {
                figB = matriz[3];
                vez = 2;
                pic2 = picD;
            }

            figura = Convert.ToInt32(picD.Tag);
            termina = false;
            timer1.Enabled = true;
            VerificaAcerto();
        }

        private void picE_Click(object sender, EventArgs e)
        {
            if (vez > 2)
                vez = 0;

            if (vez == 0)
            {
                figA = matriz[4];
                vez = 1;
                pic1 = picE;
            }
            else if (vez == 1)
            {
                figB = matriz[4];
                vez = 2;
                pic2 = picE;
            }

            figura = Convert.ToInt32(picE.Tag);
            termina = false;
            timer1.Enabled = true;
            VerificaAcerto();
        }

        private void picF_Click(object sender, EventArgs e)
        {
            if (vez > 2)
                vez = 0;

            if (vez == 0)
            {
                figA = matriz[5];
                vez = 1;
                pic1 = picF;
            }
            else if (vez == 1)
            {
                figB = matriz[5];
                vez = 2;
                pic2 = picF;
            }

            figura = Convert.ToInt32(picF.Tag);
            termina = false;
            timer1.Enabled = true;
            VerificaAcerto();
        }

        private void picG_Click(object sender, EventArgs e)
        {
            if (vez > 2)
                vez = 0;

            if (vez == 0)
            {
                figA = matriz[6];
                vez = 1;
                pic1 = picG;
            }
            else if (vez == 1)
            {
                figB = matriz[6];
                vez = 2;
                pic2 = picG;
            }

            figura = Convert.ToInt32(picG.Tag);
            termina = false;
            timer1.Enabled = true;
            VerificaAcerto();
        }

        private void picH_Click(object sender, EventArgs e)
        {
            if (vez > 2)
                vez = 0;

            if (vez == 0)
            {
                figA = matriz[7];
                vez = 1;
                pic1 = picH;
            }
            else if (vez == 1)
            {
                figB = matriz[7];
                vez = 2;
                pic2 = picH;
            }

            figura = Convert.ToInt32(picH.Tag);
            termina = false;
            timer1.Enabled = true;
            VerificaAcerto();
        }

        private void picI_Click(object sender, EventArgs e)
        {
            if (vez > 2)
                vez = 0;

            if (vez == 0)
            {
                figA = matriz[8];
                vez = 1;
                pic1 = picI;
            }
            else if (vez == 1)
            {
                figB = matriz[8];
                vez = 2;
                pic2 = picI;
            }

            figura = Convert.ToInt32(picI.Tag);
            termina = false;
            timer1.Enabled = true;
            VerificaAcerto();
        }

        private void picJ_Click(object sender, EventArgs e)
        {
            if (vez > 2)
                vez = 0;

            if (vez == 0)
            {
                figA = matriz[9];
                vez = 1;
                pic1 = picJ;
            }
            else if (vez == 1)
            {
                figB = matriz[9];
                vez = 2;
                pic2 = picJ;
            }

            figura = Convert.ToInt32(picJ.Tag);
            termina = false;
            timer1.Enabled = true;
            VerificaAcerto();
        }

        private void picK_Click(object sender, EventArgs e)
        {
            if (vez > 2)
                vez = 0;

            if (vez == 0)
            {
                figA = matriz[10];
                vez = 1;
                pic1 = picK;
            }
            else if (vez == 1)
            {
                figB = matriz[10];
                vez = 2;
                pic2 = picK;
            }

            figura = Convert.ToInt32(picK.Tag);
            termina = false;
            timer1.Enabled = true;
            VerificaAcerto();
        }

        private void picL_Click(object sender, EventArgs e)
        {
            if (vez > 2)
                vez = 0;

            if (vez == 0)
            {
                figA = matriz[11];
                vez = 1;
            
                pic1 = picL;
            }
            else if (vez == 1)
            {
                figB = matriz[11];
                vez = 2;
                pic2 = picL;
            }

            figura = Convert.ToInt32(picL.Tag);
            termina = false;
            timer1.Enabled = true;
            VerificaAcerto();
        }

        private void picM_Click(object sender, EventArgs e)
        {
            if (vez > 2)
                vez = 0;

            if (vez == 0)
            {
                figA = matriz[12];
                vez = 1;
                pic1 = picM;
            }
            else if (vez == 1)
            {
                figB = matriz[12];
                vez = 2;
                pic2 = picM;
            }

            figura = Convert.ToInt32(picM.Tag);
            termina = false;
            timer1.Enabled = true;
            VerificaAcerto();
        }

        private void picN_Click(object sender, EventArgs e)
        {
            if (vez > 2)
                vez = 0;

            if (vez == 0)
            {
                figA = matriz[13];
                vez = 1;
                pic1 = picN;
            }
            else if (vez == 1)
            {
                figB = matriz[13];
                vez = 2;
                pic2 = picN;
            }

            figura = Convert.ToInt32(picN.Tag);
            termina = false;
            timer1.Enabled = true;
            VerificaAcerto();
        }

        private void picO_Click(object sender, EventArgs e)
        {
            if (vez > 2)
                vez = 0;

            if (vez == 0)
            {
                figA = matriz[14];
                vez = 1;
                pic1 = picO;
            }
            else if (vez == 1)
            {
                figB = matriz[14];
                vez = 2;
                pic2 = picO;
            }

            figura = Convert.ToInt32(picO.Tag);
            termina = false;
            timer1.Enabled = true;
            VerificaAcerto();
        }

        private void picP_Click(object sender, EventArgs e)
        {
            if (vez > 2)
                vez = 0;

            if (vez == 0)
            {
                figA = matriz[15];
                vez = 1;
                pic1 = picP;
            }
            else if (vez == 1)
            {
                figB = matriz[15];
                vez = 2;
                pic2 = picP;
            }

            figura = Convert.ToInt32(picP.Tag);
            termina = false;
            timer1.Enabled = true;
            VerificaAcerto();
        }

        private void picQ_Click(object sender, EventArgs e)
        {
            if (vez > 2)
                vez = 0;

            if (vez == 0)
            {
                figA = matriz[16];
                vez = 1;
                pic1 = picQ;
            }
            else if (vez == 1)
            {
                figB = matriz[16];
                vez = 2;
                pic2 = picQ;
            }

            figura = Convert.ToInt32(picQ.Tag);
            termina = false;
            timer1.Enabled = true;
            VerificaAcerto();
        }

        private void picR_Click(object sender, EventArgs e)
        {
            if (vez > 2)
                vez = 0;

            if (vez == 0)
            {
                figA = matriz[17];
                vez = 1;
                pic1 = picR;
            }
            else if (vez == 1)
            {
                figB = matriz[17];
                vez = 2;
                pic2 = picR;
            }

            figura = Convert.ToInt32(picR.Tag);
            termina = false;
            timer1.Enabled = true;
            VerificaAcerto();
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            if (optDificil.Checked == false && optFacil.Checked == false && optMedio.Checked == false)
            {
                MessageBox.Show("Selecione o nível!", "Jogo da Memória", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            btnIniciar.Enabled = true;
            optFacil.Enabled = false;
            optMedio.Enabled = false;
            optDificil.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (dupla == false && vez == 3)
            {
                pic1.Image = Image.FromFile(fig[0]);
                pic2.Image = Image.FromFile(fig[0]);
                vez = 0;
                figA = 30;
                figB = 31;
                figura = 0;
                pic1 = null;
                pic2 = null;
            }
            timer2.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            tempo--;
            lblTempo.Text = "Tempo : " + (tempo);
            if (tempo == 0)
            {
                MessageBox.Show("Você perdeu!");
                timer3.Enabled = false;
                btnNovoJogo.Enabled = true;
                btnIniciar.Enabled = false;
                optFacil.Enabled = true;
                optMedio.Enabled = true;
                optDificil.Enabled = true;
            }
        }

        private void optFacil_CheckedChanged(object sender, EventArgs e)
        {
            tempo = 120;
            lblTempo.Text = "Tempo : 120";
        }

        private void optMedio_CheckedChanged(object sender, EventArgs e)
        {
            tempo = 90;
            lblTempo.Text = "Tempo : 90";
        }

        private void optDificil_CheckedChanged(object sender, EventArgs e)
        {
            tempo = 60;
            lblTempo.Text = "Tempo : 60";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (optFacil.Checked)
                tempo = 120;
            else if (optMedio.Checked)
                tempo=  90;
            else if (optDificil.Checked)
                tempo = 60;

            Limpar();
            SortearFiguras();
            timer3.Enabled = true;
            btnNovoJogo.Enabled = false;
            optFacil.Enabled = false;
            optMedio.Enabled = false;
            optDificil.Enabled = false;
            btnIniciar.Enabled = false;
        }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            //mciSendString("open " + "\"" + Application.StartupPath + "\\teste.mp3" + "\"" +
            //" type MPEGVideo alias Mp3File", null, 0, 0);
            //mciSendString("play Mp3File", buffer, 128, 0);
            //mciSendString("repeat Mp3File", buffer, 128, 0);
            btnNovoJogo.Enabled = true;
            btnIniciar.Enabled = false;
        }
    }
}