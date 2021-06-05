using System;
using System.Collections.Generic;

namespace classes
{
    public class Construtor
    {
        public int id{get; set; }
        public string nome { get; }
        public string nacionalidade { get; set; }
        public List<Resultado> res {get;set;}


        public Construtor(int id, string nome, string nacionalidade){
            this.id = id;
            this.nome = nome;
            this.nacionalidade = nacionalidade;
            this.res = new List<Resultado>();
        }      

    }
}