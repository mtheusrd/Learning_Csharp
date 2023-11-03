using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Como_criar_um_excecao
{
    public class NumeroNegativoException: Exception
    {
        public NumeroNegativoException(int numero) : base("Número "+ numero+ " não é positivo")
        {   

            throw new NumeroNegativoException(-10);
        }
    }
}
