using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Heranca
{
    internal class Pessoa
    {
        protected string email;
        protected string telefone;

        public void PagarImpostos()
        {
            Console.WriteLine("Pagando impostos");
        }
    }
}
