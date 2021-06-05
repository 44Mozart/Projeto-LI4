using System;
using System.Collections.Generic;

namespace classes
{
	public class Circuito
	{
		public int id{get;set;}
		public string nome{get;set;}
		public string pais{get;set;}
		public string localidade{get;set;}
		public float lat{get;set;}
		public float lon{get;set;}


		public Circuito(int id, string nome, string pais, string localidade, float lat, float lon){
			this.id = id;
			this.nome = nome;
			this.pais = pais;
			this.localidade = localidade;
			this.lat = lat;
			this.lon = lon;			
		}
	}
}