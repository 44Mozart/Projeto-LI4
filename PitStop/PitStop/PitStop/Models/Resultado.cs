using System;
namespace PitStop

{
	public class Resultado
	{
		public int Pontos { get; set; }
		public int Qual { get; set; }
		public int Pos { get; set; }
		public int Volta { get; set; }
		public string Status { get; set; }
		public DateTime Tempo { get; set; }
		public int Piloto { get; set; }
		public int Construtor { get; set; }
		public int Corrida { get; set; }

		public Resultado(int pontos, int q, int p, int v, string s, DateTime t, int pil, int cons, int corrida)
		{
			Pontos = pontos;
			Qual = q;
			Pos = p;
			Volta = v;
			Status = s;
			Tempo = t;
			Piloto = pil;
			Construtor = cons;
			Corrida = corrida;
		}
	}
}
