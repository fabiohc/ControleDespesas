using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilitarios
{
    public class ValidaDados
    {
        public bool ExisteTextBoxVazio(Control root, string mensagem)
        {
            if (string.IsNullOrEmpty(root.Text))            {

                MessageBox.Show(mensagem, "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return true;
            }
            return false;
        }

//        public void SoNumeros(short Keyascii)
//        {
//            If ("1234567890", Convert.ToChar(Keyascii)) = 0     ;
//               SoNumeros = 0
//     Else
//        SoNumeros = Keyascii
//      End If


//     Select Case Keyascii
//        Case 8
//        SoNumeros = Keyascii
//        Case 13
//        SoNumeros = Keyascii
//        Case 32
//        SoNumeros = Keyascii
//        End Select
//}

    }
}
