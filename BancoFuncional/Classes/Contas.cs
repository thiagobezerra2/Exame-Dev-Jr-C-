using System;

namespace BancoFuncional
{
    public class Contas
    {
        private string Nome { get; set; }
        private double Saldo { get; set; }


        public Contas(string nome, double saldo)
        {
            this.Nome = nome;
            this.Saldo = saldo;

        }
        //Validação do Saldo
        public bool Sacar(double valorSaque)
        {
            if (this.Saldo - valorSaque < (this.Saldo * -1))
            {
                Console.WriteLine("Saldo insuficinte");
                return false;
            }
            this.Saldo -= valorSaque;
            Console.WriteLine("Saldo atual da sua conta é de {0}", this.Saldo);
            return true;

        }
        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine("Depósito de {0} realziado com sucesso", valorDeposito);
        }
        public override string ToString()
        {
            string retorno = " ";
            retorno += "Nome" + this.Nome + " | ";
            retorno += " Saldo" + this.Saldo + " | ";
            return retorno;
        }
    }
}