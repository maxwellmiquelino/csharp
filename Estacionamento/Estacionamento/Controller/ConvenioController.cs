using Estacionamento.AppUtil;
using Estacionamento.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace Estacionamento.Controller
{
    public class ConvenioController
    {
        public static bool insert(Convenio obj)
        {
            bool retorno = true;
            try
            {
                string sql = "insert into convenio(seqpessoa,valor,ultnome) values(@seqpessoa,@valor,@ultnome)";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@seqpessoa", obj.Seqpessoa);
                cmd.Parameters.AddWithValue("@valor", obj.Valor);
                cmd.Parameters.AddWithValue("@ultnome", obj.Ultnome);
                cmd.Connection = BancoDados.ConectarBD();
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Cadastro de convenio ( " + obj.Seqconvenio + " ) inserido com sucesso !!!", "APP");
            }
            catch (SQLiteException erro)
            {
                retorno = false;
                Funcao.GravarLog("Erro ao cadastrar o convenio ( " + obj.Seqconvenio + " ) " + erro.Message);
            }

            return retorno;
        }

        public static bool update(Convenio obj)
        {
            bool retorno = true;
            try
            {
                string sql = "update convenio set seqpessoa = @seqpessoa, valor = @valor , ultnome = @ultnome" +
                    " where seqconvenio = @seqconvenio";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@seqpessoa", obj.Seqpessoa);
                cmd.Parameters.AddWithValue("@valor", obj.Valor);
                cmd.Parameters.AddWithValue("@ultnome", obj.Ultnome);
                cmd.Connection = BancoDados.ConectarBD();
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Cadastro de convenio ( " + obj.Pessoa + " ) atualizado com sucesso !!!", "APP");
            }
            catch (SQLiteException erro)
            {
                retorno = false;
                Funcao.GravarLog("Erro ao atualizar convenio ( " + obj.Pessoa + " ) " + erro.Message);
            }

            return retorno;
        }

        public static List<Convenio> listarConvenioBySeqconvenio(string seqconvenio)
        {
            //Cria lista
            List<Convenio> convenios = new List<Convenio>();

            try
            {
                Convenio convenio = new Convenio();
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format("select * from vw_convenio where seqconvenio = {0}", seqconvenio), BancoDados.ConectarBD());

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
                    convenio.Seqconvenio = int.Parse(dataRow["seqconvenio"].ToString());
                    convenio.Seqpessoa = int.Parse(dataRow["seqpessoa"].ToString());
                    convenio.Pessoa = dataRow["razaonome"].ToString();
                    convenio.Valor = decimal.Parse(dataRow["valor"].ToString());

                    convenios.Add(convenio);
                }
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.List<Convenio> listarConvenioBySeqconvenio(string seqconvenio) : " + erro.Message.ToString());
            }

            return convenios;
        }

        public static DataTable listarPessoaBySeqpessoa(string seqpessoa)
        {
            //Estrutura da tabela 
            DataTable dataTable = new DataTable();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format("select * from vw_pessoa where seqpessoa = {0}", seqpessoa), BancoDados.ConectarBD());

                //Intermediario recebe a respota do comandos sql enviado  
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);

                //Preencher com a estrutura do select enviado com as tuplas
                dataAdapter.Fill(dataTable);
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.DataTable listarPessoa(string filtro = '')() : " + erro.Message.ToString());
            }

            return dataTable;
        }

        public static DataTable listarConvenio(string filtro = "")
        {
            //Estrutura da tabela 
            DataTable dataTable = new DataTable();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format("select * from vw_convenio {0}", filtro), BancoDados.ConectarBD());

                //Intermediario recebe a respota do comandos sql enviado  
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);

                //Preencher com a estrutura do select enviado com as tuplas
                dataAdapter.Fill(dataTable);
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.listarMovimento(string filtro = '')() : " + erro.Message.ToString());
            }

            return dataTable;
        }

        public static int GetSeqConvenio()
        {
            int retorno = -1;
            try
            {
                string script = "SELECT seq FROM sqlite_sequence WHERE name = 'convenio'";
                StringBuilder sql;
                sql = new StringBuilder(script);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql.ToString(), BancoDados.ConectarBD());
                DataSet ds = new DataSet();
                da.Fill(ds, "param");
                var qtdLinhas = ds.Tables[0].Rows.Count.ToString();
                retorno = int.Parse(qtdLinhas) > 0 ? int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString()) + 1 : 1;
            }
            catch (SQLiteException erro)
            {
                retorno = -1;
                Funcao.GravarLog("BancoDados.GetSeqUsuario() : " + erro.Message.ToString());
            }

            return retorno;
        }
    }
}
