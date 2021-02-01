using Estacionamento.AppUtil;
using Estacionamento.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Controller
{
    public class ModeloController
    {
        public static List<Modelo> listarModeloBySeqmodelo(string seqmodelo)
        {
            //Cria lista
            List<Modelo> modelos = new List<Modelo>();

            try
            {
                Modelo modelo = new Modelo();
                SQLiteCommand cmd = new SQLiteCommand(
                    string.Format("select a.seqmarca, a.descricao marca, b.seqmodelo, b.descricao  modelo from marca a, modelo b " +
                                  " where a.seqmarca = b.seqmarca and b.seqmodelo = {0}", seqmodelo), BancoDados.ConectarBD());

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
                    modelo.Seqmodelo = int.Parse(dataRow["seqmodelo"].ToString());
                    modelo.Descricao = dataRow["marca"].ToString() + " - " +
                        dataRow["modelo"].ToString();

                    modelos.Add(modelo);
                }
            }
            catch (SQLiteException erro)
            {
                Funcao.GravarLog("BancoDados.List<Convenio> listarConvenioBySeqconvenio(Convenio obj)() : " + erro.Message.ToString());
            }

            return modelos;
        }
    }
}
