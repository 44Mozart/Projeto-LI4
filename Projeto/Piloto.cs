using System;
using System.Collections.Generic;
using System.Globalization;

namespace classes
{
    public class Piloto
    {
        public int id{get; set; }
        public string nome { get; }
        public string apelido { get; set; }
        public string nacionalidade{get;set;}
        public DateTime datanascimento{get;set;}
        public int numeroperm{get;set;}
        public List<int> utilizadorfav{get;set;}
        public List<Resultado> res{get;set;}

        public Piloto(int id, string nome, string apelido, string nacionalidade, int data){
            this.id = id;
            this.nome = nome;
            this.apelido = apelido;
            this.nacionalidade = nacionalidade;
            this.utilizadorfav = new List<int>();
            this.res = new List<Resultado>();
        }
    }
}

