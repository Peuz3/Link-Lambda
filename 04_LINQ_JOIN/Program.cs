using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LINQ_JOIN
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Autor> listaAutores = new List<Autor>();
            listaAutores.Add(new Autor(1, "JK Rowling"));
            listaAutores.Add(new Autor(2, "George R R Marting"));
            listaAutores.Add(new Autor(3, "Stephen King"));

            List<Livro> listaLivros = new List<Livro>();
            listaLivros.Add(new Livro(1, 3, "It", "1980"));
            listaLivros.Add(new Livro(2, 3, "Outsider", "1990"));
            listaLivros.Add(new Livro(3, 2, "Guerra dos Tronos - A tormenta de espadas", "1993"));
            listaLivros.Add(new Livro(4, 2, "Guerra dos Tronos - A Dança dos Dragões", "1996"));
            listaLivros.Add(new Livro(5, 1, "Harry Potter e o Cálice de Fogo", "1998"));
            listaLivros.Add(new Livro(6, 1, "Harry Potter e o Prisioneiro de Askaban", "1994"));

            var listaJoin = from livros in listaLivros join autor in listaAutores on livros.AutorId equals autor.Id select new { livros, autor};
            
            

            foreach (var listaFiltrada in listaJoin)
            {
                Console.WriteLine("Livro: " + listaFiltrada.livros.Titulo + " || - Autor: " + listaFiltrada.autor.Nome);
            }

            Console.ReadLine();
        }
    }
}
