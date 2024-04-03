using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades_Robison_1
{
    public class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }



        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia;
        }

        public void ObterSaldo()
        {
            Console.WriteLine($"Saldo: {Saldo}");
        }

        public void ObterTitula()
        {
            Console.WriteLine($"Nome: {Titular}");
        }
        public void ObterConta()
        {
            Console.WriteLine($"Numero da conta: {Numero}");
        }

    }
}