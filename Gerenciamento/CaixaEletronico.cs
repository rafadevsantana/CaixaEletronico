using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento
{
    class CaixaEletronico
    {
        private void QuantidadeContas(int quantidade)
        {
            foreach (int i in Cedulas)
            {
                int res = quantidade / i;
                Contas.Add(res + "cedulas de " + i);
                quantidade -= (res * i);
            }
            if (quantidade == 0)
            {
                Validade = true;
            }
        }

        internal void Saques(int v)
        {
            throw new NotImplementedException();
        }

        public List<int> Cedulas = new() { 100, 50, 20, 10, 5 };
        public List<string> Contas = new List<string>();
        public List<Saque> Saques {  get; set; } = new List<Saque>();

        public bool Validade = false;

        public CaixaEletronico(int quantidade)
        {
            if(quantidade == 0)
            {
                Console.WriteLine("Nao e Possivel sacar");
            }
            else
            {
                QuantidadeContas(quantidade);
                if (Validade)
                {
                    var retirada = Saque(DateTime.Now, quantidade);
                    Saques.Add((Saque)retirada);

                    foreach (string i in Contas)
                    {
                        Console.WriteLine(i + " saque efetuado com sucesso");
                    }
                }
                else
                {
                    Console.WriteLine("Saque Nao efetuado");
                }

            }
        }

        public CaixaEletronico()
        {
        }

        private object Saque(DateTime now, int quantidade)
        {
            throw new NotImplementedException();
        }

        public void Realizado()
        {
            foreach (Saque sa in Saques)
            {
                Console.WriteLine("saque realizado na hora" + sa.HoraSaque.Hour);
            }
        }
    }
}
