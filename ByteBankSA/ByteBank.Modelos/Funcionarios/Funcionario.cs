using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalFuncionarios { get; private set; } 

        public Funcionario(string nome, string cpf, double salario)
        {
            TotalFuncionarios++;            
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
        }

        public abstract void AumentarSalario();

        internal protected abstract double GetBonificacao();
    }
}
