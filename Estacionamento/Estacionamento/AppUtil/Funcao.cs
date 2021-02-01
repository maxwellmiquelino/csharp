using Microsoft.VisualBasic.Devices;
using System;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Vip.Printer;
using Vip.Printer.Enums;

namespace Estacionamento.AppUtil
{
    public class Funcao
    {
        private static TripleDESCryptoServiceProvider TripleDES = new TripleDESCryptoServiceProvider();
        private static MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );


        /// <summary>
        /// Grava o registro do Log no arquivo.
        /// </summary>
        /// <param name="texto">Informação sobre o log.</param>
        /// <param name="TipoLog">LOG : Erro (default), APP : Informação</param>
        public static void GravarLog(string texto, string TipoLog = "LOG")
        {
            string NomeArquivo = DateTime.Now.ToString("yyyyMMdd") + "-" + TipoLog + ".TXT";
            string NomeDiretorio = @"\Log\";

            if (!Directory.Exists(Application.StartupPath + NomeDiretorio))
            {
                Directory.CreateDirectory(Application.StartupPath + NomeDiretorio);
            }
            // Cria um novo arquivo e devolve um StreamWriter para ele
            StreamWriter writer = new StreamWriter(Application.StartupPath + NomeDiretorio + NomeArquivo, true);

            // Agora é só sair escrevendo
            writer.WriteLine(DateTime.Now.ToString() + " - " + texto);

            // Não esqueça de fechar o arquivo ao terminar
            writer.Close();
        }

