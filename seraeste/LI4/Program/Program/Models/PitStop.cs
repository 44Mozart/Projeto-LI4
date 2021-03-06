using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Program.Models;

namespace Program
{
	public class PitStop { 

		public virtual Dictionary<int, Utilizador> Utilizador { get; set; }
		public virtual Dictionary<int, Construtor> Construtor { get; set; }
		public virtual Dictionary<int, Circuito> Circuito { get; set; }
		public virtual Dictionary<int, Piloto> Piloto { get; set; }
		public virtual Dictionary<int, Corrida> Corrida { get; set; }
		public virtual ICollection<Resultado> Resultado { get; set; }

		public PitStop()
		{
			Utilizador = new Dictionary<int, Utilizador>();
			Construtor = new Dictionary<int, Construtor>();
			Circuito = new Dictionary<int, Circuito>();
			Piloto = new Dictionary<int, Piloto>();
			Corrida = new Dictionary<int, Corrida>();
			Resultado = new List<Resultado>();
		}
	}
}
