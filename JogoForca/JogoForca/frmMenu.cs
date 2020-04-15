using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Media;

namespace JogoForca
{
    public partial class frmMenu : Form
    {
        // Variáveis de uso no Form
        PrivateFontCollection pfc = new PrivateFontCollection();
        private int selecao = 1;
        private bool flag = true;
        private static int _TamMax = 38;
        private static int _TamMin = 24;
        private float x = _TamMax; // Inicia com o tamanho da fonte do valor máximo

        private void MontaLabel(Label lbl)
        {
            // Utiliza a fonte JingJing no caminho do aplicativo
            pfc.AddFontFile(Application.StartupPath + @"\JingJing.ttf");
            lbl.ForeColor = Color.DarkRed;
            lbl.Font = new Font(pfc.Families[0], x);

            /* Após iniciar a variável x com o valor _TamMAX e Flag igual verdadeiro,
             * quando for verdadeiro o valor x recebe o tamanho da fonte menos 1 e
             * quando atingir o valor da _TamMin a variável flag fica falso e valor
             * do x recebe valor da fonte mais 1
             */
            if (flag)
            {
                x = lbl.Font.Size - 1;
                if (lbl.Font.Size == _TamMin)
                    flag = false;
            }
            else if (flag == false)
            {
                x = lbl.Font.Size + 1;
                if (lbl.Font.Size == _TamMax)
                    flag = true;
            }
        }
        
        public frmMenu()
        {
            InitializeComponent();
        }

        private void lblSair_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            /* A variável seleção recebe valor após apertar seta para cima
             * e seta para baixo, os labels é montado conforme iteração com
             * usuário montando em tempo real. */
            if (selecao == 1)
            {
                MontaLabel(lblJogar);
                lblCreditos.ForeColor = Color.Black;
                lblCreditos.Font = new Font(lblCreditos.Font.FontFamily, _TamMax);
                lblPerguntas.ForeColor = Color.Black;
                lblPerguntas.Font = new Font(lblPerguntas.Font.FontFamily, _TamMax);
                lblAjuda.ForeColor = Color.Black;
                lblAjuda.Font = new Font(lblAjuda.Font.FontFamily, _TamMax);
                lblSair.ForeColor = Color.Black;
                lblSair.Font = new Font(lblSair.Font.FontFamily, _TamMax);   
            }
            else if (selecao == 2)
            {
                MontaLabel(lblPerguntas);
                lblJogar.ForeColor = Color.Black;
                lblJogar.Font = new Font(lblJogar.Font.FontFamily, _TamMax);
                lblCreditos.ForeColor = Color.Black;
                lblCreditos.Font = new Font(lblCreditos.Font.FontFamily, _TamMax);
                lblAjuda.ForeColor = Color.Black;
                lblAjuda.Font = new Font(lblAjuda.Font.FontFamily, _TamMax);
                lblSair.ForeColor = Color.Black;
                lblSair.Font = new Font(lblSair.Font.FontFamily, _TamMax);
            }
            else if (selecao == 3)
            {
                MontaLabel(lblCreditos);
                lblJogar.ForeColor = Color.Black;
                lblJogar.Font = new Font(lblJogar.Font.FontFamily, _TamMax);
                lblPerguntas.ForeColor = Color.Black;
                lblPerguntas.Font = new Font(lblPerguntas.Font.FontFamily, _TamMax);
                lblAjuda.ForeColor = Color.Black;
                lblAjuda.Font = new Font(lblAjuda.Font.FontFamily, _TamMax);
                lblSair.ForeColor = Color.Black;
                lblSair.Font = new Font(lblSair.Font.FontFamily, _TamMax);
            }
            else if (selecao == 4)
            {
                MontaLabel(lblAjuda);
                lblCreditos.ForeColor = Color.Black;
                lblCreditos.Font = new Font(lblCreditos.Font.FontFamily, _TamMax);
                lblPerguntas.ForeColor = Color.Black;
                lblPerguntas.Font = new Font(lblPerguntas.Font.FontFamily, _TamMax);
                lblJogar.ForeColor = Color.Black;
                lblJogar.Font = new Font(lblJogar.Font.FontFamily, _TamMax);
                lblSair.ForeColor = Color.Black;
                lblSair.Font = new Font(lblSair.Font.FontFamily, _TamMax);

            }
            else if (selecao == 5)
            {
                MontaLabel(lblSair);
                lblJogar.ForeColor = Color.Black;
                lblJogar.Font = new Font(lblJogar.Font.FontFamily, _TamMax);
                lblCreditos.ForeColor = Color.Black;
                lblCreditos.Font = new Font(lblCreditos.Font.FontFamily, _TamMax);
                lblAjuda.ForeColor = Color.Black;
                lblAjuda.Font = new Font(lblAjuda.Font.FontFamily, _TamMax);
                lblPerguntas.ForeColor = Color.Black;
                lblPerguntas.Font = new Font(lblPerguntas.Font.FontFamily, _TamMax);
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            // Muda a font do label1
            pfc.AddFontFile(Application.StartupPath + @"\JingJing.ttf");
            label1.Font = new Font(pfc.Families[0], 36.0f);

            // Organizar no centro da tela os Labels
            lblJogar.Left  = (this.Width - lblJogar.Width) / 2;
            lblCreditos.Left = (this.Width - lblCreditos.Width) / 2;
            lblPerguntas.Left = (this.Width - lblPerguntas.Width) / 2;
            lblSair.Left = (this.Width - lblSair.Width) / 2;
            lblAjuda.Left = (this.Width - lblAjuda.Width) / 2;

            // Carrega a imagem do Logo
            picLogo.Image = Image.FromFile(Application.StartupPath + @"\ForcaF.PNG");
        }

        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            /* Se apertar seta para baixo acrescenta mais 1 na
             * variável seleção, se apertar seta para baixo
             * a variável seleção recebe menos 1 */
            SoundPlayer snd = new SoundPlayer(Application.StartupPath + "\\Menu.wav");
            flag = false;
            if (e.KeyCode  == Keys.Down)
            {
                snd.Play();
                selecao++;
                if (selecao == 6)
                    selecao = 1;
            }
            else if (e.KeyCode == Keys.Up )
            {
                snd.Play();
                selecao--;
                if (selecao == 0)
                    selecao = 5;
            }

            /* Verifica qual menu está a variável seleção
             * a após apertar a tecla ENTER acina cada menu */

            if (e.KeyCode == Keys.Return)
            {
                if (selecao == 1)
                {
                    frmJogo fJogo = new frmJogo();
                    fJogo.ShowDialog();
                }
                else if (selecao == 2)
                {
                    frmCadastro fCad = new frmCadastro();
                    fCad.ShowDialog();
                }
                else if (selecao == 3)
                {
                    pCredito.Visible = true;
                }
                else if (selecao == 4)
                {
                    pInstrucao.Visible = true;
                }
                else if (selecao == 5)
                {
                    this.Close();
                }
            }

        }

        private void lblFecharCredito_Click(object sender, EventArgs e)
        {
            pCredito.Visible = false;
        }

        private void lblFecharInstrucao_Click(object sender, EventArgs e)
        {
            pInstrucao.Visible = false;
        }
    }
}
