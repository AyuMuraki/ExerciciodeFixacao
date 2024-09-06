using ExerciciodeFixacao;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite seu nome Completo: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?: ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre o valor de depósito inicial:");
                double depositoInicial = double.Parse(Console.ReadLine());

                conta = new ContaBancaria(numero, titular, depositoInicial);
            }

            else
            {

                conta = new ContaBancaria(numero, titular);
            }


            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);


            Console.WriteLine("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados da conta atualizados: ");
            conta.Deposito(quantia);
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);





        }
    }
}
