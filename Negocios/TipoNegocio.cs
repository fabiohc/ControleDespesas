using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObjetoDeTransferenciaDto;
using System.Data;
using AcessoDados;

namespace Negocios
{
   public class TipoNegocio
    {
        AcessoDadosSqlserver acessoDadosSqlServer = new AcessoDadosSqlserver();


        public string inserirTipo(TipoDTO tipoDTO)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("Tipo", tipoDTO.Tipo);
            string ReceitaTipo = acessoDadosSqlServer.ExecutaManipulacao(CommandType.Text, String.Format("Insert into tipo values ('{0}')", tipoDTO.Tipo)).ToString();


            return ReceitaTipo;
        }

        //public ColecaoTipoDTO AlterarOrigem(string StrTipo, int IdTipo)
        //{

        //    try
        //    {
        //        ColecaoTipoDTO colecaoTipoDTO = new ColecaoTipoDTO();

        //        acessoDadosSqlServer.LimparParametros();
        //        acessoDadosSqlServer.adicionarParametros("colecaoTipo", colecaoTipoDTO);

        //        DataTable colecaoTipo = acessoDadosSqlServer.ExecutaConsulta(CommandType.Text, String.Format("select * from Origem where Ori_Descricao like '%{0}%'", colecaoTipoDTO));

        //        foreach (DataRow linha in colecaoTipo.Rows)
        //        {
        //            OrigemDTO origemDto = new OrigemDTO();

        //            origemDto.Origem = Convert.ToString(linha["Ori_Descricao"]);

        //            colecaoTipoDTO.Add(origemDto);

        //        }

        //        return colecaoTipoDTO;
        //    }
        //    catch (Exception)
        //    {

        //        throw new Exception("Não foi possivel consultar o Banco com os parâmetros informados. Verifique se há bancos cadastrados com esses parâmetros!");
        //    }

        //}

        public ColecaoTipoDTO consultarTipo(string StrTipo)
        {

            try
            {
                ColecaoTipoDTO colecaoTipoDTO = new ColecaoTipoDTO();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("StrTipo", StrTipo);

                DataTable ConsultaTipo = acessoDadosSqlServer.ExecutaConsulta(CommandType.Text, String.Format("select * from Tipo where tip_Descricao like '%{0}%'", StrTipo));

                foreach (DataRow linha in ConsultaTipo.Rows)
                {
                    TipoDTO tipoDTO = new TipoDTO();

                    tipoDTO.Tipo = Convert.ToString(linha["Tip_Descricao"]);

                    colecaoTipoDTO.Add(tipoDTO);

                }

                return colecaoTipoDTO;
            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel consultar o Banco com os parâmetros informados. Verifique se há bancos cadastrados com esses parâmetros!");
            }

        }

    }
}
