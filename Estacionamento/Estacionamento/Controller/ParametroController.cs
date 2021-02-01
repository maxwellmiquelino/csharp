using Estacionamento.AppUtil;
using Estacionamento.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Estacionamento.Controller
{
    public class ParametroController
    {
        public static bool update(Parametro obj)
        {
            bool retorno = true;

            try
            {
                string sql = "update parametro set valor = @valor where grupo = @grupo and parametro = @parametro";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@grupo", obj.Grupo);
                cmd.Parameters.AddWithValue("@valor", obj.Valor);
                cmd.Parameters.AddWithValue("@parametro", obj.Param);
                cmd.Connection = BancoDados.ConectarBD();
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Parametro ( " + obj.Grupo + "." + obj.Param + " ) atualizado com sucesso !!!", "APP");
            }
            catch (SQLiteException erro)
            {
                retorno = false;
                Funcao.GravarLog("Erro ao atualizar o parametro ( " + obj.Grupo + "." + obj.Param + " ) " + erro.Message);
            }

            return retorno;
        }

        public static DataTable listarGrupo()
        {
            DataTable dataTable = new DataTable();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand("select distinct(grupo) grupo from parametro order by grupo", 
                    BancoDados.ConectarBD());

                //Intermediario recebe a respota do comandos sql enviado  
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);

                //Preencher com a estrutura do select enviado com as tuplas
                dataAdapter.Fill(dataTable);
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.listarGrupo() : " + erro.Message.ToString());
            }

            return dataTable;
        }

        public static DataTable listarGrupoParametro(string grupo)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format("select parametro from parametro where grupo = '{0}' order by parametro", grupo),
                    BancoDados.ConectarBD());

                //Intermediario recebe a respota do comandos sql enviado  
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);

                //Preencher com a estrutura do select enviado com as tuplas
                dataAdapter.Fill(dataTable);
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.listarGrupoParametro() : " + erro.Message.ToString());
            }

            return dataTable;
        }

        public static DataTable listarGrupoParametroValor(string grupo, string parametro)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format(
                        "select valor from parametro where grupo = '{0}' and parametro = '{1}' order by parametro", grupo, parametro),
                    BancoDados.ConectarBD());

                //Intermediario recebe a respota do comandos sql enviado  
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);

                //Preencher com a estrutura do select enviado com as tuplas
                dataAdapter.Fill(dataTable);
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.listarGrupoParametro() : " + erro.Message.ToString());
            }

            return dataTable;
        }
    }
}
