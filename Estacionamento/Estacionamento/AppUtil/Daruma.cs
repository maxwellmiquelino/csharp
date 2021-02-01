using Estacionamento.AppUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerardorComandas.Classes
{
    // Base de Conhecimento para Desenvolvedores
    // http://www.desenvolvedoresdaruma.com.br/help/#t=DarumaHelp.htm
    public class Daruma
    {
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regPortaComunicacao_DUAL_DarumaFramework(string stParametro);

        [DllImport("DarumaFrameWork.dll")]
        public static extern int iImprimirTexto_DUAL_DarumaFramework(string stTexto, int iTam);

        [DllImport("DarumaFrameWork.dll")]
        public static extern int regEnterFinal_DUAL_DarumaFramework(string stParametro);

        [DllImport("DarumaFrameWork.dll")]
        public static extern int iImprimirBMP_DUAL_DarumaFramework(string stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rStatusImpressora_DUAL_DarumaFramework();

        public static void Imprimir(string veiculo)
        {
            if (rStatusImpressora_DUAL_DarumaFramework() == 0 ||
                rStatusImpressora_DUAL_DarumaFramework() == -27 ||
                rStatusImpressora_DUAL_DarumaFramework() == -50 ||
                rStatusImpressora_DUAL_DarumaFramework() == 51 ||
                rStatusImpressora_DUAL_DarumaFramework() == 52)
                switch (rStatusImpressora_DUAL_DarumaFramework())
                {
                    case 0:
                        MessageBox.Show("0 (zero) - Impressora Desligada!",
                            "Gerador de Comanda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case -50:
                        MessageBox.Show("-50 - Impressora OFF-LINE!",
                            "Gerador de Comanda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case -51:
                        MessageBox.Show("-51 - Impressora Sem Papel!",
                            "Gerador de Comanda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case -27:
                        MessageBox.Show("-27 - Erro Generico!",
                            "Gerador de Comanda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            else
            {
                MessageBox.Show("Retorno não esperado!",
                    "Gerador de Comanda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Cabecalho, TituloMsg, Mensagem, MsgFinal;

            Cabecalho = new string('=', 48) + "\n";
            Cabecalho += BancoDados.RetornarParametro("Empresa", "RazaoNome") + "\n";
            Cabecalho += BancoDados.RetornarParametro("Empresa", "Fantasia") + "\n";
            Cabecalho += BancoDados.RetornarParametro("Empresa", "Endereco01") + "\n";
            Cabecalho += BancoDados.RetornarParametro("Empresa", "Endereco02") + "\n";
            Cabecalho = new string('=', 48);
            TituloMsg = BancoDados.RetornarParametro("Ticket", "TituloMSG");
            Mensagem = BancoDados.RetornarParametro("Ticket", "Msg01") + "\n";
            Mensagem += BancoDados.RetornarParametro("Ticket", "Msg02") + "\n";
            Mensagem += BancoDados.RetornarParametro("Ticket", "Msg03") + "\n";
            Mensagem += BancoDados.RetornarParametro("Ticket", "Msg04") + "\n";
            MsgFinal = BancoDados.RetornarParametro("Ticket", "MsgFinal");

            //regPortaComunicacao_DUAL_DarumaFramework(BancoDados.RetornarParametro("PortaImpressoraNaoFiscal").ToString());
            iImprimirTexto_DUAL_DarumaFramework("<fe><ce>" + Cabecalho + "</ce></fe><l></l>", 0);
            iImprimirTexto_DUAL_DarumaFramework("<fe>VEICULO : " + veiculo + "</fe><l></l>", 0);
            iImprimirTexto_DUAL_DarumaFramework("<fe>DATA : " + DateTime.Now.ToString() + "</fe><l></l>", 0);
            iImprimirTexto_DUAL_DarumaFramework("<fe><ce>" + TituloMsg + "</ce></fe><l></l>", 0);
            iImprimirTexto_DUAL_DarumaFramework("<fe><ce>" + Mensagem + "</ce></fe><l></l>", 0);
            iImprimirTexto_DUAL_DarumaFramework("<fe><ce>" + MsgFinal + "</ce></fe><l></l>", 0);
            iImprimirTexto_DUAL_DarumaFramework("<sn>1</sn><gui></gui>", 0);
        }
    }
}
