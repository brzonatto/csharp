using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Exceptions
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsuficienteException()
        {
        }
        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this($"Tentativa de saque no valor de {valorSaque}")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInsuficienteException(string message) 
            : base(message)
        {
        }
        public SaldoInsuficienteException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
