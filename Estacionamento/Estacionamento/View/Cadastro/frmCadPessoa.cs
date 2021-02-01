using Estacionamento.AppUtil;
using Estacionamento.Controller;
using Estacionamento.Model;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Estacionamento.View
{
    public partial class frmCadPessoa : Form
    {
        private bool modo;

        public frmCadPessoa()
        {
            InitializeComponent();

            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

            LimparCamposPessoa();
            LiberarCamposPessoa(true, false, false, false, false, false, false, false, false, false, false, false, false, false);
            LiberarBotoesPessoa(true, false, true, true);

            LimparCamposTelefone();
            LiberarBotoesTelefone(false, false);
            LiberarCamposTelefone(false, false);
        }

        private void PesquisarPessoa(string seqpessoa)
        {
            modo = false;

            foreach (var pessoas in PessoaController.listarPessoaBySeqpessoa(seqpessoa))
            {
                txtSeqpessoa.Text = pessoas.Seqpessoa.ToString();
                txtIeRg.Text = pessoas.Ierg;
                txtCnpjCpf.Text = pessoas.Cnpjcpf;
                txtIeRg.Text = pessoas.Ierg;
                txtRazaoNome.Text = pessoas.Razaonome;
                txtCep.Text = pessoas.Cep;
                txtEndereco.Text = pessoas.Endereco;
                txtNumero.Text = pessoas.Numero;
                txtComplemento.Text = pessoas.Complemento;
                txtBairro.Text = pessoas.Bairro;
                txtCidade.Text = pessoas.Cidade;
                txtUf.Text = pessoas.Uf;
                cboTipo.SelectedIndex = pessoas.Tipo;
                chkAtivo.Checked = pessoas.Ativo;
            }
            LimparCamposTelefone();
            LiberarBotoesTelefone(true, true);
            LiberarCamposTelefone(true, true);

            LiberarBotoesPessoa(false, true, false, true);
            LiberarCamposPessoa(false, true, true, true, true, true, true, true, true, true, true, true, true, true);
            txtRazaoNome.Focus();

        }
        private void LimparCamposPessoa()
        {
            txtSeqpessoa.Text = string.Empty;
            txtCnpjCpf.Text = string.Empty;
            txtIeRg.Text = string.Empty;
            txtRazaoNome.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtUf.Text = string.Empty;
            cboTipo.Text = string.Empty;
            chkAtivo.Checked = false;
            Properties.Settings.Default.sequencia = string.Empty;
            Properties.Settings.Default.Save();
            modo = false;
        }

        private void LiberarCamposPessoa(bool seqpessoa, bool cnpjcpf, bool ierg, bool razaonome, bool fantasia,
            bool cep, bool endereco, bool numero, bool complemento, bool bairro, bool cidade,
            bool uf, bool tipo, bool ativo)
        {
            txtSeqpessoa.Enabled = seqpessoa;
            txtCnpjCpf.Enabled = cnpjcpf;
            txtIeRg.Enabled = ierg;
            txtRazaoNome.Enabled = razaonome;
            txtFantasia.Enabled = fantasia;
            txtCep.Enabled = cep;
            txtEndereco.Enabled = endereco;
            txtNumero.Enabled = numero;
            txtComplemento.Enabled = complemento;
            txtBairro.Enabled = bairro;
            txtCidade.Enabled = cidade;
            txtUf.Enabled = uf;
            cboTipo.Enabled = tipo;
            chkAtivo.Enabled = ativo;
        }

        private void LiberarBotoesPessoa(bool novo, bool gravar, bool pesquisar, bool limpar)
        {
            btnNovo.Enabled = novo;
            btnGravar.Enabled = gravar;
            btnPesquisar.Enabled = pesquisar;
            btnLimpar.Enabled = limpar;
        }

        private void LimparCamposTelefone()
        {
            txtTelefone.Text = string.Empty;
            txtContato.Text = string.Empty;
            dgvTelefone.DataSource = null;
        }

        private void LiberarCamposTelefone(bool telefone, bool contato)
        {
            txtTelefone.Enabled = telefone;
            txtContato.Enabled = contato;
        }

        private void LiberarBotoesTelefone(bool addtel, bool deltel)
        {
            btnAddTel.Enabled = addtel;
            btnDelTel.Enabled = deltel;
        }

        private void frmCadPessoa_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = Text;
            txtSeqpessoa.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCamposPessoa();
            LiberarCamposPessoa(false, true, true, true, true, true, true, true, true, true, true, true, true, true);
            LiberarBotoesPessoa(false, true, false, true);

            LimparCamposTelefone();
            LiberarBotoesTelefone(true, true);
            LiberarCamposTelefone(true, true);

            txtCnpjCpf.Focus();
            txtSeqpessoa.Text = PessoaController.GetSeqPessoa().ToString();
            chkAtivo.Checked = true;
            modo = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposPessoa();
            LiberarCamposPessoa(true, false, false, false, false, false, false, false, false, false, false, false, false, false);
            LiberarBotoesPessoa(true, false, true, true);

            LimparCamposTelefone();
            LiberarBotoesTelefone(false, false);
            LiberarCamposTelefone(false, false);

            tbcPessoa.SelectTab(0);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ValidarFormularioPessoa())
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Seqpessoa = int.Parse(txtSeqpessoa.Text);
                pessoa.Cnpjcpf = txtCnpjCpf.Text;
                pessoa.Ierg = txtIeRg.Text;
                pessoa.Razaonome = txtRazaoNome.Text;
                pessoa.Fantasia = txtFantasia.Text;
                pessoa.Cep = txtCep.Text;
                pessoa.Endereco = txtEndereco.Text;
                pessoa.Numero = txtNumero.Text;
                pessoa.Complemento = txtComplemento.Text;
                pessoa.Bairro = txtBairro.Text;
                pessoa.Cidade = txtComplemento.Text;
                pessoa.Uf = txtUf.Text;
                pessoa.Tipo = cboTipo.SelectedIndex;
                pessoa.Ativo = chkAtivo.Checked;
                pessoa.Ultnome = Properties.Settings.Default.ultnome;

                if (modo)
                {
                    if (PessoaController.insert(pessoa))
                    {
                        Mensagem.Mostrar("Sucesso !!!", "Dados inserido com sucesso, agora pode inserir o telefone na aba 'TELEFONE' !!!");
                        LimparCamposTelefone();
                        LiberarBotoesTelefone(true, true);
                        LiberarCamposTelefone(true, true);
                    }
                    else
                        Mensagem.Mostrar("Erro", "Erro ao inserir os dados, favor verificar log. !!!", "CONFIRMAR", 1);
                }
                else
                {
                    if (PessoaController.update(pessoa))
                        Mensagem.Mostrar("Sucesso !!!", "Dados atualizados com sucesso !!!");
                    else
                        Mensagem.Mostrar("Erro", "Erro ao inserir os dados, favor verificar log. !!!", "CONFIRMAR", 1);

                    LimparCamposPessoa();
                    LiberarCamposPessoa(true, false, false, false, false, false, false, false, false, false, false, false, false, false);
                    LiberarBotoesPessoa(true, false, true, true);
                }

            }
            else
            {
                Mensagem.Mostrar("Erro na validação", "Favor verificar os dados do cadastro!!!", "CONFIRMAR", 1);
            }
        }

        private bool ValidarFormularioPessoa()
        {
            bool retorno = true;

            if (txtRazaoNome.Text.Length == 0)
                retorno = false;

            if (cboTipo.Text.Length == 0)
                retorno = false;

            return retorno;
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            if (txtCep.Text.Length >= 8)
            {
                txtEndereco.Text = Funcao.TratarChar(EnderecoController.BuscarEnderecoViaCEP(txtCep.Text).logradouro);
                txtBairro.Text = Funcao.TratarChar(EnderecoController.BuscarEnderecoViaCEP(txtCep.Text).bairro);
                txtCidade.Text = Funcao.TratarChar(EnderecoController.BuscarEnderecoViaCEP(txtCep.Text).localidade);
                txtUf.Text = Funcao.TratarChar(EnderecoController.BuscarEnderecoViaCEP(txtCep.Text).uf);
                txtNumero.Focus();
            }
            else if (txtCep.Text.Length == 0)
            {
                txtEndereco.Text = string.Empty;
                txtBairro.Text = string.Empty;
                txtCidade.Text = string.Empty;
                txtUf.Text = string.Empty;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtSeqpessoa.Text.Length > 0)
            {
                PesquisarPessoa(txtSeqpessoa.Text);
                dgvTelefone.DataSource = TelefoneController.listarTelefoneBySeqpessoa(txtSeqpessoa.Text);
            }


            else
            {
                Pesquisar.MostrarPessoa();
                txtSeqpessoa.Text = Properties.Settings.Default.sequencia;
            }
        }

        private void txtCnpjCpf_TextChanged(object sender, EventArgs e)
        {
            cboTipo.SelectedIndex = (txtCnpjCpf.Text.Length == 14 ? 1 : 0);
        }

        private void txtSeqpessoa_TextChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.sequencia.Length > 0 && modo == false)
            {
                PesquisarPessoa(txtSeqpessoa.Text);
                dgvTelefone.DataSource = TelefoneController.listarTelefoneBySeqpessoa(txtSeqpessoa.Text);
            }
        }

        private void txtSeqpessoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Deixa digitar somente numero e usar BACKSPACE
            // *********************************************
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void frmCadPessoa_Resize(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void btnAddTel_Click(object sender, EventArgs e)
        {
            if (ValidarFormularioTelefone())
            {
                Telefone telefone = new Telefone();
                telefone.Seqpessoa = int.Parse(txtSeqpessoa.Text);
                telefone.Contato = txtContato.Text;
                telefone.Tel = txtTelefone.Text;
                if (TelefoneController.insert(telefone))
                {
                    LimparCamposTelefone();
                    LiberarBotoesTelefone(true, true);
                    LiberarCamposTelefone(true, true);
                    dgvTelefone.DataSource = TelefoneController.listarTelefoneBySeqpessoa(txtSeqpessoa.Text);

                }
            }
            else
                Mensagem.Mostrar("Erro na validação", "Favor verificar os dados do cadastro do telefone !!!", "CONFIRMAR", 1);
        }

        private bool ValidarFormularioTelefone()
        {
            bool retorno = true;

            if (txtSeqpessoa.Text.Length == 0)
                retorno = false;

            if (txtTelefone.Text.Length == 0)
                retorno = false;

            return retorno;
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Deixa digitar somente numero e usar BACKSPACE
            // *********************************************
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnDelTel_Click(object sender, EventArgs e)
        {
            if (dgvTelefone.CurrentRow.Selected)
            {
                if (TelefoneController.delete(
                    dgvTelefone.CurrentRow.Cells["seqpessoa"].Value.ToString(),
                    dgvTelefone.CurrentRow.Cells["telefone"].Value.ToString()))
                    dgvTelefone.DataSource = TelefoneController.listarTelefoneBySeqpessoa(txtSeqpessoa.Text);
                else
                    Mensagem.Mostrar("Erro", "Erro ao excluir o telefone, favor verificar log !!!", "CONFIRMAR", 1);
            }
        }

        private void txtCnpjCpf_Validated(object sender, EventArgs e)
        {
            if (txtCnpjCpf.Text.Length == 14 && 
                BancoDados.RetornarParametro("Sistema", "ValidarCNPJ") == "S" &&
                !Funcao.IsCnpj(txtCnpjCpf.Text))
            {
                Mensagem.Mostrar("Erro", "Dados do CNPJ Inválido, favor verificar !!!", "CONFIRMAR", 1);
                txtCnpjCpf.Focus();
            }
            else if (txtCnpjCpf.Text.Length == 11 && 
                BancoDados.RetornarParametro("Sistema", "ValidarCPF") == "S" &&
                !Funcao.IsCpf(txtCnpjCpf.Text))
            {
                Mensagem.Mostrar("Erro", "Dados do CPF Inválido, favor verificar !!!", "CONFIRMAR", 1);
                txtCnpjCpf.Focus();
            }
        }
    }
}
