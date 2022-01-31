using ByteBank.Funcionarios;
using ByteBank.SistemaAgencia.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    public class Program
    {
        static void Main(string[] args)
        {
            var contasOrdenadas = new List<ContaCorrente>();

            contasOrdenadas.AddMany(
                new ContaCorrente(5645648, 123),
                new ContaCorrente(6874512, 456),
                new ContaCorrente(2345878, 213),
                new ContaCorrente(1234587, 123),
                new ContaCorrente(9515615, 456),
                new ContaCorrente(3548971, 213),
                new ContaCorrente(2564871, 123),
                new ContaCorrente(8132487, 508),
                null
                );

            //contasOrdenadas.Sort();

            var ordena = contasOrdenadas.Where(cc => cc != null).OrderBy(cc => cc.Numero);

            foreach (var contaOrdenada in ordena)
                Console.WriteLine(contaOrdenada);

            //foreach (var contaOrdenada in contasOrdenadas)
            //    Console.WriteLine(contaOrdenada);
                

            var idades3 = new List<int>();

            idades3.Add(5);
            idades3.Add(45);
            idades3.Add(76);
            idades3.Add(12);
            idades3.Add(3);
            idades3.Add(19);
            idades3.Add(2);

            idades3.AddRange(new int[] {1, 2, 3, 4});

            idades3.AddMany(2, 88, 99, 33);

            var nomes = new List<string>();

            
            idades3.Sort();

            nomes.AddMany("Brunno", "Caroline", "Zenira", "Renata", "Ari", "Fabio");
            nomes.Sort();

            foreach (var item in idades3)
                Console.WriteLine(item);

            foreach (var item in nomes)
                Console.WriteLine(item);

            Console.WriteLine("\n\nDigite qualquer tecla para finalizar...");
            Console.ReadLine();

            /////////////////////

            Lista<int> idades2 = new Lista<int>();

            Console.WriteLine("\n\nDigite qualquer tecla para finalizar...");
            Console.ReadLine();

            /////////////////////////////////////////////////

            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.MeuMetodo(numero: 11);

            ContaCorrente conta2 = new ContaCorrente(55555, 555555555);

            lista.Adicionar(item: new ContaCorrente(1111, 11111111));
            lista.Adicionar(new ContaCorrente(874, 784811555));
            lista.Adicionar(new ContaCorrente(874, 515615616));
            lista.Adicionar(new ContaCorrente(874, 515615616));
            lista.Adicionar(conta2);
            lista.Adicionar(new ContaCorrente(874, 515615616));
            lista.Adicionar(new ContaCorrente(874, 515615616));
            lista.Adicionar(new ContaCorrente(874, 515615616));
            lista.Adicionar(new ContaCorrente(874, 515615616));
            lista.Adicionar(new ContaCorrente(874, 515615616));
            lista.Adicionar(new ContaCorrente(874, 515615616));
            lista.Adicionar(new ContaCorrente(874, 515615616));
            lista.Adicionar(new ContaCorrente(874, 515615616));

            ContaCorrente[] contas3 = new ContaCorrente[]
            {
                new ContaCorrente(100, 40010),
                new ContaCorrente(101, 40011),
                new ContaCorrente(102, 40012),
                new ContaCorrente(103, 40013)
            };
            lista.AdicionarVarios(contas3);

            lista.AdicionarVarios
            (
                new ContaCorrente(100, 40010),
                new ContaCorrente(101, 40011),
                new ContaCorrente(102, 40012),
                new ContaCorrente(103, 40013)
            );

            lista.Listar();

            lista.Remover(conta2);
            Console.WriteLine("Removido");
            lista.Listar();

            Console.WriteLine(lista[0]);

            Console.WriteLine("\n\nDigite qualquer tecla para finalizar...");
            Console.ReadLine();

            /////////////////////////////

            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(4565461, 8798),
                new ContaCorrente(6578745, 8798),
                new ContaCorrente(4788796, 8798)
            };

            for (int i = 0; i < contas.Length; i++)
            {
                if (contas[i] != null)
                    Console.WriteLine(contas[i]);
            }

            Console.WriteLine("\n\nDigite qualquer tecla para finalizar...");
            Console.ReadLine();

            /////////////////////////////

            int[] idades = null;
            idades = new int[5];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            int acumulador = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                acumulador += idades[i];
            }

            Console.WriteLine($"Idades total: {acumulador}");
            Console.WriteLine($"Media idades: {acumulador / idades.Length}");

            int idadeDoIndice4 = idades[4];

            //Console.WriteLine(idadeDoIndice4);

            Console.WriteLine("\n\nDigite qualquer tecla para finalizar...");
            Console.ReadLine();

            //////////////////////////////////

            Console.WriteLine("Olá, mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            object conta = new ContaCorrente(456, 8798);
            object diretor = new Diretor("Diretor", "02344978070");

            Console.WriteLine(conta);
            Console.WriteLine(diretor);

            Cliente carlos1 = new Cliente("Carlos", "123456789", "developer");
            Cliente carlos2 = new Cliente("Carlos", "123456789", "developer");

            if (carlos1.Equals(carlos2))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }

            Console.WriteLine("\n\nDigite qualquer tecla para finalizar...");
            Console.ReadLine();

            ///////////////////////////////

            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "Meu nome é Brunno, me ligue em 94784-4546";

            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));

            Match resultado = Regex.Match(textoDeTeste, padrao);
            Console.WriteLine(resultado.Value);


            Console.WriteLine("\n\nDigite qualquer tecla para finalizar...");
            Console.ReadLine();

            //string mensagemOrigem = "PALAVRA";
            //string termoBusca = "ra";

            //Console.WriteLine(termoBusca.ToUpper());

            //Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            //Console.WriteLine("\n\nDigite qualquer tecla para finalizar...");
            //Console.ReadLine();

            //DateTime dataFimPagamento = new DateTime(2022, 5, 29);
            //DateTime dataCorrente = DateTime.Now;

            //TimeSpan diferenca = TimeSpan.FromMinutes(60);

            //Console.WriteLine(dataFimPagamento);
            //Console.WriteLine(dataCorrente);
            //Console.WriteLine($"Vencimento em {TimeSpanHumanizeExtensions.Humanize(diferenca)}");

            ////////////////////////////

            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio/"));
            Console.WriteLine(urlTeste.Contains("byteBank"));


            Console.WriteLine("\n\nDigite qualquer tecla para finalizar...");
            Console.ReadLine();

            /////////////////////////////////

            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&Valor=1500";
            ExtratorValorArgumentos extrator = new ExtratorValorArgumentos(urlParametros);

            string valor = extrator.GetValor("moedaDestino");
            Console.WriteLine($"Valor de moedaDestino: {valor}");

            string valorMoedaOrigem = extrator.GetValor("moedaOrigem");
            Console.WriteLine($"Valor de moedaOrigem: {valorMoedaOrigem}");

            Console.WriteLine(extrator.GetValor("VALOR"));

            //string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            //int indiceInterrogação = url.IndexOf('?');


            //string moedaOrigem = url.Substring(url.IndexOf());

            //Console.WriteLine(indiceInterrogação);
            //Console.WriteLine(url);
            //string argumentos = url.Substring(indiceInterrogação + 1);
            //Console.WriteLine(argumentos);




            Console.WriteLine("\n\nDigite qualquer tecla para finalizar...");
            Console.ReadLine();
        }
    }
}
