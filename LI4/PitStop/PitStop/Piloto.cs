using System;
using System.Collections.Generic;

namespace Program
{
    public class Piloto
    {
        public int Id { get; set; }
        public string Nome { get; }
        public string Apelido { get; set; }
        public string Nacionalidade { get; set; }
        public DateTime Datanascimento { get; set; }
        public int Numeroperm { get; set; }
        public List<int> Utilizadorfav { get; set; }
        public List<Resultado> Res { get; set; }

        public Piloto(int id, string nome, string apelido, string nacionalidade)
        {
            Id = id;
            Nome = nome;
            Apelido = apelido;
            Nacionalidade = nacionalidade;
            Utilizadorfav = new List<int>();
            Res = new List<Resultado>();
        }
    }
}
