using System;



namespace Program
{
	class Program { 
		
		public static void Main(string[] args)
        {
			Piloto p1 = new Piloto(1, "Wolfgang", "Mozart", "Portuguesa");
			PitStop pit = new PitStop();
			pit.AdicionaPiloto(p1);
			Console.WriteLine(pit.Piloto.Count);
			pit.lerAPI();
        }
	}
}
