using System;

namespace aula10ATVD_0903
{
    public class Conta
    {
        
        public string Nome { get; set; }

        public int Numero { get; set; }

        public double Saldo { get; set; }
        public Conta(string nome, int numero, double saldo)
        {
            Nome = nome;
            Numero = numero;
            Saldo = saldo;

        }
        public void Depositar(double valor) //método DEPOSITAR
        {
            if(valor>0)
            {
                Saldo += valor; 
                SaldoAtual(); 
            }
            else
            {
                Console.WriteLine("Depósito inválido.");
            }
        }

        public void Sacar(double valor) //método SACAR 
        {
            if(valor<Saldo)
            {
                Saldo -= valor; 
                SaldoAtual();
            }
            else
            {
                Console.WriteLine("Seu saldo é insuficiente.");
            }
        }

        public void SaldoAtual() //método SALDO_ATUAL
        {
            Console.WriteLine("Seu saldo atual é de: R$ " + Saldo);
        }

        public double Transferir(double mandar, double receber) //método TRANSFERIR
        {
            double valor;
            valor = double.Parse(Console.ReadLine());

            mandar -= valor;
            Saldo = mandar;
            receber += valor;
            return receber;  
        }

    }
}