using Estacionamento.AppUtil;
using Estacionamento.Controller;
using Estacionamento.Model;
using GerardorComandas.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Estacionamento.View.Movto
{
    public partial class frmMovimento : Form
    {
        public static bool modo = true;

        public frmMovimento()
        {
            InitializeComponent();

            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

            CarregarFormaPagtoComboBox();
            LimparCampos();
            LiberarBotoes(true, false, true, true);
            LiberarCampos(false, true, false, false, false, false, false, false, false, false, false);
            CarregaLabelVagas();
        }

        private void CarregaLabelVagas()
        {
            lblQtdeVeiculosPatio.Text = "Qtde Veículos no Pátio : " + MovimentoController.listarQtdeVaga().Tables[0].Rows[0].ItemArray[0].ToString();
            lblVagasPatio.Text = "Vagas do Pátio : " + BancoDados.RetornarParametro("Sistema", "QtdeVaga");
        }

        private void CarregarFormaPagtoComboBox()
        {
            cboFormaPagto.DataSource = FormaPagtoController.listarFormaPagtoMovto().Tables[0];
            cboFormaPagto.DisplayMember = "descricao";
            cboFormaPagto.ValueMember = "seqformapagto";
        }

        private void LiberarCampos(bool seqmovto, bool placa, bool seqmodelo, bool dthrentrada, bool dthrsaida, bool seqconvenio,
            bool motorista, bool vlrhora, bool qtdhora, bool vlrdesc, bool vlrtotal)
        {
            txtSeqmovto.Enabled = seqmovto;
            txtPlaca.Enabled = placa;
            txtSeqmodelo.Enabled = seqmodelo;
            txtDtHrEntrada.Enabled = dthrentrada;
            txtDtHrSaida.Enabled = dthrsaida;
            txtSeqconvenio.Enabled = seqconvenio;
            txtMotorista.Enabled = motorista;
            txtVlrHora.Enabled = vlrhora;
            txtQtdeHora.Enabled = qtdhora;
            txtVlrDesc.Enabled = vlrdesc;
            txtVlrTotal.Enabled = vlrtotal;
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
            txtSeqmovto.Text = string.Empty;
            txtPlaca.Text = string.Empty;
            txtDtHrEntrada.Text = string.Empty;
            txtDtHrSaida.Text = string.Empty;
            txtSeqconvenio.Text = string.Empty;
            txtMotorista.Text = string.Empty;
            txtVlrHora.Text = string.Empty;
            txtQtdeHora.Text = string.Empty;
            txtVlrDesc.Text = string.Empty;
            txtVlrTotal.Text = string.Empty;
            txtSaldo.Text = string.Empty;
            txtSeqmodelo.Text = string.Empty;
            txtVeiculo.Text = string.Empty;
            txtRazaoNome.Text = string.Empty;
            txtFormaPagto.Text = string.Empty;
            txtSeqformapagto.Text = string.Empty;
            dgvFormaPagto.Rows.Clear();
            modo = true;
            txtVlrDesc.Text = "0,00";
            txtQtdeHora.Text = "0,00";
            txtVlrTotal.Text = "0,00";
            txtVlrDemaisHora.Text = "0,00";
            txtValor.Text = "0,00";
            txtVlrHora.Text = decimal.Parse(BancoDados.RetornarParametro("Movto", "ValorPrimeiraHora")
                .Replace(".", ",")).ToString("F2");
            txtVlrDemaisHora.Text = decimal.Parse(BancoDados.RetornarParametro("Movto", "ValorDemaisHora")
                .Replace(".", ",")).ToString("F2");
        }

        private void frmMovto_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = Text;
            txtPlaca.Focus();
        }

        private void frmMovto_Resize(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void txtVlrHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Deixa digitar somente numero e usar BACKSPACE
            // *********************************************
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtVlrDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Deixa digitar somente numero e usar BACKSPACE
            // *********************************************
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtQtdeHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Deixa digitar somente numero e usar BACKSPACE
            // *********************************************
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtVlrTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Deixa digitar somente numero e usar BACKSPACE
            // *********************************************
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && txtPlaca.Text.Length > 0)
            {
                PesquisarPlaca(txtPlaca.Text);
            }
            else if (e.KeyChar == (char)Keys.Return && txtPlaca.Text.Length == 0)
            {
                Pesquisar.MostrarMovtoPlaca();
                txtSeqmovto.Text = Properties.Settings.Default.sequencia;
            }
            txtSeqmodelo.Focus();
        }

        private void PesquisarPlaca(string placa)
        {
            if (MovimentoController.listarMovtoByPlaca(placa).Count > 0)
            {
                foreach (var p in MovimentoController.listarMovtoByPlaca(placa))
                {
                    TimeSpan ts = new TimeSpan();
                    txtDtHrSaida.Text = DateTime.Now.ToString();
                    txtSeqmovto.Text = p.Seqmovto.ToString();
                    txtDtHrEntrada.Text = p.Dtahorentrada;
                    txtMotorista.Text = p.Motorista;
                    txtSeqmodelo.Text = p.Seqmodelo.ToString();
                    txtVlrDesc.Text = p.Vlrdesc.ToString("F2");
                    ts = DateTime.Parse(txtDtHrSaida.Text) - DateTime.Parse(txtDtHrEntrada.Text);
                    modo = false;
                    decimal total;
                    total = Funcao.calcularValorHora(Math.Round(decimal.Parse(ts.TotalHours.ToString())),
                        decimal.Parse(txtVlrHora.Text), decimal.Parse(txtVlrDesc.Text), decimal.Parse(txtVlrDemaisHora.Text));
                    //total = qtde == 0 ? hora : (hora * qtde) - desc;
                    //txtVlrTotal.Text = total.ToString("F2");
                    txtQtdeHora.Text = Math.Round(decimal.Parse(ts.TotalHours.ToString())).ToString("F2");
                    txtSaldo.Text = total.ToString("F2");
                }
                LiberarCampos(false, false, true, false, false, true, true, false, false, false, false);
                LiberarBotoes(false, true, false, true);
            }
            else if (MovimentoController.listarMovtoByPlacaNovo(placa).Count > 0)
            {
                foreach (var p in MovimentoController.listarMovtoByPlacaNovo(placa))
                {
                    txtSeqmodelo.Text = p.Seqmodelo.ToString();
                }
                LiberarCampos(false, false, true, false, false, true, true, false, false, false, false);
                LiberarBotoes(false, true, false, true);
            }


            if (modo)
            {
                txtSeqmovto.Text = MovimentoController.GetSeqMovto().ToString();
                txtDtHrEntrada.Text = DateTime.Now.ToString();
                txtVlrDesc.Text = "0,00";
                txtQtdeHora.Text = "0,00";
                txtVlrTotal.Text = "0,00";
                LiberarCampos(false, false, true, false, false, true, true, false, false, false, false);
                LiberarBotoes(false, true, false, true);
            }
            txtSeqmodelo.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSeqmodelo_TextChanged(object sender, EventArgs e)
        {
            if (txtSeqmodelo.Text.Length > 0)
            {
                PesquisarVeiculo(txtSeqmodelo.Text);
            }
            else
                txtVeiculo.Text = "";
        }

        private void PesquisarVeiculo(string seqmodelo)
        {
            foreach (var modelo in ModeloController.listarModeloBySeqmodelo(seqmodelo))
            {
                txtVeiculo.Text = modelo.Descricao;
            }
        }

        private void txtPlaca_Validated(object sender, EventArgs e)
        {
            //if (txtPlaca.Text.Length > 0)
            //    PesquisarPlaca(txtPlaca.Text);
            //else
            //{
            //    Pesquisar.MostrarMovtoPlaca();
            //    txtSeqmovto.Text = Properties.Settings.Default.sequencia;
            //}
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            LiberarBotoes(true, false, true, true);
            LiberarCampos(false, true, false, false, false, false, false, false, false, false, false);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (VerificarVagas())
            {
                Mensagem.Mostrar("Estacionamento", "Quantidade de vagas dispovível excedido !!!", "CONFIRMAR", 1);
                return;
            }

            if (ValidarFormulario())
            {
                Movimento movto = new Movimento();
                movto.Seqmovto = int.Parse(txtSeqmovto.Text);
                movto.Placa = txtPlaca.Text;
                movto.Dtamovimento = DateTime.Parse(txtDtHrEntrada.Text).ToString("yyyy-MM-dd");
                movto.Dtahorentrada = DateTime.Parse(txtDtHrEntrada.Text).ToString("yyyy-MM-dd HH:mm:ss");
                movto.Dtahorsaida = txtDtHrSaida.Text == string.Empty ? "" : DateTime.Parse(txtDtHrSaida.Text).ToString("yyyy-MM-dd HH:mm:ss");
                movto.Seqmodelo = int.Parse(txtSeqmodelo.Text);
                movto.Seqconvenio = txtSeqconvenio.Text == string.Empty ? 0 : int.Parse(txtSeqconvenio.Text);
                movto.Motorista = txtMotorista.Text;
                movto.Vlrhora = decimal.Parse(txtVlrHora.Text);
                movto.QtdeHora = txtQtdeHora.Text == "0,00" ? 0 : decimal.Parse(txtQtdeHora.Text);
                movto.Vlrdesc = decimal.Parse(txtVlrDesc.Text);
                movto.Vlrtotal = decimal.Parse(txtVlrTotal.Text);
                movto.Ultnome = Properties.Settings.Default.ultnome;
                movto.Status = modo == true ? 1 : 0;

                if (modo)
                {
                    if (MovimentoController.insert(movto))
                    {
                        Mensagem.Mostrar("Sucesso !!!", "Dados inserido com sucesso !!!");
                        LimparCampos();
                        LiberarCampos(false, true, false, false, false, false, false, false, false, false, false);
                        LiberarBotoes(false, false, true, true);
                        CarregaLabelVagas();
                    }
                    else
                        Mensagem.Mostrar("Erro", "Favor verificar os dados do cadastro!!!", "CONFIRMAR", 1);

                    // Imprime o Ticket caso o parametro esteja marcado como SIM
                    if (BancoDados.RetornarParametro("Sistema", "ImprimirTicket") == "S")
                    {
                        switch (BancoDados.RetornarParametro("Impressora", "Modelo"))
                        {
                            case "Daruma":
                                Daruma.Imprimir(txtPlaca.Text + " - " + txtVeiculo.Text);
                                break;
                            case "Epson":
                                Funcao.ImprimirTicket(txtPlaca.Text + " - " + txtVeiculo.Text);
                                break;
                        }
                    }
                }
                else
                {
                    if (MovimentoController.update(movto))
                    {

                        Mensagem.Mostrar("Sucesso !!!", "Dados atualizado com sucesso !!!");
                        LimparCampos();
                        LiberarBotoes(true, false, true, true);
                        LiberarCampos(false, true, false, false, false, false, false, false, false, false, false);
                        txtPlaca.Focus();
                    }
                    else
                        Mensagem.Mostrar("Erro", "Favor verificar os dados do cadastro!!!", "CONFIRMAR", 1);
                }
            }
        }

        private bool VerificarVagas()
        {
            int qtdeVagasMovto, qtdeTotalVagas;

            qtdeTotalVagas = int.Parse(BancoDados.RetornarParametro("Sistema", "QtdeVaga"));
            qtdeVagasMovto = int.Parse(MovimentoController.listarQtdeVaga().Tables[0].Rows[0].ItemArray[0].ToString());

            return qtdeVagasMovto >= qtdeTotalVagas;
        }

        private bool ValidarFormulario()
        {
            bool retorno = true;

            if (txtPlaca.Text.Length == 0)
                retorno = false;

            return retorno;
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Deixa digitar somente numero e usar BACKSPACE
            // *********************************************
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Return)
            {
                AddFormaPagto();
            }
        }

        private void AddFormaPagto()
        {
            decimal valor, saldo, total;
            valor = decimal.Parse(txtValor.Text);
            total = decimal.Parse(txtVlrTotal.Text);
            saldo = total - valor;
            txtSaldo.Text = saldo.ToString("F2");

            FormaPagtoMovto formaPagtoMovto = new FormaPagtoMovto();
            formaPagtoMovto.Seqmovto = int.Parse(txtSeqmovto.Text);
            formaPagtoMovto.Seqformapagto = int.Parse(cboFormaPagto.SelectedValue.ToString());
            //formaPagtoMovto.Seqformapagto = int.Parse(txtSeqformapagto.Text);
            formaPagtoMovto.Valorpagto = valor;
            formaPagtoMovto.Ultnome = Properties.Settings.Default.ultnome;

            if (MovimentoController.insertformpagtomovto(formaPagtoMovto))
            {
                dgvFormaPagto.Rows.Add(txtSeqformapagto.Text, txtFormaPagto.Text, valor.ToString("C2"));
                txtValor.Text = string.Empty;
                txtSeqformapagto.Focus();
            }

            if (saldo == 0)
                btnGravar.PerformClick();
        }

        private void txtSeqformapagto_TextChanged(object sender, EventArgs e)
        {
            if (txtSeqformapagto.Text.Length > 0 && !modo)
            {
                foreach (var fp in FormaPagtoController.listarFormaPagtoBySeqformapagto(txtSeqformapagto.Text))
                {
                    txtFormaPagto.Text = fp.Descricao;
                    txtValor.Focus();
                }
            }
            else
            {
                txtFormaPagto.Text = string.Empty;
            }
        }

        private void dgvFormaPagto_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            decimal saldo, total;
            saldo = decimal.Parse(txtSaldo.Text.Replace("R$", "").Replace(" ", ""));
            total = decimal.Parse(txtVlrTotal.Text.Replace("R$", "").Trim());
            saldo = total;
            txtSaldo.Text = saldo.ToString("C2");
            txtValor.Text = string.Empty;
        }

        private void txtSeqmovto_TextChanged(object sender, EventArgs e)
        {
            if (!modo)
            {
                PesquisarMovimento(txtSeqmovto.Text);
            }
        }

        private void PesquisarMovimento(string seqmovto)
        {
            foreach (var movto in MovimentoController.listarMovimento(seqmovto))
            {
                txtPlaca.Text = movto.Placa;
                txtDtHrEntrada.Text = movto.Dtahorentrada;
                txtSeqmodelo.Text = movto.Seqmodelo.ToString();
                txtSeqconvenio.Text = movto.Seqconvenio.ToString();
                txtMotorista.Text = movto.Motorista;
                txtVlrHora.Text = movto.Vlrhora.ToString("F2");
                txtVlrDesc.Text = movto.Vlrdesc.ToString("F2");
                TimeSpan ts = new TimeSpan();
                txtDtHrSaida.Text = DateTime.Now.ToString();
                ts = DateTime.Parse(txtDtHrSaida.Text) - DateTime.Parse(txtDtHrEntrada.Text);
                decimal total;
                total = Funcao.calcularValorHora(Math.Round(decimal.Parse(ts.TotalHours.ToString())),
                    decimal.Parse(txtVlrHora.Text), decimal.Parse(txtVlrDesc.Text), decimal.Parse(txtVlrDemaisHora.Text));
                txtQtdeHora.Text = Math.Round(decimal.Parse(ts.TotalHours.ToString())).ToString("F2");
                txtSaldo.Text = total.ToString("F2");
                txtVlrTotal.Text = total.ToString("F2");

                LiberarBotoes(true, true, false, true);
                LiberarCampos(false, false, false, false, false, false, false, false, false, false, false);

                txtSeqformapagto.Focus();
            }
        }

        private void frmMovimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                btnPesquisar.PerformClick();

            if (e.KeyCode == Keys.F3)
                Pesquisar.MostrarConvenio();

            if (e.KeyCode == Keys.F5)
                btnGravar.PerformClick();

            if (e.KeyCode == Keys.Escape)
                btnLimpar.PerformClick();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text.Length > 0)
            {
                PesquisarPlaca(txtPlaca.Text);
            }
            else if (txtPlaca.Text.Length == 0)
            {
                Pesquisar.MostrarMovtoPlaca();
                txtSeqmovto.Text = Properties.Settings.Default.sequencia;
            }
        }

        private void txtSeqconvenio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSeqconvenio.Text.Length > 0)
                PesquisarConvenio(txtSeqconvenio.Text);
            else
                Pesquisar.MostrarConvenio();
        }

        private void PesquisarConvenio(string seqconvenio)
        {
            foreach (var c in ConvenioController.listarConvenioBySeqconvenio(seqconvenio))
            {
                txtRazaoNome.Text = c.Pessoa;
                txtVlrDesc.Text = c.Valor.ToString("F2");
            }
        }

        private void txtSeqmodelo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtSeqconvenio.Focus();
        }
    }
}
