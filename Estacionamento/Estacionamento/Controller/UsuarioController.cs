using Estacionamento.AppUtil;
using Estacionamento.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Controller
{  
    public class UsuarioController
    {
        public static bool insert(Usuario obj)
        {
            bool retorno = true;
            try
            {
                string sql = "insert into usuario(nome,login,senha,ativo,ultnome) values(@nome,@login,@senha,@ativo,@ultnome)";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@login", obj.Login);
                cmd.Parameters.AddWithValue("@senha", obj.Senha);
                cmd.Parameters.AddWithValue("@ativo", obj.Ativo);
                cmd.Parameters.AddWithValue("@ultnome", obj.Ultnome);
                cmd.Connection = BancoDados.ConectarBD();
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Cadastro do usuário ( " + obj.Nome + " ) inserido com sucesso !!!", "APP");
            }
            catch(SQLiteException erro)
            {
                retorno = false;
                Funcao.GravarLog("Erro ao cadastrar o usuário ( " + obj.Nome + " ) " + erro.Message);
            }

            return retorno;
        }

        public static bool update(Usuario obj)
        {
            bool retorno = true;
            try
            {
                string sql = "update usuario set nome = @nome, login = @login, senha = @senha, ativo = @ativo , ultnome = @ultnome"+
                    " where sequsuario = @sequsuario";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@sequsuario", obj.Sequsuario);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@login", obj.Login);
                cmd.Parameters.AddWithValue("@senha", obj.Senha);
                cmd.Parameters.AddWithValue("@ativo", obj.Ativo);
                cmd.Parameters.AddWithValue("@ultnome", obj.Ultnome);
                cmd.Connection = BancoDados.ConectarBD();
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Cadastro do usuário ( " + obj.Nome + " ) atualizado com sucesso !!!", "APP");
            }
            catch (SQLiteException erro)
            {
                retorno = false;
                Funcao.GravarLog("Erro ao cadastrar o usuário ( " + obj.Nome + " ) " + erro.Message);
            }

            return retorno;
        }

        /// <summary>
        /// Lista usuário passando seu sequsuario no parametro.
        /// </summary>
        /// <param name="sequsuario">Código sequencial no cadastro.</param>
        /// <returns></returns>
        public static List<Usuario> listarUsuarioBySequsuario(string sequsuario)
        {
            //Cria lista
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                Usuario usuario = new Usuario();
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format("select * from usuario where sequsuario = {0}", sequsuario), BancoDados.ConectarBD());

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
                    usuario.Sequsuario = int.Parse(dataRow["sequsuario"].ToString());
                    usuario.Nome = dataRow["nome"].ToString();
                    usuario.Login = dataRow["login"].ToString();
                    usuario.Senha = Funcao.Decrypt(dataRow["senha"].ToString());
                    usuario.Ativo = bool.Parse(dataRow["ativo"].ToString());

                    usuarios.Add(usuario);
                }
            }
            catch(SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.List<Usuario> listarUsuarios(string filtro)() : " + erro.Message.ToString());
            }

            return usuarios;
        }

        public static bool listarUsuarioByLogin(string login, string senha)
        {
            bool retorno = false;

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format("select * from vw_usuario where login = '{0}' and senha = '{1}' and ativo = 'SIM'", login, senha)
                    , BancoDados.ConectarBD());

                //Intermediario recebe a respota do comandos sql enviado  
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);

                //Estrutura da tabela 
                DataTable dataTable = new DataTable();

                //Preencher com a estrutura do select enviado com as tuplas
                dataAdapter.Fill(dataTable);

                retorno = dataTable.Rows.Count > 0 ? true : false;
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.listarUsuarioByLogin(string login, string senha) : " + erro.Message.ToString());
            }

            return retorno;
        }

        public static DataTable listarUsuario(string filtro = "")
        {
            //Estrutura da tabela 
            DataTable dataTable = new DataTable();
 
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format("select * from vw_usuario {0}", filtro), BancoDados.ConectarBD());

                //Intermediario recebe a respota do comandos sql enviado  
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);

                //Preencher com a estrutura do select enviado com as tuplas
                dataAdapter.Fill(dataTable);
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.List<Usuario> listarUsuarios(string filtro)() : " + erro.Message.ToString());
            }

            return dataTable;
        }

        public static DataTable listarUsuarioRelatorio(string script)
        {
            //Estrutura da tabela 
            DataTable dataTable = new DataTable();

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
                Funcao.GravarLog("BancoDados.List<Usuario> listarUsuarios(string filtro)() : " + erro.Message.ToString());
            }

            return dataTable;
        }

        public static int GetSeqUsuario()
        {
            int retorno = -1;
            try
            {
                string script = "SELECT seq FROM sqlite_sequence WHERE name = 'usuario'";
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
                Funcao.GravarLog("BancoDados.GetSeqUsuario() : " + erro.Message.ToString());
            }

            return retorno;
        }
    }
}
