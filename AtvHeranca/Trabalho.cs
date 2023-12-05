using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvHeranca
{
    internal class Trabalho : Veiculo
    {
        public double capPeso { get; set; }
        public int quantEixos { get; set; }

        public override double desconto()
        {
            return valor - 5000;
        }
    }
}
