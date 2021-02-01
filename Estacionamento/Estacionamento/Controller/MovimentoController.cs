using Estacionamento.AppUtil;
using Estacionamento.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace Estacionamento.Controller
{
    public class MovimentoController
    {
        public static bool insert(Movimento obj)
        {
            bool retorno = true;
            try
            {
                string sql = "insert into movto(placa,seqmodelo,seqconvenio,motorista,dtamovimento,dtahorentrada,vlrhora,qtdehora,vlrdesc,vlrtotal,status,ultnome) " +
                    "values(@placa,@seqmodelo,@seqconvenio,@motorista,@dtamovimento,@dtahorentrada,@vlrhora,@qtdehora,@vlrdesc,@vlrtotal,@status,@ultnome)";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@placa", obj.Placa);
                cmd.Parameters.AddWithValue("@seqmodelo", obj.Seqmodelo);
                cmd.Parameters.AddWithValue("@seqconvenio", obj.Seqconvenio);
                cmd.Parameters.AddWithValue("@motorista", obj.Motorista);
                cmd.Parameters.AddWithValue("@dtamovimento", obj.Dtamovimento);
                cmd.Parameters.AddWithValue("@dtahorentrada", obj.Dtahorentrada);
                cmd.Parameters.AddWithValue("@vlrhora", obj.Vlrhora);
                cmd.Parameters.AddWithValue("@qtdehora", obj.QtdeHora);
                cmd.Parameters.AddWithValue("@vlrdesc", obj.Vlrdesc);
                cmd.Parameters.AddWithValue("@vlrtotal", obj.Vlrtotal);
                cmd.Parameters.AddWithValue("@status", obj.Status);
                cmd.Parameters.AddWithValue("@ultnome", obj.Ultnome);
                cmd.Connection = BancoDados.ConectarBD();
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Entrada de veículo placa ( " + obj.Placa + " ) inserido com sucesso !!!", "APP");
            }
            catch (SQLiteException erro)
            {
                retorno = false;
                Funcao.GravarLog("Erro ao cadastrar a placa ( " + obj.Placa + " ) " + erro.Message);
            }

            return retorno;
        }
        public static bool insertformpagtomovto(FormaPagtoMovto obj)
        {
            bool retorno = true;
            try
            {
                string sql = "insert into movtoformapagto(seqmovto,seqformapagto,vlrpago,ultnome) values (@seqmovto,@seqformapagto,@vlrpago,@ultnome)";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@seqmovto", obj.Seqmovto);
                cmd.Parameters.AddWithValue("@seqformapagto", obj.Seqformapagto);
                cmd.Parameters.AddWithValue("@vlrpago", obj.Valorpagto);
                cmd.Parameters.AddWithValue("@ultnome", obj.Ultnome);
                cmd.Connection = BancoDados.ConectarBD();
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Forma de pagamento número ( " + obj.Seqformapagto + " ) inserido com sucesso !!!", "APP");
            }
            catch (SQLiteException erro)
            {
                retorno = false;
                Funcao.GravarLog("Erro ao cadastrar a forma de pagamento ( " + obj.Seqformapagto + " ) " + erro.Message);
            }

            return retorno;
        }
        public static bool update(Movimento obj)
        {
            bool retorno = true;
            try
            {
                string sql = "update movto set dtahorsaida=@dtahorsaida,qtdehora=@qtdehora,vlrhora=@vlrhora,vlrdesc=@vlrdesc,vlrtotal=@vlrtotal," +
                    "status=@status,ultnome=@ultnome where placa=@placa and seqmovto=@seqmovto";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@placa", obj.Placa);
                cmd.Parameters.AddWithValue("@dtahorsaida", obj.Dtahorsaida);
                cmd.Parameters.AddWithValue("@seqmovto", obj.Seqmovto);
                cmd.Parameters.AddWithValue("@vlrhora", obj.Vlrhora);
                cmd.Parameters.AddWithValue("@qtdehora", obj.QtdeHora);
                cmd.Parameters.AddWithValue("@vlrdesc", obj.Vlrdesc);
                cmd.Parameters.AddWithValue("@vlrtotal", obj.Vlrtotal);
                cmd.Parameters.AddWithValue("@status", obj.Status);
                cmd.Parameters.AddWithValue("@ultnome", obj.Ultnome);
                cmd.Connection = BancoDados.ConectarBD();
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Cadastro de convenio ( " + obj.Placa + " ) atualizado com sucesso !!!", "APP");
            }
            catch (SQLiteException erro)
            {
                retorno = false;
                Funcao.GravarLog("Erro ao atualizar convenio ( " + obj.Placa + " ) " + erro.Message);
            }

            return retorno;
        }
        public static List<Movimento> listarMovtoBySeqmovto(string seqmovto)
        {
            //Cria lista
            List<Movimento> movtos = new List<Movimento>();

            try
            {
                Movimento movto = new Movimento();
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format("select * from movto where seqmovto = {0}", seqmovto), BancoDados.ConectarBD());

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
                    movto.Seqconvenio = int.Parse(dataRow["seqconvenio"].ToString());

                    movtos.Add(movto);
                }
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.List<Convenio> listarConvenioBySeqconvenio(Convenio obj)() : " + erro.Message.ToString());
            }

            return movtos;
        }
        public static List<Movimento> listarMovtoByPlaca(string placa)
        {
            //Cria lista
            List<Movimento> movtos = new List<Movimento>();

            try
            {
                Movimento movto = new Movimento();
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format("select seqmovto,seqmodelo,seqconvenio,dtahorentrada,motorista,vlrhora,vlrdesc from movto where placa = '{0}'" +
                    " and status = 1", placa), BancoDados.ConectarBD());

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
                    movto.Motorista = dataRow["motorista"].ToString();
                    movto.Dtahorentrada = dataRow["dtahorentrada"].ToString();
                    movto.Vlrhora = decimal.Parse(dataRow["vlrhora"].ToString());
                    movto.Vlrdesc = decimal.Parse(dataRow["vlrdesc"].ToString());
                    movto.Seqmodelo = int.Parse(dataRow["seqmodelo"].ToString());
                    movto.Seqmovto = int.Parse(dataRow["seqmovto"].ToString());
                    movto.Seqconvenio = dataRow["seqconvenio"].ToString() == string.Empty ? 0 : int.Parse(dataRow["seqconvenio"].ToString());

                    movtos.Add(movto);
                }
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("MovimentoController.listarMovtoByPlaca(string placa) : " + erro.Message.ToString());
            }

            return movtos;
        }
        public static List<Movimento> listarMovtoByPlacaNovo(string placa)
        {
            //Cria lista
            List<Movimento> movtos = new List<Movimento>();

            try
            {
                Movimento movto = new Movimento();
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format("select seqmovto,seqmodelo,seqconvenio,dtahorentrada,motorista,vlrhora from movto where placa = '{0}'", placa), BancoDados.ConectarBD());

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
                    movto.Motorista = dataRow["motorista"].ToString();
                    movto.Dtahorentrada = dataRow["dtahorentrada"].ToString();
                    movto.Vlrhora = decimal.Parse(dataRow["vlrhora"].ToString());
                    movto.Seqmodelo = int.Parse(dataRow["seqmodelo"].ToString());
                    movto.Seqmovto = int.Parse(dataRow["seqmovto"].ToString());
                    movto.Seqconvenio = dataRow["seqconvenio"].ToString() == string.Empty ? 0 : int.Parse(dataRow["seqconvenio"].ToString());

                    movtos.Add(movto);
                }
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("MovimentoController.listarMovtoByPlacaNovo(string placa) : " + erro.Message.ToString());
            }

            return movtos;
        }
        public static DataSet listarMovtoByDtamovimento()
        {
            //Estrutura da tabela 
            DataSet dataSet = new DataSet();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(
                    "select distinct(dtamovimento) dtamovimento from movto where status = 0 order by 1 desc",
                     BancoDados.ConectarBD());

                //Intermediario recebe a respota do comandos sql enviado  
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);

                //Preencher com a estrutura do select enviado com as tuplas
                dataAdapter.Fill(dataSet);
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("MovimentoController.listarFluxoCaixa(string filtro = '') : " + erro.Message.ToString());
            }

            return dataSet;
        }
        public static DataTable listarMovtoPlacaAtivo()
        {
            //Estrutura da tabela 
            DataTable dataTable = new DataTable();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand("select a.seqmovto,a.placa,b.seqmodelo, c.descricao marca, b.descricao modelo " +
                    "from movto a, modelo b, marca c where a.seqmodelo = b.seqmodelo and b.seqmarca = c.seqmarca " +
                    "and status = 1", BancoDados.ConectarBD());

                //Intermediario recebe a respota do comandos sql enviado  
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);

                //Preencher com a estrutura do select enviado com as tuplas
                dataAdapter.Fill(dataTable);
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.DataTable listarMovtoPlacaAtivo() : " + erro.Message.ToString());
            }

            return dataTable;
        }
        public static DataSet listarQtdeVaga()
        {
            //Estrutura da tabela 
            DataSet dataTable = new DataSet();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand("select count(*) qtde from movto where status = 1", BancoDados.ConectarBD());

                //Intermediario recebe a respota do comandos sql enviado  
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);

                //Preencher com a estrutura do select enviado com as tuplas
                dataAdapter.Fill(dataTable);
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.DataTable listarMovtoPlacaAtivo() : " + erro.Message.ToString());
            }

            return dataTable;
        }
        public static List<Movimento> listarMovimento(string seqmovto)
        {
            //Cria lista
            List<Movimento> movtos = new List<Movimento>();

            try
            {
                Movimento movto = new Movimento();
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format("select * from movto where seqmovto = {0}", seqmovto), BancoDados.ConectarBD());

                //Estrutura da tabela 
                DataTable dataTable = new DataTable();

                //Intermediario recebe a respota do comandos sql enviado  
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);

                //Preencher com a estrutura do select enviado com as tuplas
                dataAdapter.Fill(dataTable);

                //Percorrer as linhas do datatable para adicionar na lista 
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    //Adiciona na lista Especificando a clouna 
                    movto.Placa = dataRow["placa"].ToString();
                    movto.Dtahorentrada = dataRow["dtahorentrada"].ToString();
                    movto.Seqmodelo = int.Parse(dataRow["seqmodelo"].ToString());
                    movto.Seqconvenio = int.Parse(dataRow["seqconvenio"].ToString());
                    movto.Motorista = dataRow["motorista"].ToString();
                    movto.Vlrhora = decimal.Parse(dataRow["vlrhora"].ToString());
                    movto.Vlrdesc = decimal.Parse(dataRow["vlrdesc"].ToString());

                    movtos.Add(movto);
                }
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.listarMovimento() : " + erro.Message.ToString());
            }

            return movtos;
        }
        public static DataTable listarFluxoCaixa(string filtro = "")
        {
            //Estrutura da tabela 
            DataTable dataTable = new DataTable();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format("select * from vw_movimento {0}", filtro), BancoDados.ConectarBD());

                //Intermediario recebe a respota do comandos sql enviado  
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);

                //Preencher com a estrutura do select enviado com as tuplas
                dataAdapter.Fill(dataTable);
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("MovimentoController.listarFluxoCaixa(string filtro = '') : " + erro.Message.ToString());
            }

            return dataTable;
        }
        public static int GetSeqMovto()
        {
            int retorno = -1;
            try
            {
                string script = "SELECT seq FROM sqlite_sequence WHERE name = 'movto'";
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
