using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string nome, string cpf) : base(nome, cpf, 2000)
        {
            Console.WriteLine("CRIANDO AUXILIAR");
        }
        public override void AumentarSalario()
        {
            Salario *= 1.10;
        }
        internal protected override double GetBonificacao()
        {
            return Salario * 0.20;
        }
    }
}
