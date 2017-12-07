using System;
using System.Data;
using AcessoDados;
using ObjetoDeTransferenciaDto;
using System.Text;
using System.Runtime.InteropServices;

namespace Negocios
{
    public class DespesaNegocio
    {
        AcessoDadosSqlserver acessoDadosSqlServer = new AcessoDadosSqlserver();

        conexao conn = new conexao();

        public void Inserir(ColecaoDespesaDto colecaoDespesaDto)
        {
            conn.abreConexao();

            for (int i = 0; i < colecaoDespesaDto.Count; i++)
            {
                conn.executeQuery(string.Format("INSERT INTO Despesa (Des_IdPessoa,Des_Nome,Des_Tipo,Des_Valor," +
                                                                    "Des_Vencimento,Des_Pago,Des_Parcelado," +
                                                                    "Des_QuantParcela,Des_Descricao,Des_DataHoraCadastro) " +
                                                                    "VALUES ({0},'{1}','{2}','{3}','{4}',{5},{6},{7},'{8}','{9}')",
                                                                     colecaoDespesaDto[i].IdPessoa,
                                                                     colecaoDespesaDto[i].Nome,
                                                                     colecaoDespesaDto[i].Tipo,
                                                                     colecaoDespesaDto[i].Valor,
                                                                     colecaoDespesaDto[i].Vencimento.Date.ToShortDateString(),
                                                                     colecaoDespesaDto[i].Pago,
                                                                     colecaoDespesaDto[i].Parcelado,
                                                                     colecaoDespesaDto[i].QuantParcela,
                                                                     colecaoDespesaDto[i].Descricao,
                                                                     colecaoDespesaDto[i].DataHoraCadastro));
            }

            conn.close();
        }

        public void Alterar(ColecaoDespesaDto colecaoDespesaDto)
        {
            var SqlAlteracao = new StringBuilder();

            acessoDadosSqlServer.LimparParametros();

            for (int i = 0; i < colecaoDespesaDto.Count; i++)
            {
                SqlAlteracao.AppendLine("UPDATE Despesa");
                SqlAlteracao.AppendLine(" SET ");
                //SqlAlteracao.AppendFormat(" Des_Tipo = '{0}'", colecaoDespesaDto[i].Tipo);
                //SqlAlteracao.AppendFormat(" Des_Valor = '{0}'", colecaoDespesaDto[i].Valor);
                //SqlAlteracao.AppendFormat(" Des_Vencimento = '{0}'", colecaoDespesaDto[i].Vencimento);
                SqlAlteracao.AppendFormat(" Des_Pago = '{0}'", colecaoDespesaDto[i].Pago);
                //SqlAlteracao.AppendFormat(" Des_Parcelado = '{0}' ", colecaoDespesaDto[i].Parcelado);
                //SqlAlteracao.AppendFormat(" Des_QuantParcela = '{0}' ", colecaoDespesaDto[i].QuantParcela);
                //SqlAlteracao.AppendFormat(" Des_Descricao = '{0}' ", colecaoDespesaDto[i].Descricao);
                SqlAlteracao.AppendFormat(" WHERE Des_idDespesa  = {0} and Des_idPessoa  = {1}", colecaoDespesaDto[i].IdDespesa, colecaoDespesaDto[i].IdPessoa);

                acessoDadosSqlServer.ExecutaManipulacao(CommandType.Text, SqlAlteracao.ToString()).ToString();
            }
        }

