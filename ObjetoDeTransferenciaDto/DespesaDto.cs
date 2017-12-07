using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoDeTransferenciaDto
{
    public class DespesaDto
    {
        public int IdDespesa { get; set; }
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public DateTime Vencimento { get; set; }
        public byte Pago { get; set; }
        public byte Parcelado { get; set; }
        public int QuantParcela { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHoraCadastro { get; set; }
    }
}
