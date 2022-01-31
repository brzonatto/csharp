using ByteBank.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    /// <summary>
    /// Define uma Conta Corrente do banco ByteBank.
    /// </summary>
    public class ContaCorrente : IComparable
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

        /// <summary>
        /// Cria uma instância com os argumentos utilizados.
        /// </summary>
        /// <param name="numero"> Representa o valor da propriedade <see cref="Numero"/> e deve possuir um valor maior que <b><u>ZERO</u></b>. </param>
        /// <param name="agencia"> Representa o valor da propriedade <see cref="Agencia"/> e deve possuir um valor maior que <b><u>ZERO</u></b>. </param>
        /// <exception cref="ArgumentException"></exception>
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

        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Saldo"/>
        /// </summary>
        /// <param name="valor"> Representa o valor do saque, deve ser maior que ZERO e menor ou igual ao <see cref="Saldo"/>. </param>
        /// <exception cref="ArgumentException"> Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="valor"/>. </exception>
        /// <exception cref="SaldoInsuficienteException">  Exceção lançada quando o valor de <paramref name="valor"/> é maior que o valor da propriedade <see cref="Saldo"/>. </exception>
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

        public override bool Equals(object obj)
        {
            ContaCorrente outraConta = obj as ContaCorrente;

            if (outraConta == null)
                return false;

            if (Numero == outraConta.Numero && Agencia == outraConta.Agencia)
                return true;

            return false;
        }

        public string ImprimeConta()
        {
            return $"Nome: {Cliente.Nome} | CPF: {Cliente.Cpf} | Profissão: {Cliente.Profissao}\n" +
                $"Agência: {Agencia}\n" +
                $"Número: {Numero}\n" +
                $"Saldo: R${_saldo}\n";
        }

        public override string ToString()
        {
            return $"Agência: {Agencia}\n" +
                   $"Número: {Numero}\n" +
                   $"Saldo: R${Saldo}\n";
        }

        public int CompareTo(object obj)
        {
            var outraConta = obj as ContaCorrente;

            if (Numero < outraConta.Numero || outraConta == null)
                return -1;
            if (Numero == outraConta.Numero)
                return 0;
            
            return 1;
        }
    }
}
