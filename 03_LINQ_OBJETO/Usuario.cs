namespace _03_LINQ_OBJETO
{
    class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Usuario(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

       public Usuario()
        {
        }
    }
}
