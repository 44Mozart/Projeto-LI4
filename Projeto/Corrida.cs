using System;
using System.Collections.Generic;
using System.Globalization;

namespace classes
{
	public class Corrida
	{
		public int id{get;set;}
		public string nome{get;set;}
		public int voltastotais{get;set;}
		public DateTime data{get;set;}
		public int circuitoID{get;set;}
		public List<Resultado> res {get;set;}


		public Corrida(int id, string nome, int voltastotais, int circuitoID, DateTime data){
			this.id = id;
			this.nome = nome;
			this.voltastotais = voltastotais;
			this.circuitoID = circuitoID;
			this.data = data;	
			this.res = new List<Resultado>();
		}
	}
}