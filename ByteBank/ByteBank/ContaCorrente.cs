using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Cliente { get; set; }
        public int Numero { get; set; }
        public static int QuantidadeDeContas { get; private set; }

        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        }

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
            Numero = numero;
            Agencia = agencia;

            QuantidadeDeContas++;
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(int valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            Sacar(valor);
            contaDestino.Depositar(valor);
            return true;
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
