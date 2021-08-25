using System;
using System.Collections.Generic;

namespace BancoFuncional
{
    class Program
    {
        static List<Contas> novaContas = new List<Contas>();
        static void Main(string[] args)
        {
            string telaUsuario = ObterOpcaoUsuario();
            while (telaUsuario.ToUpper() != "X")
            {
                switch (telaUsuario)
                {
                    case "1":
                        InserirConta();
                        break;
                    case "2":
                        Sacar();
                        break;
                    case "3":
                        Depositar();
                        break;
                    case "L":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentException();

                }
                telaUsuario = ObterOpcaoUsuario();
            }

        }

        private static void InserirConta()
        {
            Console.WriteLine("Digite o seu Nome:");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o saldo incial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());


            Contas novasContas = new Contas(saldo: entradaSaldo, nome: entradaNome);

            novaContas.Add(novasContas);

        }
        private static void Sacar()
        {
            Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            novaContas[indiceConta].Sacar(valorSaque);

        }
        private static void Depositar()
        {
            Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            novaContas[indiceConta].Depositar(valorDeposito);

        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();

            Console.WriteLine("1- Inserir nova conta");
            Console.WriteLine("2- Sacar");
            Console.WriteLine("3- Depositar");
            Console.WriteLine("L- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }
}
