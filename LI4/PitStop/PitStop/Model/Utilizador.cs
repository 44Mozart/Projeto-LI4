using System.Collections.Generic;
namespace Program
{
    public class Utilizador
    {
        public int Username { get; set; }
        public string Nome { get; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public List<int> Pilotosfav { get; set; }
        public List<int> Construtorfav { get; set; }

        public Utilizador(int username, string nome, string pass, string email)
        {
            Username = username;
            Nome = nome;
            Pass = pass;
            Email = email;
            Pilotosfav = new List<int>();
            Construtorfav = new List<int>();
        }

        public bool checkPass(string pass)
        {
            return ((Pass == pass) ? true : false);
        }

    }
}
