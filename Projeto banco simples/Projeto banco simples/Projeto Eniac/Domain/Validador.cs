using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Eniac.Domain
{
    public class Validador
    {
        public bool ValidadorAgencia(string agencia) 
        {
            if (!string.IsNullOrWhiteSpace(agencia) && agencia.Length == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
        
        public bool ValidadorNumero(string Numero) 
        {
            if (!string.IsNullOrWhiteSpace(Numero) && Numero.Length == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
