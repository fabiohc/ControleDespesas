using AcessoDados;
using ObjetodetransferenciaDto;
using System.Data;
using System;

using ObjetoDeTransferenciaDto;

namespace Negocios
{
    public class PessoaNegocio
    {
        AcessoDadosSqlserver acessoDadosSqlServer = new AcessoDadosSqlserver();


        public string inserir(PessoaDTO pessoaDTO)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("Nome", pessoaDTO.Nome);
            string idCliente = acessoDadosSqlServer.ExecutaManipulacao(CommandType.Text, "Insert into pessoa values('" + pessoaDTO.Nome + "')").ToString();

            return idCliente;
        }

        public ColecaoPessoaDTO consultarPessoaNome(string PessoaNome)
        {

            try
            {
                ColecaoPessoaDTO colecaoPessoa = new ColecaoPessoaDTO();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("PessoaNome", PessoaNome);

                DataTable PessoaConsulta = acessoDadosSqlServer.ExecutaConsulta(CommandType.Text, String.Format("select * from Pessoa where Pess_Nome like '%{0}%'", PessoaNome));

                foreach (DataRow linha in PessoaConsulta.Rows)
                {
                    PessoaDTO pessoaDto = new PessoaDTO();

                    pessoaDto.Nome = Convert.ToString(linha["Pess_Nome"]);
                    pessoaDto.IdPessoa = Convert.ToInt32(linha["Pess_IdPessoa"]);

                    colecaoPessoa.Add(pessoaDto);

                }

                return colecaoPessoa;
            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel consultar o Banco com os parâmetros informados. Verifique se há bancos cadastrados com esses parâmetros!");
            }

        }

        public ColecaoPessoaDTO ConsultarPessoaPorId(string pessoaId)
                {

            try
            {
                ColecaoPessoaDTO colecaoPessoa = new ColecaoPessoaDTO();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("PessoaId", pessoaId);

                DataTable PessoaConsulta = acessoDadosSqlServer.ExecutaConsulta(CommandType.Text, String.Format("select * from Pessoa where Pess_IdPessoa like '%{0}%'", pessoaId));

                foreach (DataRow linha in PessoaConsulta.Rows)
                {
                    PessoaDTO pessoaDto = new PessoaDTO();

                    pessoaDto.Nome = Convert.ToString(linha["Pess_Nome"]);
                    pessoaDto.IdPessoa = Convert.ToInt32(linha["Pess_IdPessoa"]);

                    colecaoPessoa.Add(pessoaDto);

                }

                return colecaoPessoa;
            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel consultar o Banco com os parâmetros informados. Verifique se há bancos cadastrados com esses parâmetros!");
            }
        }

        public PessoaDTO consultarPessoaPorIdV2(int PessoaId)
        {

            try
            {
                PessoaDTO pessoaDTO = new PessoaDTO();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("PessoaId", PessoaId);

                DataTable PessoaConsulta = acessoDadosSqlServer.ExecutaConsulta(CommandType.Text, String.Format("select * from Pessoa where Pess_IdPessoa like '%{0}%'", PessoaId));

                foreach (DataRow linha in PessoaConsulta.Rows)
                {
                    PessoaDTO pessoaDto = new PessoaDTO();

                    pessoaDto.Nome = Convert.ToString(linha["Pess_Nome"]);
                    pessoaDto.IdPessoa = Convert.ToInt32(linha["Pess_IdPessoa"]);

                }

                return pessoaDTO;
            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel consultar o Banco com os parâmetros informados. Verifique se há bancos cadastrados com esses parâmetros!");
            }

        }

    }



}

