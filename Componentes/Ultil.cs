using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ObjetoDeTransferenciaDto;

namespace Componentes
{
    public class Ultil
    {
        public static string adicionaMAscara(string mascara)
        {
            double valor = 0;

            if (mascara != null)
            {
                string numero = mascara.Replace(",", "").Replace(",", "");
                if (numero.Equals(""))
                    numero = "";
                numero = numero.PadLeft(3, '0');
                if (numero.Length > 3 & numero.Substring(0, 1) == "0")
                    numero = numero.Substring(1, numero.Length - 1);
                valor = Convert.ToDouble(numero) / 100;
            }
            mascara = string.Format("{0:N}", valor);
            return mascara; //mascara.SelectionStart = mascara.Length;

        }



        public static String tipofrete(int frete)
        {
            String menssagem = "";
            if (frete == 0) menssagem = "CIF - Frete a pago pelo fornecedor";
            if (frete == 1) menssagem = "Fob - frete a cargo do consumidor";
            return menssagem;
        }

       



    }

          
}
