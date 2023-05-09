using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Eniac.Domain
{
    public class Calculo
    {
        public decimal Retirada(decimal NaConta, decimal subtracao)
        {
            decimal Total;

            Total = NaConta - subtracao;

            return Convert.ToDecimal(Total);
        }
    }
}
