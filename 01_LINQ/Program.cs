using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ E LAMBDA
            //LAMBDA = (ENTRADA) => (EXPRESSÃO)
            List<string> nomeLista = new List<string>() { "João", "Luana", "Alana", "Zoraide", "Kaká", "Cora", "Érica", "Matheus" };

            int[] lista = { 3, 4, 5, 6, 10, 20, 30, 40, 50, 100, 25, 35, 74 };

            var vetorListaOrdenada = lista.Where(a => a > 10).OrderBy(a => a).Select(a => a);

            var nomeListaOrdenada = nomeLista.OrderBy(x => x).Select(x => x);

            
            foreach (var listaNomes in nomeListaOrdenada)
            {
                Console.WriteLine(listaNomes);

            }

            Console.WriteLine();

            foreach (int vetorLista in vetorListaOrdenada)
            {
                Console.WriteLine(vetorLista);
            }

            
            Console.ReadKey();

        }
    }
}
