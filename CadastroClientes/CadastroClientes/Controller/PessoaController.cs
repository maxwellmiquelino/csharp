using CadastroClientes.Api;
using CadastroClientes.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CadastroClientes.Controller
{
    public class PessoaController
    {
        public static bool inserirPessoa(Pessoa obj)
        {
            bool flag = true;

            try
            {
                string sql = "insert into pessoa(cnpjcpf,ierg,razaonome,fantasia,cep,endereco,numero,complemento,bairro,cidade,uf,tipo,ativo)";
                sql += " values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}',{11},{12})";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = string.Format(sql, obj.Cpfcnpj, obj.Ierg, obj.Razaonome, obj.Fantasia, obj.Cep, obj.Endereco, obj.Numero,
                    obj.Complemento, obj.Bairro, obj.Cidade, obj.Uf, obj.Tipo, obj.Ativo);
                cmd.Connection = BancoDados.conectarBD();
                cmd.ExecuteNonQuery();
            }
            catch(SQLiteException erro)
            {
                flag = false;
                MessageBox.Show(erro.Message);
            }

            return flag;
        }

        public static bool atualizarPessoa(Pessoa obj)
        {
            bool flag = true;

            try
            {
                string sql = "update pessoa set cnpjcpf='{0}',ierg='{1}',razaonome='{2}',fantasia='{3}',cep='{4}',endereco='{5}',numero='{6}',";
                sql += "complemento='{7}',bairro='{8}',cidade='{9}',uf='{10}',tipo={11},ativo={12} where seqpessoa={13}";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = string.Format(sql, obj.Cpfcnpj, obj.Ierg, obj.Razaonome, obj.Fantasia, obj.Cep, obj.Endereco, obj.Numero,
                    obj.Complemento, obj.Bairro, obj.Cidade, obj.Uf, obj.Tipo, obj.Ativo, obj.Seqpessoa);
                cmd.Connection = BancoDados.conectarBD();
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException erro)
            {
                flag = false;
                MessageBox.Show(erro.Message);
            }

            return flag;
        }

        public static List<Pessoa> listarPessoaBySeqpessoa(string seqpessoa)
        {
            //Cria lista
            List<Pessoa> pessoas = new List<Pessoa>();

            try
            {
                Pessoa pessoa = new Pessoa();
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format("select * from pessoa where seqpessoa = {0}", seqpessoa), BancoDados.conectarBD());

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
                    pessoa.Cpfcnpj = dataRow["cnpjcpf"].ToString();
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
                    pessoa.Ativo = bool.Parse(dataRow["ativo"].ToString()) == true ? 1 : 0;

                    pessoas.Add(pessoa);
                }
            }
            catch (SQLiteException erro)
            {
                MessageBox.Show(erro.Message);
            }

            return pessoas;
        }

        public static DataTable listarPessoa()
        {
            DataTable dataTable = new DataTable();

            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from pessoa", BancoDados.conectarBD());
                da.Fill(dataTable);
            }
            catch(SQLiteException erro)
            {
                dataTable = null;
                MessageBox.Show(erro.Message);
            }


            return dataTable;
        }

        public static int getSeqpessoa()
        {
            int seq=0;
            try
            {
                string script = "select seq from sqlite_sequence where name = 'pessoa'";
                SQLiteDataAdapter da = new SQLiteDataAdapter(script, BancoDados.conectarBD());
                DataSet ds = new DataSet();
                da.Fill(ds, "tab");
                seq = ds.Tables[0].Rows.Count > 0 ? int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString()) + 1 : 1;
            }
            catch(SQLiteException erro)
            {
                seq = 0;
                MessageBox.Show(erro.Message);
            }
            return seq;
        }
    }
}