        public ColecaoReceita ConsultarPessoaPorId(string pessoaId)
        {
            try
            {
                ColecaoReceita colecaoReceita = new ColecaoReceita();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("IdPessoa", pessoaId);

                DataTable retornoReceita = acessoDadosSqlServer.ExecutaConsulta(CommandType.Text, String.Format("Select rec_IdPessoa, Pess_Nome, Rec_Origem, Rec_Valor,Rec_Tipo,Rec_Data from pessoa p, Receita r where pess_IdPessoa = {0} and p.pess_IdPessoa = r.Rec_IdPessoa", pessoaId));

                foreach (DataRow linha in retornoReceita.Rows)
                {
                    ReceitaDto receitaDto = new ReceitaDto();

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

        public ColecaoDespesaDto ConsultarDespesa([Optional] string idPessoa,
                                                    [Optional] string Tipo,
                                                    [Optional] DateTime DataVencimento,
                                                    [Optional] Byte parcelado)

        {
            try
            {
                ColecaoDespesaDto colecaoDespesaDto = new ColecaoDespesaDto();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("idPessoa", idPessoa);
                acessoDadosSqlServer.AdicionarParametros("Tipo", Tipo);
                acessoDadosSqlServer.AdicionarParametros("DataVencimento", DataVencimento);
                acessoDadosSqlServer.AdicionarParametros("parcelado", parcelado);

                var SqlSelect = new StringBuilder();

                SqlSelect.AppendLine("Select * from Despesa where ");

                if (!string.IsNullOrEmpty(idPessoa))
                    SqlSelect.AppendFormat(" Des_IdPessoa = {0}", idPessoa);

                if (!string.IsNullOrEmpty(Tipo))

                    if (!string.IsNullOrEmpty(idPessoa))
                    {
                        SqlSelect.AppendFormat(" and Des_Tipo = '{0}'", Tipo);
                    }
                    else
                    {
                        SqlSelect.AppendFormat(" Des_Tipo = '{0}'", Tipo);
                    }

                if (DataVencimento != null)

                    if (!string.IsNullOrEmpty(idPessoa) || (!string.IsNullOrEmpty(Tipo)))
                    {
                        SqlSelect.AppendFormat(" and Des_Vencimento = '{0}'", DataVencimento.Date.ToShortDateString());
                    }
                    else
                    {
                        SqlSelect.AppendFormat(" Des_Vencimento = '{0}'", DataVencimento.Date.ToShortDateString());
                    }

                if (parcelado != 0)

                    if (!string.IsNullOrEmpty(idPessoa))
                    {
                        SqlSelect.AppendFormat(" and Des_Parcelado = {0}", parcelado);
                    }
                    else
                    {
                        SqlSelect.AppendFormat(" Des_Parcelado = {0}", parcelado);
                    }

                DataTable retornoDespesa = acessoDadosSqlServer.ExecutaConsulta(CommandType.Text, SqlSelect.ToString());

                foreach (DataRow linha in retornoDespesa.Rows)
                {
                    DespesaDto despesaDto = new DespesaDto();

                    despesaDto.IdDespesa = Convert.ToInt32(linha["Des_IdDespesa"]);
                    despesaDto.IdPessoa = Convert.ToInt32(linha["Des_IdPessoa"]);
                    despesaDto.Nome = Convert.ToString(linha["Des_Nome"]);
                    despesaDto.Tipo = Convert.ToString(linha["Des_Tipo"]);
                    despesaDto.Valor = Convert.ToDecimal(linha["Des_Valor"]);
                    despesaDto.Vencimento = Convert.ToDateTime(linha["Des_Vencimento"]);
                    despesaDto.Pago = Convert.ToByte(linha["Des_Pago"]);
                    despesaDto.Parcelado = Convert.ToByte(linha["Des_Parcelado"]);
                    despesaDto.QuantParcela = Convert.ToInt32(linha["Des_QuantParcela"]);
                    despesaDto.Descricao = Convert.ToString(linha["Des_Descricao"]);

                    colecaoDespesaDto.Add(despesaDto);
                }

                return colecaoDespesaDto;
            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel consultar o Banco com os parâmetros informados. Verifique se há bancos cadastrados com esses parâmetros!");
            }

        }
        public ColecaoDespesaDto ConsultarDespesaV2(string idPessoa,
                                                    string Tipo,
                                                    Byte parcelado)
        {
            try
            {
                ColecaoDespesaDto colecaoDespesaDto = new ColecaoDespesaDto();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("idPessoa", idPessoa);
                acessoDadosSqlServer.AdicionarParametros("Tipo", Tipo);
                acessoDadosSqlServer.AdicionarParametros("parcelado", parcelado);

                var SqlSelect = new StringBuilder();

                SqlSelect.AppendLine("Select * from Despesa where ");

                if (!string.IsNullOrEmpty(idPessoa))
                    SqlSelect.AppendFormat(" Des_IdPessoa = {0}", idPessoa);

                if (!string.IsNullOrEmpty(Tipo))

                    if (!string.IsNullOrEmpty(idPessoa))
                    {
                        SqlSelect.AppendFormat(" and Des_Tipo = '{0}'", Tipo);
                    }
                    else
                    {
                        SqlSelect.AppendFormat(" Des_Tipo = '{0}'", Tipo);
                    }

                if (parcelado != 0)

                    if (!string.IsNullOrEmpty(idPessoa))
                    {
                        SqlSelect.AppendFormat(" and Des_Parcelado = {0}", parcelado);
                    }
                    else
                    {
                        SqlSelect.AppendFormat(" Des_Parcelado = {0}", parcelado);
                    }

                DataTable retornoDespesa = acessoDadosSqlServer.ExecutaConsulta(CommandType.Text, SqlSelect.ToString());

                foreach (DataRow linha in retornoDespesa.Rows)
                {
                    DespesaDto despesaDto = new DespesaDto();

                    despesaDto.IdDespesa = Convert.ToInt32(linha["Des_IdDespesa"]);
                    despesaDto.IdPessoa = Convert.ToInt32(linha["Des_IdPessoa"]);
                    despesaDto.Nome = Convert.ToString(linha["Des_Nome"]);
                    despesaDto.Tipo = Convert.ToString(linha["Des_Tipo"]);
                    despesaDto.Valor = Convert.ToDecimal(linha["Des_Valor"]);
                    despesaDto.Vencimento = Convert.ToDateTime(linha["Des_Vencimento"]);
                    despesaDto.Pago = Convert.ToByte(linha["Des_Pago"]);
                    despesaDto.Parcelado = Convert.ToByte(linha["Des_Parcelado"]);
                    despesaDto.QuantParcela = Convert.ToInt32(linha["Des_QuantParcela"]);
                    despesaDto.Descricao = Convert.ToString(linha["Des_Descricao"]);

                    colecaoDespesaDto.Add(despesaDto);
                }

                return colecaoDespesaDto;
            }
            catch (Exception)
            {

                throw new Exception("Não foi possivel consultar o Banco com os parâmetros informados. Verifique se há bancos cadastrados com esses parâmetros!");
            }

        }

    }
}



