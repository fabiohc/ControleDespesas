using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ObjetoDeTransferenciaDto
{
    public class ReceitaDto
    {
        public int IdReceita { get; set; }
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Origem { get; set; }
        public string Valor { get; set; }
        public string Tipo { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataHoraCadastro { get; set; }

    }
}
