using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Atividades_Robison_1
{
    internal class Caixa
    {
        ContaBancaria _concatbancaria = new ContaBancaria();



        public void ManipularConta()
        {
            int tipo;
            _concatbancaria.Deposito(1000);

            do
            {
                Console.WriteLine("Escolha umas das opções: ");
                Console.WriteLine("1 para saldo!");
                Console.WriteLine("2 para deposito!");
                Console.WriteLine("3 para saque!");
                Console.WriteLine("4 para titular!");
                Console.WriteLine("5 para numero da conta!");
                Console.WriteLine("0 para fechar!");
                Console.WriteLine();

                tipo = int.Parse(Console.ReadLine());
                double valor;



                if (tipo == 1)
                {
                    _concatbancaria.ObterSaldo();
                }
                else if (tipo == 2)
                {
                    Console.Write("Digite o valor do depósito: ");
                    valor = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    _concatbancaria.Deposito(valor);
                }
                else if (tipo == 3)
                {
                    Console.Write("Digite um valor para saque: ");
                    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    _concatbancaria.Saque(valor);
                }
                else if (tipo == 4)
                {
                    _concatbancaria.ObterTitula();

                }
                else if (tipo == 5)
                {
                    _concatbancaria.ObterConta();
                }
                Console.WriteLine();

            } while (tipo != 0);


        }



    }
}