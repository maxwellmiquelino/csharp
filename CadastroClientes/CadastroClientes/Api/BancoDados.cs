using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes.Api
{
    public class BancoDados
    {
        private static string arquivoBD = Application.StartupPath + @"\bancodados.db";

        public static bool existeArquivoBD()
        {
            bool flag;

            if (!File.Exists(arquivoBD))
            {
                flag = false;
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        public static void criarBancoDados()
        {
            try
            {
                SQLiteConnection.CreateFile(arquivoBD);
            }
            catch (SQLiteException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public static SQLiteConnection conectarBD()
        {
            SQLiteConnection cnx = new SQLiteConnection();

            try
            {
                cnx.ConnectionString = "Data source=" + arquivoBD;
                cnx.Open();
            }
            catch (SQLiteException erro)
            {
                MessageBox.Show(erro.Message);
            }

            return cnx;
        }

        public static void criarEstruturaBD()
        {
            string query;
            query = "create table if not exists pessoa (";
            query += "seqpessoa   Integer PRIMARY KEY ON CONFLICT ROLLBACK AUTOINCREMENT Not NULL,";
            query += "cnpjcpf     text ,";
            query += "ierg        text ,";
            query += "razaonome   text Not NULL,";
            query += "fantasia    text ,";
            query += "cep         text ,";
            query += "endereco    text ,";
            query += "numero      text ,";
            query += "complemento text ,";
            query += "bairro      text ,";
            query += "cidade      text ,";
            query += "uf          text ,";
            query += "tipo        integer Not NULL,";
            query += "ativo       boolean Not NULL)";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = query;
                cmd.Connection = conectarBD();
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException erro)
            {
                MessageBox.Show(erro.Message);
            }

            query = string.Empty;
            query = "create table if not exists contato (";
            query += "seqpessoa     Integer PRIMARY KEY ON CONFLICT ROLLBACK AUTOINCREMENT Not NULL,";
            query += "telefone      text ,";
            query += "email         text ,";
            query += "pessoacontato text)";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = query;
                cmd.Connection = conectarBD();
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
