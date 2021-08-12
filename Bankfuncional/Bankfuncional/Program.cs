using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Bankfuncional
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            string telaUsuario = opcaoUsuario();

            while(telaUsuario.ToUpper() != "X")
            {
                switch(telaUsuario)
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
                    case"L":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                telaUsuario = opcaoUsuario();
            }
            static void InserirConta()
            { 
                Console.WriteLine("Inserir nova conta");

                Console.Write("Digite o seu Nome: ");
                string entradaNome = Console.ReadLine();
                listContas.Add(novaConta);
                
            }
            static void Sacar()
            {
                Console.Write("Digite o número da conta: ");
                int indiceConta = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor a ser sacado: ");
                double valorSaque = double.Parse(Console.ReadLine());

           listContas[indiceConta].Sacar(valorSaque);
            }
            static void Depositar()
            {
                Console.Write("Digite o numero da conta");
                int indiceConta = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor a ser Depositado");
                double indiceConta = double.Parse(Console.ReadLine());

           listContas[indiceConta].Depositar(valorDeposito);
            }  
            static string opcaoUsuario()
            {
                Console.WriteLine();
                Console.WriteLine("Informe a opção desejada: ");

                Console.WriteLine("1- Inserir nova conta");
                Console.WriteLine("2- Sacar");
                Console.WriteLine("3- Depositar");
                Console.WriteLine("L-- Limpar a tela");
                Console.WriteLine("X- Sair");
                Console.WriteLine();

                string telaUsuario = Console.ReadLine().ToUpper();
                Console.WriteLine();
                return opcaoUsuario;
            }
        }
    }
}