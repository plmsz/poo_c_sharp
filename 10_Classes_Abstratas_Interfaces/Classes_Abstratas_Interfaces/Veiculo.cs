using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Abstratas_Interfaces
{
    internal abstract class Veiculo: IMovimentacao //classe pode implementar várias interfaces
    {
        protected int Ano;
        public void Abastecer()
        {
            Console.WriteLine("Abastacendo veículo.");
        }

        public abstract void Estacionar(); //método tem que ser implementado obrigatório na classe filhas

        public void mover()
        {
            Console.WriteLine("Veiculo em movimento");
        }
    }
}
