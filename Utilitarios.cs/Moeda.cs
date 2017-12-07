using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios.cs
{
    public class Moeda
    {

        public void adicionaMascaraMoeda(ref string mascara)
        {
            double valor = 0;

            if (!string.IsNullOrEmpty(mascara))
            {
                string numero = Convert.ToString(mascara).Replace(",", "").Replace(",", "");

                if (numero.Equals(""))
                    numero = "";
                numero = numero.PadLeft(3, '0');

                if (numero.Length > 3 & numero.Substring(0, 1) == "0")
                    numero = numero.Substring(1, numero.Length - 1);
                valor = Convert.ToDouble(numero) / 100;

            }
            if (valor == 0)
                mascara = null;
            else
                mascara = string.Format("{0:N}", valor);
        }
    }
}

