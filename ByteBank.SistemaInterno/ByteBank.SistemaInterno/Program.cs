using System;

namespace ByteBank.SistemaInterno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc1 = new ContaCorrente(458, 455789);            

            Console.WriteLine(cc1.Saldo);

            cc1.Sacar(50);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
