using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio02
{
    internal class Banco
    {
        //taxa de 5 reais para saque

        private string _nomeConta { get; set; }
        public int _numeroConta { get; private set; }
        public double _saldo { get; private set; }


        public Banco(string nomeConta, int numeroConta)
        {
            _nomeConta = nomeConta;
            _numeroConta = numeroConta;
        }
        public Banco(string nomeConta, int numeroConta, double saldoInicial) : this(nomeConta, numeroConta)
        {
            Deposito(saldoInicial);
        }       

        public void Deposito(double dep)
        {
            _saldo += dep;
        }
        public void Saque(double saq)
        {
            _saldo -= 5 + saq;
        }

        public override string ToString()
        {
            return $"Dados da Conta:\nConta: {_numeroConta}, Titular: {_nomeConta}, Saldo: R${_saldo}";
        }
    }
}