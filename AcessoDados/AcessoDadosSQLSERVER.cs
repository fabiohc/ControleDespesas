using System;
//Namespace que contem as classes que manipulam dados
using System.Data;
using System.Data.SqlClient;
using AcessoDados.Properties;

namespace AcessoDados
{
    public class AcessoDadosSqlserver
    {

        //Cria conexão
        private SqlConnection CriarConexao()
        {

            //return new SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=SISFINAN;Integrated Security=True");
            return new SqlConnection(Settings.Default.StringConexao);

        }

        private SqlParameterCollection sqlParameterColletion = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterColletion.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterColletion.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        //Persistencia - Inserir, Alterar, Ecluir

        public object ExecutaManipulacao(CommandType comandeType, string nomeStoreProcedureOuTextoSQL)
        {
            try
            {
                //Criar conexao
                SqlConnection sqlConnection = CriarConexao();
                //Abre conexao
                sqlConnection.Open();
                //Cria comando que vai levar informação ao banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Clocando as coisas dentro do comando
                sqlCommand.CommandType = comandeType;
                sqlCommand.CommandText = nomeStoreProcedureOuTextoSQL;
                sqlCommand.CommandTimeout = 7200;// Em segundos
                //Adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterColletion)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                    //Não existe mapeamento do tipo de objeto ObjetoDeTransferenciaDto.ColecaoDespesaDto para um provedor gerenciado de tipo nativo.
                }
                //Executa comando no banco de dados
                //return sqlCommand.ExecuteScalar();
                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
                //Consultar registros do banco de dados
        public DataTable ExecutaConsulta(CommandType comandeType, string nomeStoreProcedureOuTextoSQL)
        {
            try
            {
                //Criar conexao
                SqlConnection sqlConnection = CriarConexao();
                //Abre conexao
                sqlConnection.Open();
                //Cria comando que vai levar informação ao banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Clocando as coisas dentro do comando
                sqlCommand.CommandType = comandeType;
                sqlCommand.CommandText = nomeStoreProcedureOuTextoSQL;
                sqlCommand.CommandTimeout = 7200;// Em segundos
                //Adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterColletion)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value)); ;
                }

                //Criar um adaptador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //DataTable = Armazena os dados que vem do banco

                DataTable dataTable = new DataTable();

                //Preenche dataTable com adaptador

                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

    }
}