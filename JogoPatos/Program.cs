using System;

namespace JogoPatos
{
    class Program
    {
        static void Main(string[] args)
        {
        Pato pt = new PatoRuivo();		
		
		Console.WriteLine(pt.Mostrar());
        Console.WriteLine(pt.Nadar());
        Console.WriteLine(pt.ComportamentoPato());
		
        pt.SetComportamento(new VoarFoguete());
		
        Console.WriteLine(pt.ComportamentoPato());
				
		Console.WriteLine("********** \n\n");


		Pato pato2 = new PatoCorredor();
		
        Console.WriteLine(pato2.Mostrar());
		Console.WriteLine(pato2.Corredor());
		Console.WriteLine(pato2.Correr());



		Console.WriteLine("********** \n\n");


		Pato pato3 = new PatoMaratonista();
		Console.WriteLine(pato3.Mostrar());
		Console.WriteLine(pato3.Corredor());
		Console.WriteLine(pato3.Correr());

        }
    }
}
