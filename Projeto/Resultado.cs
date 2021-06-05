using System;
using System.Globalization;
using System.Collections.Generic;

namespace classes
{
	public class Resultado
	{
		public int pontos{get;set;}
		public int qual{get;set;}
		public int pos{get;set;}
		public int volta{get;set;}
		public string status{get;set;}
		public DateTime tempo{get;set;}
		public int piloto{get;set;}
		public int construtor{get;set;}
		public int corrida{get;set;}

		public Resultado(int pontos, int q, int p, int v, string s, DateTime t, int pil, int cons, int corrida){
			this.pontos = pontos;
			this.qual = q;
			this.pos = p;
			this.volta = v;
			this.status = s;
			this.tempo = t;
			this.piloto = pil;
			this.construtor = cons;
			this.corrida = corrida;
		}
	}
}