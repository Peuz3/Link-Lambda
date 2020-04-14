using System;
using System.Collections.Generic;
using System.Linq;


namespace _03_LINQ_OBJETO
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Usuario> listaUsuario = new List<Usuario>();

            listaUsuario.Add(new Usuario("João", "joao@gmail.com"));
            listaUsuario.Add(new Usuario("Erica", "erica@hotmail.com"));
            listaUsuario.Add(new Usuario("Cássia", "cassia@gmail.com"));
            listaUsuario.Add(new Usuario("Gilmar", "gilmar@bol.com"));
            listaUsuario.Add(new Usuario("Lauany", "lauanay@gmail.com"));

            var listaUsuarioFiltrada = listaUsuario.Where(x => x.Email.Contains("gmail.com")).OrderBy(x=> x.Nome).Select(x=>x);


            foreach(var item in listaUsuarioFiltrada)
            {
                Console.WriteLine(item.Nome + " - " + item.Email);
            }

            Console.ReadLine();
        }
    }
}
