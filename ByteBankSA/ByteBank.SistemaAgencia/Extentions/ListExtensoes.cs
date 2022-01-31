using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extentions
{
    public static class ListExtensoes
    {
        public static void AddMany<T>(this List<T> listaDeInteiros, params T[] itens)
        {
            foreach (T item in itens)
                listaDeInteiros.Add(item);
        }
    }
}
