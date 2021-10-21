using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento
{
    public class Saque
    {
        public DateTime HoraSaque { get; set; }
        public int ValorSaque { get; set; }

        public Saque(DateTime horasaque, int valorSaque)
        {
            HoraSaque = horasaque;
            ValorSaque = valorSaque;
        }

    }
}
}
