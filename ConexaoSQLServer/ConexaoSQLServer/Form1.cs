using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexaoSQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection())
                {
                    cnx.ConnectionString = "data source=MAXWELL;initial catalog=master; user id=sa; password=1234";
                    cnx.Open();
                    label1.Text = "Conexão com SQL Server com sucesso !!!";
                }
            }
            catch(SqlException erro)
            {
                label1.Text = erro.Message;
            }
        }
    }
}
