using System;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorArgumentos
    {
        private readonly string _argumentos;
        public string Url { get; }

        public ExtratorValorArgumentos(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException($"O argumento não pode ser nulo ou vazio. {nameof(url)}");
            }            

            int indiceInterrogação = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogação + 1);

            Url = url;
        }

        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper();
            string argumentoEmCaixaAlta = _argumentos.ToUpper();

            string termo = nomeParametro + "=";
            int indiceTermo = argumentoEmCaixaAlta.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1)
                return resultado;

            return resultado.Remove(indiceEComercial);
        }
    }
}
