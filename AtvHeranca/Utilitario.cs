using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvHeranca
{
    internal class Utilitario : Veiculo
    {
        public int quantLugares { get; set; }
        public string cor { get; set; }

        public override double desconto()
        {
            return valor - 1000;
        }
    }
}
