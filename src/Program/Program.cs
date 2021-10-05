using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Archer arquero = new Archer("atacado");
            Smegol enemigo = new Smegol("malo",30);
            Console.WriteLine(arquero.Health);
            Console.WriteLine(arquero.VictoryPointsAcumulate);
            Encounters Batalla = new Encounters(enemigo,arquero);

            Batalla.DoEncounters();
             Console.WriteLine(arquero.Health);
            Console.WriteLine(arquero.VictoryPointsAcumulate);


            

        }
    }
}
