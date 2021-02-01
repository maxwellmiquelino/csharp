using Estacionamento.AppUtil;
using Estacionamento.Controller;
using Estacionamento.Model;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Estacionamento.View
{
    public partial class frmParametros : Form
    {


        public frmParametros()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

            LimparCampos();
            carregarComboBoxGrupo();
        }

        private void LimparCampos()
        {
            cboGrupoParam.Items.Clear();
            cboGrupo.Text = string.Empty;
            cboGrupoParam.Text = string.Empty;
            txtValor.Text = string.Empty;
        }

        private void carregarComboBoxGrupo()
        {
            //Percorrer as linhas do datatable para adicionar na lista 
            foreach (DataRow dataRow in ParametroController.listarGrupo().Rows)
            {
                //Adiciona na lista Especificando a clouna 
                cboGrupo.Items.Add(dataRow["grupo"].ToString());
            }
        }

        private void carregarComboBoxGrupoParametro(string grupo)
        {
            cboGrupoParam.Items.Clear();

            //Percorrer as linhas do datatable para adicionar na lista 
            foreach (DataRow dataRow in ParametroController.listarGrupoParametro(grupo).Rows)
            {
                //Adiciona na lista Especificando a clouna 
                cboGrupoParam.Items.Add(dataRow["parametro"].ToString());
            }
        }

        private void carregarComboBoxGrupoParametroValor(string grupo, string parametro)
        {
            //Percorrer as linhas do datatable para adicionar na lista 
            foreach (DataRow dataRow in ParametroController.listarGrupoParametroValor(grupo, parametro).Rows)
            {
                //Adiciona na lista Especificando a clouna 
                txtValor.Text = dataRow["valor"].ToString();
            }
        }

        private void frmParametros_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = Text;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarComboBoxGrupoParametro(cboGrupo.Text);
        }

        private void cboGrupoParam_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarComboBoxGrupoParametroValor(cboGrupo.Text, cboGrupoParam.Text);

            if (cboGrupo.Text == "BancoDados")
                txtValor.Enabled = false;
            else
                txtValor.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Parametro parametro = new Parametro();
                parametro.Grupo = cboGrupo.Text;
                parametro.Param = cboGrupoParam.Text;
                parametro.Valor = txtValor.Text;

                if (ParametroController.update(parametro))
                {
                    Mensagem.Mostrar("Sucesso !!!", "Dados atualizado com sucesso !!!");
                    LimparCampos();
                }
                else
                {
                    Mensagem.Mostrar("Erro !!!", "Favor verificar o log da aplicação !!!", "CONFIRMAR", 1);
                }
            }
            else
            {
                Mensagem.Mostrar("Erro na validação", "Favor verificar os dados do cadastro!!!", "CONFIRMAR", 1);
            }
        }

        private bool ValidarFormulario()
        {
            bool retorno = true;

            if (cboGrupo.Text.Length == 0)
                retorno = false;

            if (cboGrupoParam.Text.Length == 0)
                retorno = false;

            if (txtValor.Text.Length == 0)
                retorno = false;

            return retorno;
        }

        private void frmParametros_Resize(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }
    }
}
