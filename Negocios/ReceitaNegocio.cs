using System;
using System.Data;
using AcessoDados;
using ObjetoDeTransferenciaDto;
using ObjetodetransferenciaDto;
using System.Text;
using System.Runtime.InteropServices;

namespace Negocios
{
    public class ReceitaNegocio
    {
        DataTable retornoReceita;


        AcessoDadosSqlserver acessoDadosSqlServer = new AcessoDadosSqlserver();


        public string Inserir(ColecaoReceita colecaoReceita)
        {
            var SqlInsert = new StringBuilder();

            acessoDadosSqlServer.LimparParametros();

            for (int i = 0; i < colecaoReceita.Count; i++)

                SqlInsert.AppendLine("Insert into Receita(")
                      .AppendLine("Rec_IdPessoa,Rec_Origem,Rec_Valor,")
                      .AppendLine("Rec_Tipo,Rec_Data,Rec_DataHoraCadastro)")
                      .AppendLine(" values (")
                      .AppendFormat("{0},", colecaoReceita[i].IdPessoa)
                      .AppendFormat("'{0}',", colecaoReceita[i].Origem)
                      .AppendFormat("'{0}',", colecaoReceita[i].Valor)
                      .AppendFormat("'{0}',", colecaoReceita[i].Tipo)
                      .AppendFormat("'{0}',", colecaoReceita[i].Data.ToShortDateString())
                      .AppendFormat("'{0}')", colecaoReceita[i].DataHoraCadastro);

            string retorno = acessoDadosSqlServer.ExecutaManipulacao(CommandType.Text, SqlInsert.ToString()).ToString();

            return retorno;
        }
        public void Alterar(ColecaoReceita colecaoReceita)
        {
            var SqlAlteracao = new StringBuilder();

            acessoDadosSqlServer.LimparParametros();

            for (int i = 0; i < colecaoReceita.Count; i++)

                SqlAlteracao.AppendLine("UPDATE Receita");
            //  SET[Rec_IdPessoa] = < Rec_IdPessoa, decimal(9, 0),>
            //     ,[Rec_Origem] = <Rec_Origem, varchar(50),>
            //     ,[Rec_Valor] = <Rec_Valor, varchar(12),>
            //     ,[Rec_Tipo] = <Rec_Tipo, varchar(50),>
            //     ,[Rec_Data] = <Rec_Data, date,>
            //     ,[Rec_DataHoraCadastro] = <Rec_DataHoraCadastro, datetime,>
            //WHERE<Critérios de Pesquisa,,>

        }
        public string Excluir(ReceitaDto receitaDto)
        {
            var SqlExcluir = new StringBuilder();

            acessoDadosSqlServer.LimparParametros();

            SqlExcluir.AppendLine("Delete from receita")
                .AppendFormat(" where Rec_IdReceita = {0}", receitaDto.IdReceita)
                .AppendFormat(" and Rec_IdPessoa = {0}", receitaDto.IdPessoa);

            string retorno = acessoDadosSqlServer.ExecutaManipulacao(CommandType.Text, SqlExcluir.ToString()).ToString();

            return retorno;

        }
        public ColecaoReceita ConsultarPessoaPorId(string pessoaId,
                                                    DateTime dataInicio,
                                                    DateTime dataFim,
                                                    string origem,
                                                    string tipo)
        {
            try
            {
                ColecaoReceita colecaoReceita = new ColecaoReceita();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("IdPessoa", pessoaId);
                acessoDadosSqlServer.AdicionarParametros("dataInicio", dataInicio.ToShortDateString());
                acessoDadosSqlServer.AdicionarParametros("dataFim", dataFim.ToShortDateString());
                acessoDadosSqlServer.AdicionarParametros("origem", origem);
                acessoDadosSqlServer.AdicionarParametros("Tipo", tipo);

                var Sql = new StringBuilder();

                Sql.AppendLine("Select rec_IdReceita, rec_IdPessoa, Pess_Nome, Rec_Origem, Rec_Valor,Rec_Tipo,Rec_Data")
                .AppendFormat(" from pessoa p, Receita r where pess_IdPessoa = {0} ", pessoaId)
                .AppendLine(" and p.pess_IdPessoa = r.Rec_IdPessoa")
                .AppendFormat(" and Rec_Data >= '{0}'", dataInicio.ToString("yyyy-MM-dd"))
                .AppendFormat(" and Rec_Data <= '{0}'", dataFim.ToString("yyyy-MM-dd"))
                .AppendFormat(" and rec_Tipo = '{0}'", tipo)
                .AppendFormat(" and rec_Origem = '{0}'", origem).ToString();

                retornoReceita = acessoDadosSqlServer.ExecutaConsulta(CommandType.Text, Sql.ToString());


                foreach (DataRow linha in retornoReceita.Rows)
                {
                    ReceitaDto receitaDto = new ReceitaDto();

                    receitaDto.IdReceita = Convert.ToInt32(linha["Rec_IdReceita"]);
                    receitaDto.IdPessoa = Convert.ToInt32(linha["Rec_IdPessoa"]);
                    receitaDto.Nome = Convert.ToString(linha["Pess_Nome"]);
                    receitaDto.Origem = Convert.ToString(linha["Rec_Origem"]);
                    receitaDto.Valor = Convert.ToString(linha["Rec_Valor"]);
                    receitaDto.Tipo = Convert.ToString(linha["Rec_Tipo"]);
                    receitaDto.Data = Convert.ToDateTime(linha["Rec_Data"]);
                    // receitaDto.DataHoraCadastro = Convert.ToDateTime(linha["Rec_DataHoraCadastro"]);


                    colecaoReceita.Add(receitaDto);

                }

                return colecaoReceita;
            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel consultar o Banco com os parâmetros informados. Verifique se há bancos cadastrados com esses parâmetros!");
            }

        }
        public ColecaoReceita ConsultarPessoaColetivo(DateTime dataInicio,
                                              DateTime dataFim,
                                                [Optional] string origem,
                                                [Optional] string tipo)
        {
            try
            {
                ColecaoReceita colecaoReceita = new ColecaoReceita();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("dataInicio", dataInicio.ToShortDateString());
                acessoDadosSqlServer.AdicionarParametros("dataFim", dataFim.ToShortDateString());
                acessoDadosSqlServer.AdicionarParametros("origem", origem);
                acessoDadosSqlServer.AdicionarParametros("Tipo", tipo);

                var Sql = new StringBuilder();

                Sql.AppendLine("Select rec_IdReceita, rec_IdPessoa, Pess_Nome, Rec_Origem, Rec_Valor,Rec_Tipo,Rec_Data")
                .AppendFormat(" from pessoa p, Receita r where")
                .AppendLine(" p.pess_IdPessoa = r.Rec_IdPessoa")
                .AppendFormat(" and Rec_Data >= '{0}'", dataInicio.ToString("yyyy-MM-dd"))
                .AppendFormat(" and Rec_Data <= '{0}'", dataFim.ToString("yyyy-MM-dd"));
                
               if (!string.IsNullOrEmpty(tipo)) {
                    Sql.AppendFormat(" and rec_Tipo = '{0}'", tipo);
                }

                if (!string.IsNullOrEmpty(origem))
                {
                    Sql.AppendFormat(" and Rec_Origem = '{0}'", origem).ToString();
                }
                retornoReceita = acessoDadosSqlServer.ExecutaConsulta(CommandType.Text, Sql.ToString());

                foreach (DataRow linha in retornoReceita.Rows)
                {
                    ReceitaDto receitaDto = new ReceitaDto();

                    receitaDto.IdReceita = Convert.ToInt32(linha["Rec_IdReceita"]);
                    receitaDto.IdPessoa = Convert.ToInt32(linha["Rec_IdPessoa"]);
                    receitaDto.Nome = Convert.ToString(linha["Pess_Nome"]);
                    receitaDto.Origem = Convert.ToString(linha["Rec_Origem"]);
                    receitaDto.Valor = Convert.ToString(linha["Rec_Valor"]);
                    receitaDto.Tipo = Convert.ToString(linha["Rec_Tipo"]);
                    receitaDto.Data = Convert.ToDateTime(linha["Rec_Data"]);
                    // receitaDto.DataHoraCadastro = Convert.ToDateTime(linha["Rec_DataHoraCadastro"]);

                    colecaoReceita.Add(receitaDto);
                }

                return colecaoReceita;
            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel consultar o Banco com os parâmetros informados. Verifique se há bancos cadastrados com esses parâmetros!");
            }

        }
    }
}
