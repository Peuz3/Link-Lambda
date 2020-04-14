using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LINQ_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista e Vetores
            List<string> listaNomes = new List<string>() { "João", "Beta", "João","Rafa", "Rafa", "Rafa", "Rafa" };

            double[] notasAtendimento = { 4.5, 5.0, 4.5, 3.9, 4.5, 1.0, 2.0, 4.5, 1.2, 1.2, 1.2 };

            int[] vetorNumeros = { 1, 1, 1, 1, 4, 4, 2, 3, 5, 6, 6, 10, 9, 8 };

            //Filtros
            var vetorFiltradoDistinct = vetorNumeros.Distinct().OrderBy(x=>x);

            var vetorFiltradoGroupBy = vetorNumeros.OrderBy(x => x).GroupBy(x => x).Select(x => x);

            var listaFiltrada = listaNomes.Distinct().OrderBy(x => x);

            var vetorFiltradoDoubleDistinct = notasAtendimento.Distinct().Average();

            var vetorNotaAtendimento = notasAtendimento.Distinct().Select(x=>x).Sum();


            //Tela
            Console.WriteLine("Lista Filtrada com Distinct:");
            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Nota de do atendimento: " + vetorNotaAtendimento.ToString("F2"));
            Console.WriteLine("Média do atendimento: " +  vetorFiltradoDoubleDistinct.ToString("F2"));
            

            Console.WriteLine();
            Console.WriteLine("Vetor Filtrado com Distinct:");

            foreach(var item in vetorFiltradoDistinct)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Vetor Filtrado com GroupBy");

            foreach (var item in vetorFiltradoGroupBy)
            {
                Console.WriteLine(item.Key);
            }

            Console.ReadLine();
        }
    }
}
