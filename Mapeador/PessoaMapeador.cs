using AcessoDados;
using ObjetodetransferenciaDto;
using System.Data;

namespace Mapeador
{
    public class PessoaMapeador
    {

        AcessoDadosSQLSERVER acessoDadosSqlServer = new AcessoDadosSQLSERVER();


        public string inserir(PessoaDTO pessoaDTO)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.adicionarParametros("nome", pessoaDTO.Nome);
            return acessoDadosSqlServer.ExecutaManipulacao(CommandType.Text, "Insert into pessoa values('nome')").ToString();

        }

    }
}
