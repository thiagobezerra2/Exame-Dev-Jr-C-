using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankfuncional
{
    public class Conta
    {
        public string titular;
        public int agencia;
        public int conta; 
        public double saldo;

        //Função Sacar 
        public bool Sacar(double valorSaque)
        {
            if (this.saldo >= valorSaque)
            {
                this.saldo -= valorSaque;
                Console.WriteLine("Saque realizado com sucesso.");
                Console.WriteLine("O saldo atualda da conta é de {0}", this.saldo);
                return true;
            }
            else
            {
                Console.WriteLine("Função não permitida, saldo insuficiente");
                return false;
            }

        }

        //FUNÇÃO DEPOSITAR (SEM RETORNO)
        public void Depositar(double valorDeposito)
        {
            Console.WriteLine("Depósito realizado com Sucesso.");
            this.saldo -= valorDeposito;
        }
           

    }


}