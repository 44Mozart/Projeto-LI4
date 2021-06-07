using System;
using System.Collections.Generic;

namespace PitStop
{
    public class Corrida
    {
		public int Id { get; set; }
		public string Nome { get; set; }
		public int Voltastotais { get; set; }
		public DateTime Data { get; set; }
		public int CircuitoID { get; set; }
		public List<Resultado> Res { get; set; }


		public Corrida(int id, string nome, int voltastotais, int circuitoID, DateTime data)
		{
			Id = id;
			Nome = nome;
			Voltastotais = voltastotais;
			CircuitoID = circuitoID;
			Data = data;
			Res = new List<Resultado>();
		}
    }
}
