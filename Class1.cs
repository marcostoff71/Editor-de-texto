using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_editator_de_texto_forms
{
    class CValida
    {

        public bool Valida(string num)
        {
            bool valor;
            int n;
            valor = int.TryParse(num, out n);

            return valor;
        }
    }
}
