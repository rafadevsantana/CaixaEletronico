using System;

namespace Gerenciamento
{
    class Program
    {
        static void Main(string[] args)
        {
            CaixaEletronico saque1 = new CaixaEletronico();
            saque1.Saques(1500);
        }
    }
}
