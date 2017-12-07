using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace AcessoDados
{
    public class conexao
    {

        private String connectionString;

        private SqlConnection connection;

        private SqlCommand command;



        public void LimparParametros()
        {
            this.command.CommandText = "";
        }


        public void abreConexao()
        {
            this.connectionString = ("Data Source=.\\SQLEXPRESS;Initial Catalog=SISFINAN;Integrated Security=True");
            this.connection = new SqlConnection(this.connectionString);

            this.connection.Open();
        }

        public void executeQuery(String query)
        {
            this.command = new SqlCommand();
            this.command.Connection = this.connection;
            this.command.CommandText = query;
            this.command.CommandType = CommandType.Text;

            this.command.ExecuteNonQuery();
            this.command.CommandText = "";


        }

        public System.Data.DataTable getResult()
        {
            DataTable dataTable;
            SqlDataReader dataReader;

            dataTable = new DataTable();
            dataReader = this.command.ExecuteReader(CommandBehavior.CloseConnection);

            dataTable.Load(dataReader, LoadOption.OverwriteChanges);
            dataReader.Close();
            dataReader.Dispose();

            return (dataTable);
        }

        public void close()
        {
            if (this.connection.Equals(null) == false)
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }
        }
    }
}
