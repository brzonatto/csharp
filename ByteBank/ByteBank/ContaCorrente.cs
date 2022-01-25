using ByteBank.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; set; }
        public Cliente Cliente { get; set; }
        public int Numero { get; }
        public static int QuantidadeDeContas { get; private set; }
        public int Agencia { get; }
        public int CountSaquesNaoPermitidos { get; private set; }
        public int CountTransferenciasNaoPermitidas { get; private set; }

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public ContaCorrente(int numero, int agencia)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("A agência deve ser maior que ZERO.", nameof(agencia));                 
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O número deve ser maior que ZERO.", nameof(numero));
            }            

            Numero = numero;
            Agencia = agencia;

            QuantidadeDeContas++;
            TaxaOperacao = 30 / QuantidadeDeContas; 
        }

        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor do saque deve se maior que ZERO.", nameof(valor));
            }

            if (_saldo < valor)
            {
                CountSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor); 
            }
            _saldo -= valor;           
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(int valor, ContaCorrente contaDestino)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor da trânsferencia deve se maior que ZERO.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException e)
            {
                CountTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", e);
            }
            
            contaDestino.Depositar(valor);            
        }

        public string ImprimeConta()
        {
            return $"Nome: {Cliente.Nome} | CPF: {Cliente.Cpf} | Profissão: {Cliente.Profissao}\n" +
                $"Agência: {Agencia}\n" +
                $"Número: {Numero}\n" +
                $"Saldo: R${_saldo}\n";
        }
    }
}
