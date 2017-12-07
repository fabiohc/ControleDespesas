
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AcessoDados
{
    public class conexaoDados
    {

        public static SqlConnection conexao = new SqlConnection();

        public static void AbrirConexao()
        {
            conexao.ConnectionString = @"Data Source=.\\SQLEXPRESS;Initial Catalog=SISFINAN;Integrated Security=True";
   
            conexao.Open();
        }



        public static void FecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
                conexao.Dispose();
            }
        }


        public static void ExecutarComando(string textoComando)
        {
            if (conexao.State != ConnectionState.Open)
            {
                AbrirConexao();
            }
            SqlCommand comando = new SqlCommand();

            comando.CommandText = textoComando;
            comando.Connection = conexao;
            int registrosAfetados = comando.ExecuteNonQuery();
        }


        public static SqlDataReader SelecionarRegistros(string textoComando)
        {
            if (conexao.State != ConnectionState.Open)
            {

                AbrirConexao();
            }
            SqlCommand comando = new SqlCommand();

            comando.CommandText = textoComando;
            comando.Connection = conexao;
            return comando.ExecuteReader();
        }


        public static SqlDataReader SelecionarUmRegistro(string textoComando)
        {
            if (conexao.State != ConnectionState.Open)
            {
                AbrirConexao();
            }

            SqlCommand comando = new SqlCommand();
            comando.CommandText = textoComando;
            comando.Connection = conexao;
            return (SqlDataReader)comando.ExecuteScalar();
        }
    }
}