        /// <summary>
        /// method to retrieve the selected HDD's serial number
        /// </summary>
        /// <param name="strDriveLetter">Drive letter to retrieve serial number for</param>
        /// <returns>the HDD's serial number</returns>
        public static string GetHDDSerialNumber(string drive = "")
        {
            //check to see if the user provided a drive letter
            //if not default it to "C"
            if (drive == "" || drive == null)
            {
                drive = "C";
            }
            //create our ManagementObject, passing it the drive letter to the
            //DevideID using WQL
            ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + drive + ":\"");
            //bind our management object
            disk.Get();
            //return the serial number
            return disk["VolumeSerialNumber"].ToString();
        }

        ///// <summary>
        ///// Verifica a licença de uso.
        ///// </summary>
        ///// <returns></returns>
        //public static bool VerificarLicenca()
        //{
        //    bool retorno = false;
        //    string[] lic = Decrypt(BancoDados.RetornarParametro("Licenca")).Split('|');

        //    try
        //    {
        //        if (lic[0] != BancoDados.RetornarParametro("CNPJCPF"))
        //        {
        //            retorno = true;
        //        }
        //        if (lic[2] != GetHDDSerialNumber())
        //        {
        //            retorno = true;
        //        }

        //        int totalDias = (DateTime.Parse(lic[1]).Subtract(DateTime.Parse(DateTime.Now.ToString()))).Days + 2;

        //        if (totalDias <= 15)
        //        {
        //            string texto = "Falta {0} dia(s) para encerrar o uso do software, favor entrar em contato com administrador do software!!!";
        //            texto += "\n\nSeu último dia de uso é {1}";
        //            MessageBox.Show(string.Format(texto, totalDias, lic[1]), "Gerador de Comanda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }

        //        if (DateTime.Now > DateTime.Parse(lic[1]))
        //        {
        //            MessageBox.Show("Dias de uso encerrado, favor entrar em contato com administrador do software !!!",
        //                "Gerador de Comanda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            retorno = true;
        //        }
        //    }
        //    catch (Exception erro)
        //    {
        //        retorno = true;
        //        GerarLog.Inserir("Funcao.VerificarLicenca() : " + erro.Message.ToString());
        //    }

        //    return retorno;
        //}

        /// <summary>
        /// Verifica se existe conexão com a internet.
        /// </summary>
        /// <returns></returns>
        public static bool ExisteConexaoInternet()
        {
            try
            {
                Computer cpu = new Computer();
                cpu.Network.Ping("www.google.com", 500);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "").Replace(",", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        public static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        public static bool IsPis(string pis)
        {
            int[] multiplicador = new int[10] { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            if (pis.Trim().Length != 11)
                return false;
            pis = pis.Trim();
            pis = pis.Replace("-", "").Replace(".", "").Replace(",", "").PadLeft(11, '0');

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(pis[i].ToString()) * multiplicador[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            return pis.EndsWith(resto.ToString());
        }

        //private const string key = "@dM1nM@xW311";
        private const string key = "M@xw311";
        /// <summary> 
        ///     ''' Calcula o MD5 Hash  
        ///     ''' </summary> 
        ///     ''' <param name="value">Chave</param>
        public static byte[] MD5Hash(string value)
        {
            // Converte a chave para um array de bytes  
            byte[] byteArray = ASCIIEncoding.ASCII.GetBytes(value);
            return MD5.ComputeHash(byteArray);
        }
        /// <summary> 
        ///     ''' Encripta uma string com base em uma chave 
        ///     ''' </summary> 
        ///     ''' <param name="stringToEncrypt">String a encriptar</param>
        public static string Encrypt(string stringToEncrypt)
        {
            string retorno = "";

            try
            {
                // Definição da chave e da cifra (que neste caso é Electronic 
                // Codebook, ou seja, encriptação individual para cada bloco) 
                TripleDES.Key = MD5Hash(key);
                TripleDES.Mode = CipherMode.ECB;
                // Converte a string para bytes e encripta 
                byte[] Buffer = ASCIIEncoding.ASCII.GetBytes(stringToEncrypt);
                retorno = Convert.ToBase64String(TripleDES.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length));
            }
            catch (Exception ex)
            {
                GravarLog("Módulo : Crypto.Encrypt -" + ex.Message.ToString());
            }

            return retorno;
        }

        /// <summary> 
        ///     ''' Desencripta uma string com base em uma chave 
        ///     ''' </summary> 
        ///     ''' <param name="encryptedString">String a decriptar</param>
        public static string Decrypt(string encryptedString)
        {
            string retorno = "";

            try
            {
                // Definição da chave e da cifra 
                TripleDES.Key = MD5Hash(key);
                TripleDES.Mode = CipherMode.ECB;
                // Converte a string encriptada para bytes e decripta 
                byte[] Buffer = Convert.FromBase64String(encryptedString);

                retorno = ASCIIEncoding.ASCII.GetString(TripleDES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length));
            }
            catch (Exception ex)
            {
                GravarLog("Módulo : Crypto.Decrypt" + ex.Message.ToString());
            }

            return retorno;
        }

        public static string TratarChar(string str)
        {
            /** Troca os caracteres acentuados por não acentuados **/
            string[] acentos = new string[] { "ç", "Ç", "á", "é", "í", "ó", "ú", "ý", "Á", "É", "Í", "Ó", "Ú", "Ý", "à", "è", "ì", "ò", "ù", "À", "È", "Ì", "Ò", "Ù", "ã", "õ", "ñ", "ä", "ë", "ï", "ö", "ü", "ÿ", "Ä", "Ë", "Ï", "Ö", "Ü", "Ã", "Õ", "Ñ", "â", "ê", "î", "ô", "û", "Â", "Ê", "Î", "Ô", "Û" };
            string[] semAcento = new string[] { "c", "C", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "Y", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U", "a", "o", "n", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "A", "O", "N", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

            for (int i = 0; i < acentos.Length; i++)
            {
                str = str.Replace(acentos[i], semAcento[i]);
            }
            /** Troca os caracteres especiais da string por "" **/
            string[] caracteresEspeciais = { "\\.", ",", "-", ":", "\\(", "\\)", "ª", "\\|", "\\\\", "°", "£", "¡" };

            for (int i = 0; i < caracteresEspeciais.Length; i++)
            {
                str = str.Replace(caracteresEspeciais[i], "");
            }

            /** Troca os espaços no início por "" **/
            str = str.Replace("^\\s+", "");
            /** Troca os espaços no início por "" **/
            str = str.Replace("\\s+$", "");
            /** Troca os espaços duplicados, tabulações e etc por " " **/
            str = str.Replace("\\s+", " ");
            return str;
        }

        /// <summary>
        /// Faz o cálculo de estadia
        /// </summary>
        /// <param name="qtde">Quantidade de horas.</param>
        /// <param name="valorhora">Valor da primeira hora de estadia.</param>
        /// <param name="desc">Desconto se caso há do convenio</param>
        /// <param name="valordemaishora">Valor de demais horas de estadia.</param>
        /// <returns></returns>
        public static decimal calcularValorHora(decimal qtde, decimal valorhora, decimal desc, decimal valordemaishora = 0)
        {
            decimal total = 0;
            decimal valorQtdeHora = 0;

            /* Calcula a hora e demais hora caso parametro seja para calular
             * -------------------------------------------------------------
             * Caso a quantidade de horas é maior que 1 o sistema irá calular */
            if (BancoDados.RetornarParametro("Sistema", "UtilizaDemaisHora") == "S")
                valorQtdeHora = qtde > 1 ? ((qtde - 1) * valordemaishora) + valorhora : valorhora;
            else
                valorQtdeHora = qtde * valorhora;

            total = valorQtdeHora - desc;

            return total;
        }

        public static void ImprimirTicket(string veiculo)
        {
            string Cabecalho, TituloMsg, Mensagem, MsgFinal;

            Cabecalho = new string('=', 48) + "\n";
            Cabecalho += BancoDados.RetornarParametro("Empresa", "RazaoNome") + "\n";
            Cabecalho += BancoDados.RetornarParametro("Empresa", "Fantasia") + "\n";
            Cabecalho += BancoDados.RetornarParametro("Empresa", "Endereco01") + "\n";
            Cabecalho += BancoDados.RetornarParametro("Empresa", "Endereco02") + "\n";
            Cabecalho += new string('=', 48);
            TituloMsg = BancoDados.RetornarParametro("Ticket", "TituloMSG");
            Mensagem = BancoDados.RetornarParametro("Ticket", "Msg01") + "\n";
            Mensagem += BancoDados.RetornarParametro("Ticket", "Msg02") + "\n";
            Mensagem += BancoDados.RetornarParametro("Ticket", "Msg03") + "\n";
            Mensagem += BancoDados.RetornarParametro("Ticket", "Msg04") + "\n";
            MsgFinal = BancoDados.RetornarParametro("Ticket", "MsgFinal");

            // Impressora Não Fiscal Epson TM e Elgin I9
            // https://github.com/leandrovip/Vip.Printer
            /* 
                Instancie a classe Printer

                Para instanciar a classe é necessário dois parâmetros:
                - printerName (Nome da impressora, porta ou o caminho do compartilhamento)
                - printerType (Set de comandos que será utilizado. PrinterType.Bematech ou PrinterType.Epson)
            */
            var printer = new Printer(BancoDados.RetornarParametro("Impressora", "NomeImpressoraWindows").ToString(), 
                PrinterType.Epson);
            printer.Clear();
            printer.AlignCenter();
            printer.Append(Cabecalho);
            printer.Append("VEICULO : " + veiculo);
            printer.Append("DATA : " + DateTime.Now.ToString());
            printer.NewLine();
            printer.Append(TituloMsg);
            printer.Append(Mensagem);
            printer.Append(MsgFinal);
            printer.NewLines(2);
            printer.PartialPaperCut();
            printer.PrintDocument();
        }
    }
}
