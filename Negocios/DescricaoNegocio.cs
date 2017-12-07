using System;
using AcessoDados;
using ObjetoDeTransferenciaDto;
using System.Data;


namespace Negocios
{
    public class DescricaoNegocio
    {

        AcessoDadosSqlserver acessoDadosSqlServer = new AcessoDadosSqlserver();


        public string inserirDecricao(DescricaoDTO descricaoDTO)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("Descricao", descricaoDTO.Descricao);
            string Descricao = acessoDadosSqlServer.ExecutaManipulacao(CommandType.Text, String.Format("Insert into Origem values ('{0}')", descricaoDTO.Descricao)).ToString();


            return Descricao;
        }




        public ColecaoDescricaoDTO ConsultaDescricao(string StrDescricao, int IdDescricao)
        {

            try
            {
                ColecaoDescricaoDTO ConsultaDescricao = new ColecaoDescricaoDTO();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("Descricao", ConsultaDescricao);
                acessoDadosSqlServer.AdicionarParametros("IdDescricao", ConsultaDescricao);

                DataTable Descricao = acessoDadosSqlServer.ExecutaConsulta(CommandType.Text, String.Format("select * from Descricao where Des_Descricao like '%{0}%'", ConsultaDescricao));

                foreach (DataRow linha in Descricao.Rows)
                {
                    DescricaoDTO descricaoDTO = new DescricaoDTO();

                    descricaoDTO.IdDescricao = Convert.ToInt32(linha["Des_IdDescricao"]);
                    descricaoDTO.Descricao = Convert.ToString(linha["[Des_Descricao"]);

                    ConsultaDescricao.Add(descricaoDTO);

                }

                return ConsultaDescricao;
            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel consultar o Banco com os parâmetros informados. Verifique se há bancos cadastrados com esses parâmetros!");
            }

        }

    }
}
