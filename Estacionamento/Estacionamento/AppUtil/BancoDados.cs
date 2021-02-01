
using Estacionamento.Controller;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Estacionamento.AppUtil
{
    public class BancoDados
    {
        private static string DiretorioBD = Application.StartupPath + @"\Dados\";
        private static string ArquivoBD = "estacionamento.db";

        #region Verifica se existe o arquivo do banco de dados
        public static void ExisteArquivoBD()
        {
            if (!File.Exists(DiretorioBD + ArquivoBD))
            {
                onCreate();
                InserirDadosBD();
            }
        }
        #endregion

        #region Retornar string de conexão
        public static string RetornarStringConexao()
        {
            //return string.Format(@"Data Source={0}\{1};Password={2};", DiretorioBD, ArquivoBD, Funcao.Decrypt("@eWGOfFN+e5w=")).ToString();
            return string.Format(@"Data Source={0}\{1};", DiretorioBD, ArquivoBD).ToString();
        }
        #endregion

        #region Conexão do banco de dados
        /// <summary>
        /// Conecta ao banco de dados.
        /// </summary>
        /// <returns></returns>
        public static SQLiteConnection ConectarBD()
        {
            SQLiteConnection cnx = new SQLiteConnection();

            try
            {
                cnx.ConnectionString = RetornarStringConexao();
                cnx.Open();
            }
            catch (SQLiteException e)
            {
                Funcao.GravarLog("SQLiteConnection ConectarBD() : " + e.Message.ToString());
            }

            return cnx;
        }
        #endregion

        #region Criar estrutura do banco de dados
        private static void onCreate()
        {
            #region Banco de Dados
            // Cria o banco de dados
            try
            {
                if (!Directory.Exists(DiretorioBD))
                    Directory.CreateDirectory(DiretorioBD);

                SQLiteConnection.CreateFile(string.Format("{0}{1}", DiretorioBD, ArquivoBD));
                Funcao.GravarLog("Arquivo do banco de dados ( estacionamento.db ) criado com sucesso !!!", "APP");
            }
            catch (Exception ex)
            {
                Funcao.GravarLog("BancoDados.onCreate() Criar arquivo 'estacionamento.db' : " + ex.Message);
            }
            #endregion

            #region Cria as tabelas
            // Cria a tabela pessoa
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.gerarTabelaPessoa(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Tabela 'pessoa' criado com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() Criar tabela 'pessoa' : " + erro.Message);
            }

            // Cria a tabela convenio
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.gerarTabelaConvenio(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Tabela 'convenio' criado com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() Criar tabela 'convenio' : " + erro.Message);
            }

            // Cria a tabela formapagto
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.gerarTabelaFormaPagto(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Tabela 'formapagto' criado com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() Criar tabela 'formapagto' : " + erro.Message);
            }

            // Cria a tabela marca
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.gerarTabelaMarca(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Tabela 'marca' criado com sucessso!", "APP");
            }
            catch(SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() Criar tabela 'marca' : " + erro.Message);
            }

            // Cria a tabela modelo
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.gerarTabelaModelo(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Tabela 'modelo' criado com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() Criar tabela 'modelo' : " + erro.Message);
            }

            // Cria a tabela movimentacao
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.gerarTabelaMovimentacao(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Tabela 'movto' criado com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() Criar tabela 'movto' : " + erro.Message);
            }

            // Cria a tabela movtoformapagto
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.gerarTabelaMovtoFormaPagto(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Tabela 'movtoformapagto' criado com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() Criar tabela 'movtoformapagto' : " + erro.Message);
            }

            // Cria a tabela parametro
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.gerarTabelaParametro(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Tabela 'parametro' criado com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() Criar tabela 'parametro' : " + erro.Message);
            }

            // Cria a tabela telefone
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.gerarTabelaTelefone(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Tabela 'telefone' criado com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() Criar tabela 'telefone' : " + erro.Message);
            }

            // Cria a tabela usuario
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.gerarTabelaUsuario(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Tabela 'usuario' criado com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() Criar tabela 'usuario' : " + erro.Message);
            }
            #endregion

            #region Cria as Views
            // Cria a view vw_usuario
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.gerarViewTabelaUsuario(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("View 'vw_usuario' criado com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() Criar view 'vw_usuario' : " + erro.Message);
            }

            // Cria a view vw_formapagto
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.gerarViewTabelaFormaPagto(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("View 'vw_formapagto' criado com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() Criar view 'vw_formapagto' : " + erro.Message);
            }

            // Cria a view vw_pessoa
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.gerarViewTabelaPessoa(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("View 'vw_pessoa' criado com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() Criar view 'vw_pessoa' : " + erro.Message);
            }

            // Cria a view vw_convenio
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.gerarViewTabelaConvenio(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("View 'vw_convenio' criado com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() Criar view 'vw_convenio' : " + erro.Message);
            }

            // Cria a view vw_movimento
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.gerarViewTabelaMovimento(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("View 'vw_movimento' criado com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() Criar view 'vw_movimento' : " + erro.Message);
            }

            // Cria a view vw_modelo
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.gerarViewModeloVeiculo(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("View 'vw_modelo' criado com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() Criar view 'vw_modelo' : " + erro.Message);
            }
            #endregion
        }
        #endregion

        #region Insere os dados no banco
        private static void InserirDadosBD()
        {
            // Insere dados do formapagto
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.inserirDadosFormaPagto(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Dados na tabela 'formapagto' inserido com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() - Erro ao inserir dados na tabela 'formapagto' : " + erro.Message);
            }

            // Insere os dados da marca de veiculos
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.inserirDadosMarca(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Dados na tabela 'marca' inserido com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() - Erro ao inserir dados na tabela 'marca' : " + erro.Message);
            }

            // Insere os dados da modelos de caminhão
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.inserirDadosModeloCaminhao(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Dados de caminhão na tabela 'modelo' inserido com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() - Erro ao inserir dados de caminhão na tabela 'modelo' : " + erro.Message);
            }

            // Insere os dados da modelos de nautica
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.inserirDadosModeloNautica(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Dados de nautica na tabela 'modelo' inserido com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() - Erro ao inserir dados de nautica na tabela 'modelo' : " + erro.Message);
            }

            // Insere os dados da modelos de moto
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.inserirDadosModeloMoto(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Dados de moto na tabela 'modelo' inserido com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() - Erro ao inserir dados de moto na tabela 'modelo' : " + erro.Message);
            }

            // Insere os dados da modelos de carro
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.inserirDadosModeloCarro(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Dados de carro na tabela 'modelo' inserido com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() - Erro ao inserir dados de carro na tabela 'modelo' : " + erro.Message);
            }

            // Insere os dados do parametro
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.inserirDadosParametro(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Dados de parametro na tabela 'parametro' inserido com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() - Erro ao inserir dados de parametro na tabela 'parametro' : " + erro.Message);
            }

            // Insere dados do Usuario
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(AppDataBase.inserirDadosUsuario(), ConectarBD());
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Dados na tabela 'usuario' inserido com sucessso!", "APP");
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.onCreate() - Erro ao inserir dados na tabela 'usuario' : " + erro.Message);
            }
        }
        #endregion
        
        /// <summary>
        /// Retorna o parametro solicitado. 
        /// </summary>
        /// <param name="grupo">Grupo do parametro.</param>
        /// <param name="parametro">Parametro do sistema.</param>
        /// <returns></returns>
        public static string RetornarParametro(string grupo, string parametro)
        {
            string retorno = null;
            try
            {
                string script = string.Format("select * from parametro where grupo like '{0}' and parametro like '{1}'", grupo, parametro);
                StringBuilder sql;
                sql = new StringBuilder(script);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql.ToString(), ConectarBD());
                DataSet ds = new DataSet();
                da.Fill(ds, "param");
                retorno = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            }
            catch (SQLiteException erro)
            {
                retorno = null;
                Funcao.GravarLog("BancoDados.RetornarParametro(string grupo, string parametro) : " + erro.Message.ToString());
            }

            return retorno;
        }
    }
}
