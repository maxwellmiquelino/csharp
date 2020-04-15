using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Media;

namespace JogoForca
{
    public partial class frmJogo : Form
    {
        private bool existe = true;
        private String SQL;
        private OleDbCommand conn = new OleDbCommand();
        private int erros, acerto;
        private String resposta;

        public frmJogo()
        {
            InitializeComponent();
        }

        private void MontaForca()
        {
            switch (erros)
            {
                case 1:
                    picForca.Image = Image.FromFile(Application.StartupPath + "\\ForcaA.PNG");
                    break;
                case 2:
                    picForca.Image = Image.FromFile(Application.StartupPath + "\\ForcaB.PNG");
                    break;
                case 3:
                    picForca.Image = Image.FromFile(Application.StartupPath + "\\ForcaC.PNG");
                    break;
                case 4:
                    picForca.Image = Image.FromFile(Application.StartupPath + "\\ForcaD.PNG");
                    break;
                case 5:
                    picForca.Image = Image.FromFile(Application.StartupPath + "\\ForcaE.PNG");
                    break;
                case 6:
                    picForca.Image = Image.FromFile(Application.StartupPath + "\\ForcaF.PNG");
                    break;
                case 7:
                    picForca.Image = Image.FromFile(Application.StartupPath + "\\ForcaG.PNG");
                    MessageBox.Show("Você perdeu! Tente novamente!", "Jogo da Forca");
                    lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) - (acerto * 20));
                    LimpaResposta();
                    Botao();
                    NovoJogo();
                    break;
            }
        }

        private bool VerificaGanhador()
        {
            bool st = false;

            if (Len(resposta.Replace(" ","")) == acerto)
            {
                st = true;
            }
            return st;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool VerificaJogada(String txt)
        {
            bool flag = false;

            for (int x = 1; x <= Len(resposta); x++)
            {
                if (Mid(resposta, x, 1) == txt.ToString())
                {
                    for (int y = 0; y <= this.Controls.Count - 1; y++)
                    {
                        if (this.Controls[y] is Label)
                        {
                            if (Convert.ToInt32(this.Controls[y].Tag) == x)
                            {
                                this.Controls[y].Text = txt.ToString();
                                acerto++;
                                break;
                            }
                        }
                    }
                    flag = true;
                }
            }

            return flag;
        }

        private void LimpaResposta()
        {
            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = "";
            lbl6.Text = "";
            lbl7.Text = "";
            lbl8.Text = "";
            lbl9.Text = "";
            lbl10.Text = "";
            lbl11.Text = "";
            lbl12.Text = "";
            lbl13.Text = "";
            lbl14.Text = "";
            lbl15.Text = "";
            lbl16.Text = "";
            lbl17.Text = "";
            lbl18.Text = "";
            lbl19.Text = "";
            lbl20.Text = "";
        }

        private void Botao()
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            btnF.Enabled = true;
            btnG.Enabled = true;
            btnH.Enabled = true;
            btnI.Enabled = true;
            btnJ.Enabled = true;
            btnK.Enabled = true;
            btnL.Enabled = true;
            btnM.Enabled = true;
            btnN.Enabled = true;
            btnO.Enabled = true;
            btnP.Enabled = true;
            btnQ.Enabled = true;
            btnR.Enabled = true;
            btnS.Enabled = true;
            btnT.Enabled = true;
            btnU.Enabled = true;
            btnV.Enabled = true;
            btnW.Enabled = true;
            btnX.Enabled = true;
            btnY.Enabled = true;
            btnZ.Enabled = true;
        }

        private static int Len(String Texto)
        {
            int cTxt;

            if (Texto.ToString().Trim().Length == null)
                cTxt = 0;

            cTxt = Texto.ToString().Trim().Length;

            return cTxt;
        }

        private static string Mid(string valor, int inicio, int qtde)
        {
            string strMid = valor.Substring(inicio - 1, qtde);
            return strMid;
        }

        private void NovoJogo()
        {
            acerto = 0;
            //pontos = 0;
            erros = 0;
            picForca.Image = Image.FromFile(Application.StartupPath + "\\Forca.PNG");

            Random rd = new Random();
            int contador;
            OleDbDataReader dr;
            // Conta quantas perguntas tem
            SQL = "SELECT COUNT(ID) AS CONTA FROM PERGUNTA";
            try
            {
                conn.CommandText = SQL;
                conn.Connection = BD.ConectaBD();
                contador = rd.Next(1, Convert.ToInt32(conn.ExecuteScalar().ToString()));

                // Verifica se ja fez essa pergunta
                for (int x = 0; x <= lstContador.Items.Count - 1; x++)
                {
                    if (Convert.ToInt32(lstContador.Items[x]) == contador)
                    {
                        while (Convert.ToInt32(lstContador.Items[x]) == contador)
                        {
                            contador = rd.Next(1, Convert.ToInt32(conn.ExecuteScalar().ToString()));
                        }
                        existe = true;
                        break;
                    }
                }
                if (existe)
                    lstContador.Items.Add(contador);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro\n\n" + ex.ToString(), "Jogo da Forca");
                return;
            }

            lblPergunta.Text = "";

            SQL = "SELECT PERGUNTA,RESPOSTA FROM PERGUNTA WHERE ID = " + Convert.ToInt32(contador);
            try
            {
                conn.CommandText = SQL;
                conn.Connection = BD.ConectaBD();
                dr = conn.ExecuteReader();
                if (dr.Read())
                {
                    lblPergunta.Text = dr["PERGUNTA"].ToString();
                    resposta = dr["RESPOSTA"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro\n\n" + ex.ToString(), "Jogo da Forca");
            }

            switch(Len(resposta))
            {
                case 1:
                    {
                        lbl1.Visible = true;
                        lbl2.Visible = false;
                        lbl3.Visible = false;
                        lbl4.Visible = false;
                        lbl5.Visible = false;
                        lbl6.Visible = false;
                        lbl7.Visible = false;
                        lbl8.Visible = false;
                        lbl9.Visible = false;
                        lbl10.Visible = false;
                        lbl11.Visible = false;
                        lbl12.Visible = false;
                        lbl13.Visible = false;
                        lbl14.Visible = false;
                        lbl15.Visible = false;
                        lbl16.Visible = false;
                        lbl17.Visible = false;
                        lbl18.Visible = false;
                        lbl19.Visible = false;
                        lbl20.Visible = false;
                        break;
                    }
                case 2:
                    {
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = false;
                        lbl4.Visible = false;
                        lbl5.Visible = false;
                        lbl6.Visible = false;
                        lbl7.Visible = false;
                        lbl8.Visible = false;
                        lbl9.Visible = false;
                        lbl10.Visible = false;
                        lbl11.Visible = false;
                        lbl12.Visible = false;
                        lbl13.Visible = false;
                        lbl14.Visible = false;
                        lbl15.Visible = false;
                        lbl16.Visible = false;
                        lbl17.Visible = false;
                        lbl18.Visible = false;
                        lbl19.Visible = false;
                        lbl20.Visible = false;
                        break;
                    }
                case 3:
                    {
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = false;
                        lbl5.Visible = false;
                        lbl6.Visible = false;
                        lbl7.Visible = false;
                        lbl8.Visible = false;
                        lbl9.Visible = false;
                        lbl10.Visible = false;
                        lbl11.Visible = false;
                        lbl12.Visible = false;
                        lbl13.Visible = false;
                        lbl14.Visible = false;
                        lbl15.Visible = false;
                        lbl16.Visible = false;
                        lbl17.Visible = false;
                        lbl18.Visible = false;
                        lbl19.Visible = false;
                        lbl20.Visible = false;
                        break;
                    }
                case 4:
                    {
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = false;
                        lbl6.Visible = false;
                        lbl7.Visible = false;
                        lbl8.Visible = false;
                        lbl9.Visible = false;
                        lbl10.Visible = false;
                        lbl11.Visible = false;
                        lbl12.Visible = false;
                        lbl13.Visible = false;
                        lbl14.Visible = false;
                        lbl15.Visible = false;
                        lbl16.Visible = false;
                        lbl17.Visible = false;
                        lbl18.Visible = false;
                        lbl19.Visible = false;
                        lbl20.Visible = false;
                        break;
                    }
                case 5:
                    {
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = true;
                        lbl6.Visible = false;
                        lbl7.Visible = false;
                        lbl8.Visible = false;
                        lbl9.Visible = false;
                        lbl10.Visible = false;
                        lbl11.Visible = false;
                        lbl12.Visible = false;
                        lbl13.Visible = false;
                        lbl14.Visible = false;
                        lbl15.Visible = false;
                        lbl16.Visible = false;
                        lbl17.Visible = false;
                        lbl18.Visible = false;
                        lbl19.Visible = false;
                        lbl20.Visible = false;
                        break;
                    }
                case 6:
                    {
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = true;
                        lbl6.Visible = true;
                        lbl7.Visible = false;
                        lbl8.Visible = false;
                        lbl9.Visible = false;
                        lbl10.Visible = false;
                        lbl11.Visible = false;
                        lbl12.Visible = false;
                        lbl13.Visible = false;
                        lbl14.Visible = false;
                        lbl15.Visible = false;
                        lbl16.Visible = false;
                        lbl17.Visible = false;
                        lbl18.Visible = false;
                        lbl19.Visible = false;
                        lbl20.Visible = false;
                        break;
                    }
                case 7:
                    {
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = true;
                        lbl6.Visible = true;
                        lbl7.Visible = true;
                        lbl8.Visible = false;
                        lbl9.Visible = false;
                        lbl10.Visible = false;
                        lbl11.Visible = false;
                        lbl12.Visible = false;
                        lbl13.Visible = false;
                        lbl14.Visible = false;
                        lbl15.Visible = false;
                        lbl16.Visible = false;
                        lbl17.Visible = false;
                        lbl18.Visible = false;
                        lbl19.Visible = false;
                        lbl20.Visible = false;
                        break;
                    }
                case 8:
                    {
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = true;
                        lbl6.Visible = true;
                        lbl7.Visible = true;
                        lbl8.Visible = true;
                        lbl9.Visible = false;
                        lbl10.Visible = false;
                        lbl11.Visible = false;
                        lbl12.Visible = false;
                        lbl13.Visible = false;
                        lbl14.Visible = false;
                        lbl15.Visible = false;
                        lbl16.Visible = false;
                        lbl17.Visible = false;
                        lbl18.Visible = false;
                        lbl19.Visible = false;
                        lbl20.Visible = false;
                        break;
                    }
                case 9:
                    {
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = true;
                        lbl6.Visible = true;
                        lbl7.Visible = true;
                        lbl8.Visible = true;
                        lbl9.Visible = true;
                        lbl10.Visible = false;
                        lbl11.Visible = false;
                        lbl12.Visible = false;
                        lbl13.Visible = false;
                        lbl14.Visible = false;
                        lbl15.Visible = false;
                        lbl16.Visible = false;
                        lbl17.Visible = false;
                        lbl18.Visible = false;
                        lbl19.Visible = false;
                        lbl20.Visible = false;
                        break;
                    }
                case 10:
                    {
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = true;
                        lbl6.Visible = true;
                        lbl7.Visible = true;
                        lbl8.Visible = true;
                        lbl9.Visible = true;
                        lbl10.Visible = true;
                        lbl11.Visible = false;
                        lbl12.Visible = false;
                        lbl13.Visible = false;
                        lbl14.Visible = false;
                        lbl15.Visible = false;
                        lbl16.Visible = false;
                        lbl17.Visible = false;
                        lbl18.Visible = false;
                        lbl19.Visible = false;
                        lbl20.Visible = false;
                        break;
                    }
                case 11:
                    {
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = true;
                        lbl6.Visible = true;
                        lbl7.Visible = true;
                        lbl8.Visible = true;
                        lbl9.Visible = true;
                        lbl10.Visible = true;
                        lbl11.Visible = true;
                        lbl12.Visible = false;
                        lbl13.Visible = false;
                        lbl14.Visible = false;
                        lbl15.Visible = false;
                        lbl16.Visible = false;
                        lbl17.Visible = false;
                        lbl18.Visible = false;
                        lbl19.Visible = false;
                        lbl20.Visible = false;
                        break;
                    }
                case 12:
                    {
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = true;
                        lbl6.Visible = true;
                        lbl7.Visible = true;
                        lbl8.Visible = true;
                        lbl9.Visible = true;
                        lbl10.Visible = true;
                        lbl11.Visible = true;
                        lbl12.Visible = true;
                        lbl13.Visible = false;
                        lbl14.Visible = false;
                        lbl15.Visible = false;
                        lbl16.Visible = false;
                        lbl17.Visible = false;
                        lbl18.Visible = false;
                        lbl19.Visible = false;
                        lbl20.Visible = false;
                        break;
                    }
                case 13:
                    {
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = true;
                        lbl6.Visible = true;
                        lbl7.Visible = true;
                        lbl8.Visible = true;
                        lbl9.Visible = true;
                        lbl10.Visible = true;
                        lbl11.Visible = true;
                        lbl12.Visible = true;
                        lbl13.Visible = true;
                        lbl14.Visible = false;
                        lbl15.Visible = false;
                        lbl16.Visible = false;
                        lbl17.Visible = false;
                        lbl18.Visible = false;
                        lbl19.Visible = false;
                        lbl20.Visible = false;
                        break;
                    }
                case 14:
                    {
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = true;
                        lbl6.Visible = true;
                        lbl7.Visible = true;
                        lbl8.Visible = true;
                        lbl9.Visible = true;
                        lbl10.Visible = true;
                        lbl11.Visible = true;
                        lbl12.Visible = true;
                        lbl13.Visible = true;
                        lbl14.Visible = true;
                        lbl15.Visible = false;
                        lbl16.Visible = false;
                        lbl17.Visible = false;
                        lbl18.Visible = false;
                        lbl19.Visible = false;
                        lbl20.Visible = false;
                        break;
                    }
                case 15:
                    {
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = true;
                        lbl6.Visible = true;
                        lbl7.Visible = true;
                        lbl8.Visible = true;
                        lbl9.Visible = true;
                        lbl10.Visible = true;
                        lbl11.Visible = true;
                        lbl12.Visible = true;
                        lbl13.Visible = true;
                        lbl14.Visible = true;
                        lbl15.Visible = true;
                        lbl16.Visible = false;
                        lbl17.Visible = false;
                        lbl18.Visible = false;
                        lbl19.Visible = false;
                        lbl20.Visible = false;
                        break;
                    }
                case 16:
                    {
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = true;
                        lbl6.Visible = true;
                        lbl7.Visible = true;
                        lbl8.Visible = true;
                        lbl9.Visible = true;
                        lbl10.Visible = true;
                        lbl11.Visible = true;
                        lbl12.Visible = true;
                        lbl13.Visible = true;
                        lbl14.Visible = true;
                        lbl15.Visible = true;
                        lbl16.Visible = true;
                        lbl17.Visible = false;
                        lbl18.Visible = false;
                        lbl19.Visible = false;
                        lbl20.Visible = false;
                        break;
                    }
                case 17:
                    {
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = true;
                        lbl6.Visible = true;
                        lbl7.Visible = true;
                        lbl8.Visible = true;
                        lbl9.Visible = true;
                        lbl10.Visible = true;
                        lbl11.Visible = true;
                        lbl12.Visible = true;
                        lbl13.Visible = true;
                        lbl14.Visible = true;
                        lbl15.Visible = true;
                        lbl16.Visible = true;
                        lbl17.Visible = true;
                        lbl18.Visible = false;
                        lbl19.Visible = false;
                        lbl20.Visible = false;
                        break;
                    }
                case 18:
                    {
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = true;
                        lbl6.Visible = true;
                        lbl7.Visible = true;
                        lbl8.Visible = true;
                        lbl9.Visible = true;
                        lbl10.Visible = true;
                        lbl11.Visible = true;
                        lbl12.Visible = true;
                        lbl13.Visible = true;
                        lbl14.Visible = true;
                        lbl15.Visible = true;
                        lbl16.Visible = true;
                        lbl17.Visible = true;
                        lbl18.Visible = true;
                        lbl19.Visible = false;
                        lbl20.Visible = false;
                        break;
                    }
                case 19:
                    {
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = true;
                        lbl6.Visible = true;
                        lbl7.Visible = true;
                        lbl8.Visible = true;
                        lbl9.Visible = true;
                        lbl10.Visible = true;
                        lbl11.Visible = true;
                        lbl12.Visible = true;
                        lbl13.Visible = true;
                        lbl14.Visible = true;
                        lbl15.Visible = true;
                        lbl16.Visible = true;
                        lbl17.Visible = true;
                        lbl18.Visible = true;
                        lbl19.Visible = true;
                        lbl20.Visible = false;
                        break;
                    }
                case 20:
                    {
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = true;
                        lbl6.Visible = true;
                        lbl7.Visible = true;
                        lbl8.Visible = true;
                        lbl9.Visible = true;
                        lbl10.Visible = true;
                        lbl11.Visible = true;
                        lbl12.Visible = true;
                        lbl13.Visible = true;
                        lbl14.Visible = true;
                        lbl15.Visible = true;
                        lbl16.Visible = true;
                        lbl17.Visible = true;
                        lbl18.Visible = true;
                        lbl19.Visible = true;
                        lbl20.Visible = true;
                        break;
                    }
            }
            for (int x = 1; x <= Len(resposta); x++)
            {
                if (Mid(resposta, x, 1) == " ")
                {
                    for (int y = 0; y < this.Controls.Count - 1; y++)
                    {
                        if (this.Controls[y] is Label)
                        {
                            if (Convert.ToInt32(this.Controls[y].Tag) == x)
                            {
                                this.Controls[y].Text = "-";
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            BD.ConectaBD();
            picForca.Image = Image.FromFile(Application.StartupPath + "\\Forca.PNG");

            LimpaResposta();
            Botao();
            NovoJogo();
        }

        private void frmJogo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void perguntasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro Cad = new frmCadastro();
            Cad.ShowDialog();
        }

        private void novoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpaResposta();
            Botao();
            NovoJogo();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnA.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnA.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnB.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnB.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnC.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnC.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnD.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnD.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnE.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnE.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnF.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnF.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnG.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnG.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnH.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnH.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnI.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnI.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnJ.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnJ.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnK.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnK.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnL.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnL.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnM.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnM.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnN.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnN.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnO.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnO.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnP.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnP.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnQ.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnQ.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnR.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnR.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnS.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnS.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnT.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnT.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnU.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnU.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnV.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnV.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnW.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnW.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnX.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnX.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnY.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnY.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            if (!VerificaJogada(btnZ.Text))
                erros++;
            else
                lblPontos.Text = "" + (Convert.ToInt32(lblPontos.Text) + (acerto * 10));

            btnZ.Enabled = false;
            MontaForca();

            if (VerificaGanhador())
            {
                MessageBox.Show("Parabéns você acertou!", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaResposta();
                Botao();
                NovoJogo();
            }
        }
    }
}