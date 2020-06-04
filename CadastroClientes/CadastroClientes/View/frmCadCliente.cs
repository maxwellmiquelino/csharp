using CadastroClientes.Api;
using CadastroClientes.Controller;
using CadastroClientes.Model;
using CadastroClientes.View;
using System;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class frmCadCliente : Form
    {
        private bool modo;

        public frmCadCliente()
        {
            InitializeComponent();

            LimparCampos();
            LiberarBotoes(true, false, true, true);
            LiberarCampos(true, false, false, false, false, false, false, false, false, false, false, false, false, false);
        }

        private void LiberarBotoes(bool novo, bool gravar, bool pesquisar, bool limpar)
        {
            btnNovo.Enabled = novo;
            btnGravar.Enabled = gravar;
            btnPesquisar.Enabled = pesquisar;
            btnLimpar.Enabled = limpar;
        }

        private void LimparCampos()
        {
            txtSeqpessoa.Text = string.Empty;
            txtCpfCnpj.Text = string.Empty;
            txtRgIe.Text = string.Empty;
            txtNomeRazao.Text = string.Empty;
            txtFantasia.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtUf.Text = string.Empty;
            cboTipoCliente.SelectedIndex = -1;
            cboTipoCliente.Text = string.Empty;
            chkAtivo.Checked = false;
            modo = true;
        }

        private void LiberarCampos(bool seqpessoa, bool cpfcnpj, bool rgie, bool nomerazao, bool fantasia, bool cep, bool endereco,
            bool numero, bool complemento, bool bairro, bool cidade, bool uf, bool tipocliente, bool ativo)
        {
            txtSeqpessoa.Enabled = seqpessoa;
            txtCpfCnpj.Enabled = cpfcnpj;
            txtRgIe.Enabled = rgie;
            txtNomeRazao.Enabled = nomerazao;
            txtFantasia.Enabled = fantasia;
            txtCep.Enabled = cep;
            txtEndereco.Enabled = endereco;
            txtNumero.Enabled = numero;
            txtComplemento.Enabled = complemento;
            txtBairro.Enabled = bairro;
            txtCidade.Enabled = cidade;
            txtUf.Enabled = uf;
            cboTipoCliente.Enabled = tipocliente;
            chkAtivo.Enabled = ativo;
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            if (!BancoDados.existeArquivoBD())
            {
                BancoDados.criarBancoDados();
                BancoDados.criarEstruturaBD();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            LiberarBotoes(true, false, true, true);
            LiberarCampos(true, false, false, false, false, false, false, false, false, false, false, false, false, false);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            LiberarBotoes(false, true, false, true);
            LiberarCampos(false, true, true, true, true, true, true, true, true, true, true, true, true, true);

            txtSeqpessoa.Text = PessoaController.getSeqpessoa().ToString();
            txtCpfCnpj.Focus();
            chkAtivo.Checked = true;
            modo = true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Seqpessoa = int.Parse(txtSeqpessoa.Text);
                pessoa.Cpfcnpj = txtCpfCnpj.Text;
                pessoa.Ierg = txtRgIe.Text;
                pessoa.Razaonome = txtNomeRazao.Text;
                pessoa.Fantasia = txtFantasia.Text;
                pessoa.Cep = txtCep.Text;
                pessoa.Endereco = txtEndereco.Text;
                pessoa.Numero = txtNumero.Text;
                pessoa.Complemento = txtComplemento.Text;
                pessoa.Bairro = txtBairro.Text;
                pessoa.Cidade = txtCidade.Text;
                pessoa.Uf = txtUf.Text;
                pessoa.Tipo = cboTipoCliente.SelectedIndex;
                pessoa.Ativo = chkAtivo.Checked == true ? 1 : 0;

                if (modo)
                {
                    if(PessoaController.inserirPessoa(pessoa))
                        MessageBox.Show("Pessoa cadastrada com sucesso !!!",
                            "Cadastro de Cliehte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (PessoaController.atualizarPessoa(pessoa))
                        MessageBox.Show("Pessoa atualizada com sucesso !!!",
                            "Cadastro de Cliehte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimparCampos();
                LiberarBotoes(true, false, true, true);
                LiberarCampos(true, false, false, false, false, false, false, false, false, false, false, false, false, false);
            }
            else
                MessageBox.Show("Há campos em branco, favor verificar campos na cor de fundo amarelo !!!", 
                    "Cadastro de Cliehte", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidarFormulario()
        {
            bool flag = true;

            if (txtNomeRazao.Text.Length == 0)
                flag = false;
            if (cboTipoCliente.Text.Length == 0)
                flag = false;

            return flag;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtSeqpessoa.Text.Length > 0)
                pesquisarPessoa(txtSeqpessoa.Text);
            else
            {
                frmPesquisa frm = new frmPesquisa();
                frm.ShowDialog(this);
            }
        }

        private void pesquisarPessoa(string seqpessoa)
        {
            foreach(var p in PessoaController.listarPessoaBySeqpessoa(seqpessoa))
            {
                txtSeqpessoa.Text = p.Seqpessoa.ToString();
                txtCpfCnpj.Text = p.Cpfcnpj;
                txtRgIe.Text = p.Ierg;
                txtNomeRazao.Text = p.Razaonome;
                txtFantasia.Text = p.Fantasia;
                txtCep.Text = p.Cep;
                txtEndereco.Text = p.Endereco;
                txtNumero.Text = p.Numero;
                txtComplemento.Text = p.Complemento;
                txtBairro.Text = p.Bairro;
                txtCidade.Text = p.Cidade;
                txtUf.Text = p.Uf;
                cboTipoCliente.SelectedIndex = p.Tipo;
                chkAtivo.Checked = p.Ativo == 1 ? true : false;

                LiberarBotoes(false, true, false, true);
                LiberarCampos(false, true, true, true, true, true, true, true, true, true, true, true, true, true);
                modo = false;
            }
        }
    }
}
