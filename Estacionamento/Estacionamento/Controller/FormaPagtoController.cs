using Estacionamento.AppUtil;
using Estacionamento.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace Estacionamento.Controller
{
    public class FormaPagtoController
    {
        public static bool insert(FormaPagto obj)
        {
            bool retorno = true;
            try
            {
                string sql = "insert into formapagto(descricao,ativo,ultnome) values(@descricao,@ativo,@ultnome)";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                cmd.Parameters.AddWithValue("@ativo", obj.Ativo);
                cmd.Parameters.AddWithValue("@ultnome", obj.Ultnome);
                cmd.Connection = BancoDados.ConectarBD();
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Cadastro de formas de pagamentos ( " + obj.Descricao + " ) inserido com sucesso !!!", "APP");
            }
            catch (SQLiteException erro)
            {
                retorno = false;
                Funcao.GravarLog("Erro ao cadastrar a forma de pagamento ( " + obj.Descricao + " ) " + erro.Message);
            }

            return retorno;
        }

        public static bool update(FormaPagto obj)
        {
            bool retorno = true;
            try
            {
                string sql = "update formapagto set descricao = @descricao, ativo = @ativo , ultnome = @ultnome" +
                    " where seqformapagto = @seqformapagto";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@seqformapagto", obj.Seqformapagto);
                cmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                cmd.Parameters.AddWithValue("@ativo", obj.Ativo);
                cmd.Parameters.AddWithValue("@ultnome", obj.Ultnome);
                cmd.Connection = BancoDados.ConectarBD();
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Cadastro de formas de pagamentos ( " + obj.Descricao + " ) atualizado com sucesso !!!", "APP");
            }
            catch (SQLiteException erro)
            {
                retorno = false;
                Funcao.GravarLog("Erro ao cadastrar a forma de pagamento ( " + obj.Descricao + " ) " + erro.Message);
            }

            return retorno;
        }

        public static List<FormaPagto> listarFormaPagtoBySeqformapagto(string seqformapagto)
        {
            //Cria lista
            List<FormaPagto> formaPagtos = new List<FormaPagto>();

            try
            {
                FormaPagto formaPagto = new FormaPagto();
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format("select * from formapagto where seqformapagto = {0} and ativo = 1", seqformapagto), BancoDados.ConectarBD());

                //Intermediario recebe a respota do comandos sql enviado  
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);

                //Estrutura da tabela 
                DataTable dataTable = new DataTable();

                //Preencher com a estrutura do select enviado com as tuplas
                dataAdapter.Fill(dataTable);

                //Percorrer as linhas do datatable para adicionar na lista 
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    //Adiciona na lista Especificando a clouna 
                    formaPagto.Seqformapagto = int.Parse(dataRow["seqformapagto"].ToString());
                    formaPagto.Descricao = dataRow["descricao"].ToString();
                    formaPagto.Ativo = bool.Parse(dataRow["ativo"].ToString());

                    formaPagtos.Add(formaPagto);
                }
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.List<FormaPagto> listarUsuarioBySeqformapagto(string seqformapagto)() : " + erro.Message.ToString());
            }

            return formaPagtos;
        }

        public static DataTable listarFormaPagto(string filtro = "")
        {
            //Estrutura da tabela 
            DataTable dataTable = new DataTable();
            //Cria lista
            List<FormaPagto> usuarios = new List<FormaPagto>();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format("select * from vw_formapagto {0}", filtro), BancoDados.ConectarBD());

                //Intermediario recebe a respota do comandos sql enviado  
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);

                //Preencher com a estrutura do select enviado com as tuplas
                dataAdapter.Fill(dataTable);
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.DataTable listarFormaPagto(string filtro = '')() : " + erro.Message.ToString());
            }

            return dataTable;
        }

        public static DataSet listarFormaPagtoMovto()
        {
            //Estrutura da tabela 
            DataSet dataSet = new DataSet();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand("select * from vw_formapagto", BancoDados.ConectarBD());

                //Intermediario recebe a respota do comandos sql enviado  
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);

                //Preencher com a estrutura do select enviado com as tuplas
                dataAdapter.Fill(dataSet);
            }
            catch (SQLiteException erro)
            {
                Mensagem.Mostrar("Erro", erro.Message, "CONFIRMAR", 1);
                Funcao.GravarLog("FormaPagtoController.listarFormaPagtoMovto() : " + erro.Message.ToString());
            }

            return dataSet;
        }

        public static DataTable listarFormaPagtoRelatorio(string script)
        {
            //Estrutura da tabela 
            DataTable dataTable = new DataTable();
            //Cria lista
            List<FormaPagto> usuarios = new List<FormaPagto>();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(script, BancoDados.ConectarBD());

                //Intermediario recebe a respota do comandos sql enviado  
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);

                //Preencher com a estrutura do select enviado com as tuplas
                dataAdapter.Fill(dataTable);
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.DataTable listarFormaPagto(string filtro = '')() : " + erro.Message.ToString());
            }

            return dataTable;
        }

        public static int GetSeqFormaPagto()
        {
            int retorno = -1;
            try
            {
                string script = "SELECT seq FROM sqlite_sequence WHERE name = 'formapagto'";
                StringBuilder sql;
                sql = new StringBuilder(script);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql.ToString(), BancoDados.ConectarBD());
                DataSet ds = new DataSet();
                da.Fill(ds, "param");
                retorno = int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString()) + 1;
            }
            catch (SQLiteException erro)
            {
                retorno = -1;
                Funcao.GravarLog("BancoDados.GetSeqFormaPagto() : " + erro.Message.ToString());
            }

            return retorno;
        }
    }
}
