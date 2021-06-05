using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
namespace classes
{

	public class PitStop{


		public virtual Dictionary<int,Utilizador> Utilizador { get; set; }
        public virtual Dictionary<int,Construtor> Construtor  { get; set; }
        public virtual Dictionary<int,Circuito> Circuito { get; set; }
		public virtual Dictionary<int,Piloto> Piloto { get; set; }
        public virtual Dictionary<int,Corrida> Corrida  { get; set; }
        public virtual ICollection<Resultado> Resultado { get; set; }

		public PitStop(){
			this.Utilizador = new Dictionary<int,Utilizador>();
			this.Construtor = new Dictionary<int,Construtor>();
			this.Circuito = new Dictionary<int,Circuito>();
			this.Piloto = new Dictionary<int,Piloto>();
			this.Corrida = new Dictionary<int,Corrida>();
			this.Resultado = new List<Resultado>();
		}

		public static void Main(string[] args){
			var client = new RestClient("http://ergast.com/api/f1/{{year}}/{{round}}/drivers");
			client.Timeout = -1;
			var request = new RestRequest(Method.GET);
			IRestResponse response = client.Execute(request);
			Console.WriteLine(response.Content);
		}

	}
}