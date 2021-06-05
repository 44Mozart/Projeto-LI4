using System;
using System.Collections.Generic;

namespace classes
{
    public class Utilizador
    {
        public int id{get; set; }
        public string nome { get; }
        public string pass { get; set; }
        public string email{get;set;}
        public List<int> pilotosfav{get;set;}
        public List<int> contrutorfav{get;set;}

        public Utilizador(int id, string nome, string pass, string email){
            this.id = id;
            this.nome = nome;
            this.pass = pass;
            this.email = email;
            this.pilotosfav = new List<int>();
            this.construtorfav = new List<int>();
        }

        public bool checkPass(string pass){
            return ((this.pass == pass)? true:false);
        }        

    }
}