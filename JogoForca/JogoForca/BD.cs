using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace JogoForca
{
    class BD
    {
        public static string SQL;

        public static OleDbConnection ConectaBD()
        {
            OleDbConnection cnt = new OleDbConnection();
            String SQL;
            SQL = "PROVIDER=MICROSOFT.JET.OLEDB.4.0;DATA SOURCE=" + Application.StartupPath + @"\BD_FORCA.MDB;"
                + "Jet OLEDB:Database Password=adminMAX10";
            try
            {
                if (cnt.State == ConnectionState.Open)
                    cnt.Close();

                cnt.ConnectionString = SQL;
                cnt.Open();
            }
            catch (OleDbException ex)
            {
                if (ex.ErrorCode == -2147467259)
                    MessageBox.Show("Erro ao conectar ao Banco\n\nArquivo não encontrado" + ex.ToString(), "Erro");
                else
                    MessageBox.Show("Erro ao conectar ao Banco!\n\n" + ex.ToString(), "Erro");
            }

            return cnt;
        }

        public static DataTable Pesquisa(string script)
        {
            OleDbDataAdapter  da = new OleDbDataAdapter(script, BD.ConectaBD());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
