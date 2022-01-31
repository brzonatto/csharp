using ByteBankImportacaoExportacao.Modelos;
using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void UsandoStreamReader()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();

                    var contaCorrente = ConverterStringParaContaCorrente(linha);

                    Console.WriteLine($"Número: {contaCorrente.Numero} | Agência: {contaCorrente.Agencia} | Saldo: R${contaCorrente.Saldo} | Titular: {contaCorrente.Titular.Nome}");

                    // Console.WriteLine(linha);
                }
            }
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            var campos = linha.Split(',');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nome = campos[3];

            var titular = new Cliente();
            titular.Nome = nome;

            var resultado = new ContaCorrente(int.Parse(numero), int.Parse(agencia));
            resultado.Depositar(double.Parse(saldo));
            resultado.Titular = titular;

            return resultado;
        }
    }
}