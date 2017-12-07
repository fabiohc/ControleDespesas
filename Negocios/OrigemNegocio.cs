using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcessoDados;
using ObjetoDeTransferenciaDto;

using System.Data;

namespace Negocios
{
    public class OrigemNegocio
    {

        AcessoDadosSqlserver acessoDadosSqlServer = new AcessoDadosSqlserver();


        public string inserir(OrigemDTO origemDTO)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("Origem", origemDTO.Origem);
            string CreditoOrigem = acessoDadosSqlServer.ExecutaManipulacao(CommandType.Text, String.Format("Insert into Origem values ('{0}')", origemDTO.Origem)).ToString();


            return CreditoOrigem;
        }

        public ColecaoOrigemDTO AlterarOrigem(string StrOrigem, int IdOrigem)
        {

            try
            {
                ColecaoOrigemDTO colecaoOrigem = new ColecaoOrigemDTO();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("ColecaoOrigem", colecaoOrigem);

                DataTable ConsultaOrigem = acessoDadosSqlServer.ExecutaConsulta(CommandType.Text, String.Format("select * from Origem where Ori_Descricao like '%{0}%'", colecaoOrigem));

                foreach (DataRow linha in ConsultaOrigem.Rows)
                {
                    OrigemDTO origemDto = new OrigemDTO();

                    origemDto.Origem = Convert.ToString(linha["Ori_Descricao"]);

                    colecaoOrigem.Add(origemDto);

                }

                return colecaoOrigem;
            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel consultar o Banco com os parâmetros informados. Verifique se há bancos cadastrados com esses parâmetros!");
            }

        }

        public ColecaoOrigemDTO consultarOrigem(string StrOrigem)
        {

            try
            {
                ColecaoOrigemDTO colecaoOrigem = new ColecaoOrigemDTO();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("StrOrigem", StrOrigem);

                DataTable ConsultaOrigem = acessoDadosSqlServer.ExecutaConsulta(CommandType.Text, String.Format("select * from Origem where Ori_Descricao like '%{0}%'", StrOrigem));

                foreach (DataRow linha in ConsultaOrigem.Rows)
                {
                    OrigemDTO origemDto = new OrigemDTO();

                    origemDto.Origem = Convert.ToString(linha["Ori_Descricao"]);

                    colecaoOrigem.Add(origemDto);

                }

                return colecaoOrigem;
            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel consultar o Banco com os parâmetros informados. Verifique se há bancos cadastrados com esses parâmetros!");
            }

        }
    }
}
