using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoDeTransferenciaDto
{
    public class CreditoDTO
    {
        public int idPessoa { get; set; }
        public decimal valor { get; set; }
        public DateTime data { get; set; }
        public Boolean TipoCusto { get; set; }
        public DateTime dataHoracad { get; set; }

    }
}
