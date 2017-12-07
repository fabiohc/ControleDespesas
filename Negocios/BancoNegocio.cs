using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcessoDados;
using ObjetoDeTransferenciaDto;
using System.Data;


namespace Negocios
{
    public class BancoNegocio
    {
        AcessoDadosSqlserver acessoDadosSQLSERVER = new AcessoDadosSqlserver();

        public string inserir(BancoDTO bancoDto)
        {
            acessoDadosSQLSERVER.LimparParametros();
            acessoDadosSQLSERVER.AdicionarParametros("NomeBanco", bancoDto.BancoNome);
            acessoDadosSQLSERVER.AdicionarParametros("CodBanco", bancoDto.CodBanco);
            string BancoCadastrado = acessoDadosSQLSERVER.ExecutaManipulacao(CommandType.Text, "Insert into banco values('" + bancoDto.BancoNome + "," + bancoDto.CodBanco + "')").ToString();
            return BancoCadastrado;
        }


        public ColecaoBancoDto consultarBancoNome(string BancoNome)
        {

          try
            {
                ColecaoBancoDto colecaoBanco = new ColecaoBancoDto();

                acessoDadosSQLSERVER.LimparParametros();
                acessoDadosSQLSERVER.AdicionarParametros("NomeBanco", BancoNome);
                                             
                DataTable BancoConsulta = acessoDadosSQLSERVER.ExecutaConsulta(CommandType.Text,String.Format( "select * from banco where Ban_NomeBanco like '%{0}%'",BancoNome));

                foreach (DataRow linha in BancoConsulta. Rows)
                {
                    BancoDTO bancoDto = new BancoDTO();

                    bancoDto.BancoNome = Convert.ToString(linha["Ban_NomeBanco"]);
                    bancoDto.CodBanco = Convert.ToString(linha["Ban_CodBanco"]);

                    colecaoBanco.Add(bancoDto);

                }

                return colecaoBanco;
            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel consultar o Banco com os parâmetros informados. Verifique se há bancos cadastrados com esses parâmetros!");
            }

        }

        public ColecaoBancoDto consultarBancoCodigo(string CodBanco)
        {

            try
            {
                ColecaoBancoDto colecaoBanco = new ColecaoBancoDto();

                acessoDadosSQLSERVER.LimparParametros();
                acessoDadosSQLSERVER.AdicionarParametros("CodBanco", CodBanco);

                DataTable BancoConsulta = acessoDadosSQLSERVER.ExecutaConsulta(CommandType.Text, String.Format("select * from banco where Ban_CodBanco like '%{0}%'", CodBanco));

                foreach (DataRow linha in BancoConsulta.Rows)
                {
                    BancoDTO bancoDto = new BancoDTO();

                    bancoDto.BancoNome = Convert.ToString(linha["Ban_NomeBanco"]);
                    bancoDto.CodBanco = Convert.ToString(linha["Ban_CodBanco"]);

                    colecaoBanco.Add(bancoDto);

                }

                return colecaoBanco;
            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel consultar o Banco com os parâmetros informados. Verifique se há bancos cadastrados com esses parâmetros!");
            }

        }

    }
}