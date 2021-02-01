using Estacionamento.AppUtil;
using Estacionamento.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace Estacionamento.Controller
{
    public class PessoaController
    {
        public static bool insert(Pessoa obj)
        {
            bool retorno = true;
            try
            {
                string sql = "insert into pessoa(cnpjcpf,ierg,razaonome,fantasia,cep,endereco,numero,complemento,bairro,cidade,uf,tipo,ativo,ultnome)";
                sql += " values(@cnpjcpf,@ierg,@razaonome,@fantasia,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@uf,@tipo,@ativo,@ultnome)";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cnpjcpf", obj.Cnpjcpf);
                cmd.Parameters.AddWithValue("@ierg", obj.Ierg);
                cmd.Parameters.AddWithValue("@razaonome", obj.Razaonome);
                cmd.Parameters.AddWithValue("@fantasia", obj.Fantasia);
                cmd.Parameters.AddWithValue("@cep", obj.Cep);
                cmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                cmd.Parameters.AddWithValue("@numero", obj.Numero);
                cmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                cmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                cmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                cmd.Parameters.AddWithValue("@uf", obj.Uf);
                cmd.Parameters.AddWithValue("@tipo", obj.Tipo);
                cmd.Parameters.AddWithValue("@ativo", obj.Ativo);
                cmd.Parameters.AddWithValue("@ultnome", obj.Ultnome);
                cmd.Connection = BancoDados.ConectarBD();
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Cadastro da pessoa ( " + obj.Razaonome + " ) inserido com sucesso !!!", "APP");
            }
            catch (SQLiteException erro)
            {
                retorno = false;
                Funcao.GravarLog("Erro ao cadastrar a pessoa ( " + obj.Razaonome + " ) " + erro.Message);
            }

            return retorno;
        }

        public static bool update(Pessoa obj)
        {
            bool retorno = true;

            try
            {
                string sql = "update pessoa set ierg = @ierg, razaonome = @razaonome, fantasia = @fantasia, cep = @cep, endereco = @endereco, ";
                sql += "numero = @numero, complemento = @complemento, bairro = @bairro, cidade = @cidade, uf = @uf, tipo = @tipo, ";
                sql += "ativo = @ativo, ultnome =@ultnome where seqpessoa = @seqpessoa and cnpjcpf = @cnpjcpf";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@seqpessoa", obj.Seqpessoa);
                cmd.Parameters.AddWithValue("@cnpjcpf", obj.Cnpjcpf);
                cmd.Parameters.AddWithValue("@ierg", obj.Ierg);
                cmd.Parameters.AddWithValue("@razaonome", obj.Razaonome);
                cmd.Parameters.AddWithValue("@fantasia", obj.Fantasia);
                cmd.Parameters.AddWithValue("@cep", obj.Cep);
                cmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                cmd.Parameters.AddWithValue("@numero", obj.Numero);
                cmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                cmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                cmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                cmd.Parameters.AddWithValue("@uf", obj.Uf);
                cmd.Parameters.AddWithValue("@tipo", obj.Tipo);
                cmd.Parameters.AddWithValue("@ativo", obj.Ativo);
                cmd.Parameters.AddWithValue("@ultnome", obj.Ultnome);
                cmd.Connection = BancoDados.ConectarBD();
                cmd.ExecuteNonQuery();
                Funcao.GravarLog("Cadastro da pessoa ( " + obj.Razaonome + " ) inserido com sucesso !!!", "APP");
            }
            catch (SQLiteException erro)
            {
                retorno = false;
                Funcao.GravarLog("Erro ao cadastrar a pessoa ( " + obj.Razaonome + " ) " + erro.Message);
            }

            return retorno;
        }

        public static List<Pessoa> listarPessoaBySeqpessoa(string seqpessoa)
        {
            //Cria lista
            List<Pessoa> pessoas = new List<Pessoa>();

            try
            {
                Pessoa pessoa = new Pessoa();
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format("select * from pessoa where seqpessoa = {0}", seqpessoa), BancoDados.ConectarBD());

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
                    pessoa.Seqpessoa = int.Parse(dataRow["seqpessoa"].ToString());
                    pessoa.Cnpjcpf = dataRow["cnpjcpf"].ToString();
                    pessoa.Ierg = dataRow["ierg"].ToString();
                    pessoa.Razaonome = dataRow["razaonome"].ToString();
                    pessoa.Fantasia = dataRow["fantasia"].ToString();
                    pessoa.Cep = dataRow["cep"].ToString();
                    pessoa.Endereco = dataRow["endereco"].ToString();
                    pessoa.Numero = dataRow["numero"].ToString();
                    pessoa.Complemento = dataRow["complemento"].ToString();
                    pessoa.Bairro = dataRow["bairro"].ToString();
                    pessoa.Cidade = dataRow["cidade"].ToString();
                    pessoa.Uf = dataRow["uf"].ToString();
                    pessoa.Tipo = int.Parse(dataRow["tipo"].ToString());
                    pessoa.Ativo = bool.Parse(dataRow["ativo"].ToString());

                    pessoas.Add(pessoa);
                }
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.List<Pessoa> listarMovtoPlaca(string seqpessoa)() : " + erro.Message.ToString());
            }

            return pessoas;
        }

        public static DataTable listarPessoa(string filtro = "")
        {
            //Estrutura da tabela 
            DataTable dataTable = new DataTable();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format("select * from vw_pessoa {0}", filtro), BancoDados.ConectarBD());

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

        public static DataTable listarPessoaRelatorio(string script)
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
                Funcao.GravarLog("BancoDados.DataTable listarPessoa(string filtro = '')() : " + erro.Message.ToString());
            }

            return dataTable;
        }

        public static List<Pessoa> listarPessoabyCnpjCpf(string cnpjcpf)
        {
            //Cria lista
            List<Pessoa> pessoas = new List<Pessoa>();

            try
            {
                Pessoa pessoa = new Pessoa();
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format("select * from vw_pessoa where cnpjcpf = '{0}' and ativo = 'SIM'", cnpjcpf), BancoDados.ConectarBD());

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
                    pessoa.Seqpessoa = int.Parse(dataRow["seqpessoa"].ToString());
                    pessoa.Cnpjcpf = dataRow["cnpjcpf"].ToString();
                    pessoa.Ierg = dataRow["ierg"].ToString();
                    pessoa.Razaonome = dataRow["razaonome"].ToString();
                    pessoa.Fantasia = dataRow["fantasia"].ToString();
                    pessoa.Cep = dataRow["cep"].ToString();
                    pessoa.Endereco = dataRow["endereco"].ToString();
                    pessoa.Numero = dataRow["numero"].ToString();
                    pessoa.Complemento = dataRow["complemento"].ToString();
                    pessoa.Bairro = dataRow["bairro"].ToString();
                    pessoa.Cidade = dataRow["cidade"].ToString();
                    pessoa.Uf = dataRow["uf"].ToString();
                    pessoa.Tipo = int.Parse(dataRow["tipo"].ToString());
                    pessoa.Ativo = dataRow["ativo"].ToString() == "SIM" ? true : false;

                    pessoas.Add(pessoa);
                }
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.List<Pessoa> listarPessoabyCnpjCpf(string cnpjcpf)() : " + erro.Message.ToString());
            }

            return pessoas;
        }

        public static int GetSeqPessoa()
        {
            int retorno;
            try
            {
                string script = "SELECT seq FROM sqlite_sequence WHERE name = 'pessoa'";
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
                Funcao.GravarLog("BancoDados.GetSeqPessoa() : " + erro.Message.ToString());
            }

            return retorno;
        }
    }
}
