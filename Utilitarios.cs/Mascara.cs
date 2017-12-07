using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilitarios
{
    public static class Mascara
    {
        public static string TextNoFormatting(this MaskedTextBox _mask)
        {
            _mask.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            String retString = _mask.Text;
            _mask.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            return retString;
        }
    }

}
