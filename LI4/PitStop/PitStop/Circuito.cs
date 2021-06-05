using System;
namespace Program
{
    public class Circuito
    {
        public int Id { get; set; }
		public string Nome { get; set; }
		public string Pais { get; set; }
		public string Localidade { get; set; }
		public float Lat { get; set; }
		public float Lon { get; set; }


		public Circuito(int id, string nome, string pais, string localidade, float lat, float lon)
		{
			Id = id;
			Nome = nome;
			Pais = pais;
			Localidade = localidade;
			Lat = lat;
			Lon = lon;
		}
	}
}
