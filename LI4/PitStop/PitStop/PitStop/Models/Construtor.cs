using System.Collections.Generic;
namespace PitStop
{
    public class Construtor
    {
        public int Id { get; set; }
        public string Nome { get; }
        public string Nacionalidade { get; set; }
        public List<Resultado> Res { get; set; }


        public Construtor(int id, string nome, string nacionalidade)
        {
            Id = id;
            Nome = nome;
            Nacionalidade = nacionalidade;
            Res = new List<Resultado>();
        }

    }
}
