using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace JogoForca
{
    public partial class frmCadastro : Form
    {
        private OleDbCommand conn = new OleDbCommand();
        private String modo = "";
        private String sql = "";

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void LiberaCampos(bool tCodigo, bool tPergunta, bool tResposta)
        {
            txtCodigo.Enabled = tCodigo;
            txtPergunta.Enabled = tPergunta;
            txtResposta.Enabled = tResposta;
        }

        private void LimpaCampos()
        {
            txtCodigo.Text = "";
            txtPergunta.Text = "";
            txtResposta.Text = "";
            modo = "";
        }

        private void LiberaBotao(bool bIncluir, bool bAlterar, bool bGravar, bool bLimpar)
        {
            btnIncluir.Enabled = bIncluir;
            btnAlterar.Enabled = bAlterar;
            btnGravar.Enabled = bGravar;
            btnLimpar.Enabled = bLimpar;
        }

        private void CarregaGrid()
        {           
            try
            {
                dgdPerguntas.DataSource = null;
                dgdPerguntas.Refresh();
                dgdPerguntas.DataSource = BD.Pesquisa("SELECT ID,PERGUNTA,RESPOSTA FROM PERGUNTA ORDER BY ID");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            txtPergunta.CharacterCasing = CharacterCasing.Upper;
            txtResposta.CharacterCasing = CharacterCasing.Upper;
            CarregaGrid();
            LimpaCampos();
            LiberaCampos(false, false, false);
            LiberaBotao(true, true, false, false);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            modo = "I";
            LiberaCampos(false, true, true);
            LiberaBotao(false, false, true, true);

            try
            {
                OleDbDataReader dr;
                conn.CommandText = "SELECT TOP 1 ID FROM PERGUNTA ORDER BY ID DESC";
                conn.Connection = BD.ConectaBD();
                dr = conn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                        txtCodigo.Text = (Convert.ToInt32(dr[0].ToString()) + 1).ToString();
                }
                dr.Close();
                dr.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            LiberaBotao(true, true, false, false);
            LiberaCampos(false, false, false);
            txtPergunta.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals (""))
            {
                MessageBox.Show("Selecione uma pergunta para alterar.", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            modo = "A";
            LiberaCampos(false, true, true);
            LiberaBotao(false, false, true, true);
            txtPergunta.Focus();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            // Valida se o TextBox Pergunta está em branco.
            if (txtPergunta.Text.Equals(""))
            {
                MessageBox.Show("Inclua a pergunta.", "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Inclusão dos dados
            if (modo == "I")
            {
                sql = "INSERT INTO PERGUNTA(PERGUNTA,RESPOSTA) VALUES(@pergunta,@resposta)";
            }
            // Alteração dos dados
            else if (modo == "A")
            {
                sql = "UPDATE PERGUNTA SET PERGUNTA = @pergunta, RESPOSTA = @resposta where ID = @codigo";
            }

            try
            {
                conn.CommandText = sql;
                conn.Parameters.AddWithValue("@pergunta", txtPergunta.Text);
                conn.Parameters.AddWithValue("@resposta", txtResposta.Text);
                conn.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                conn.Connection = BD.ConectaBD();
                conn.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Jogo da Forca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                btnLimpar.PerformClick();
                CarregaGrid();
            }
        }

        private void dgdPerguntas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgdPerguntas.CurrentRow.Cells[0].Value.ToString();
            txtPergunta.Text = dgdPerguntas.CurrentRow.Cells[1].Value.ToString();
            txtResposta.Text = dgdPerguntas.CurrentRow.Cells[2].Value.ToString();
        }
    }
}