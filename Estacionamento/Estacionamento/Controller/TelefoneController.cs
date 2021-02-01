using Estacionamento.AppUtil;
using Estacionamento.Model;
using System.Data;
using System.Data.SQLite;

namespace Estacionamento.Controller
{
    public class TelefoneController
    {
        public static bool insert(Telefone obj)
        {
            bool retorno = true;
            try
            {
                string sql = "insert into telefone(seqpessoa,contato,telefone) values(@seqpessoa,@contato,@telefone)";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@seqpessoa", obj.Seqpessoa);
                cmd.Parameters.AddWithValue("@contato", obj.Contato);
                cmd.Parameters.AddWithValue("@telefone", obj.Tel);
                cmd.Connection = BancoDados.ConectarBD();
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Cadastro de telefone ( " + obj.Tel + " ) inserido com sucesso !!!", "APP");
            }
            catch (SQLiteException erro)
            {
                retorno = false;
                Funcao.GravarLog("Erro ao cadastrar o telefone ( " + obj.Tel + " ) " + erro.Message);
            }

            return retorno;
        }

        public static bool delete(string seqpessoa, string telefone)
        {
            bool retorno = true;
            try
            {
                string sql = "delete from telefone where seqpessoa = @seqpessoa and telefone = @telefone";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@seqpessoa", seqpessoa);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Connection = BancoDados.ConectarBD();
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Registro de telefone ( " + telefone + " ) apagado com sucesso !!!", "APP");
            }
            catch (SQLiteException erro)
            {
                retorno = false;
                Funcao.GravarLog("Erro ao deletar o telefone ( " + telefone + " ) " + erro.Message);
            }

            return retorno;
        }

        public static DataTable listarTelefoneBySeqpessoa(string seqpessoa)
        {
            //Estrutura da tabela 
            DataTable dataTable = new DataTable();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format("select * from telefone where seqpessoa = {0}", seqpessoa), BancoDados.ConectarBD());

                //Intermediario recebe a respota do comandos sql enviado  
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);

                //Preencher com a estrutura do select enviado com as tuplas
                dataAdapter.Fill(dataTable);
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.DataTable listarTelefoneBySeqpessoa(string seqpessoa) : " + erro.Message.ToString());
            }

            return dataTable;
        }
    }
}
