using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4
{
    class ClaseSuma
    {
        string valor1;
        string valor2;


        public ClaseSuma (string pvalor1 , string pvalor2)
        {
            this.valor1 = pvalor1;
            this.valor2 = pvalor2;

        }


        public string sumar()
        {
            int resultado = Convert.ToInt32(valor1) + Convert.ToInt32(valor2);
            return Convert.ToString(resultado);

        }
    }
}
