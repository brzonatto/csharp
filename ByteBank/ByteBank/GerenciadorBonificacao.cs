using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificaco;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificaco += funcionario.GetBonificacao();
        }        

        public double GetTotalBonificacao()
        {
            return _totalBonificaco;
        }
    }
}
