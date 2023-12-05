using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvHeranca
{
    internal class Veiculo
    {
        public string marca { get; set; }
        public double valor { get; set; }
        public string modelo { get; set; }

        public virtual double desconto()
        {
            return valor;
        }
    }
}
