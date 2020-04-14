using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LINQ_JOIN
{
    class Livro
    {

        public int Id { get; set; }
        public int AutorId { get; set; }
        public string Titulo { get; set; }
        public string AnoPublicacao { get; set; }

        public Livro(int id, int autorId, string titulo, string anoPublicacao)
        {
            Id = id;
            AutorId = autorId;
            Titulo = titulo;
            AnoPublicacao = anoPublicacao;
        }

        public Livro()
        {
        }
    }
}
