using Humanizer;
using System;

namespace ByteBank.SistemaAgencia
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2022, 5, 29);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromMinutes(60);

            Console.WriteLine(dataFimPagamento);
            Console.WriteLine(dataCorrente);
            Console.WriteLine($"Vencimento em {TimeSpanHumanizeExtensions.Humanize(diferenca)}");

            Console.WriteLine("\n\nDigite qualquer tecla para finalizar...");
            Console.ReadLine();
        }
    }
}
