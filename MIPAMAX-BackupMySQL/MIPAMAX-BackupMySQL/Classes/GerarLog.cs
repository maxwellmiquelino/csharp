using System;
using System.IO;
using System.Windows.Forms;

namespace MIPAMAX_BackupMySQL.Classes
{
    public class GerarLog
    {
        string nomeArquivo = Application.StartupPath + "\\" + DateTime.Now.ToString("yyyyMMdd") + "-LOG.TXT";

        public void criaLog(string texto)
        {
            // Cria um novo arquivo e devolve um StreamWriter para ele
            StreamWriter writer = new StreamWriter(nomeArquivo, true);

            // Agora é só sair escrevendo
            writer.WriteLine(DateTime.Now.ToString() + " - " + texto + "\n\n");

            // Não esqueça de fechar o arquivo ao terminar
            writer.Close();
        }
    }
}