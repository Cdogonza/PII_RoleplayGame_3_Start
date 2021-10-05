using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Smeagol enemigo = new Smeagol("EnemyONE");
            Gozilla enemigo3 = new Gozilla("EnemyTWO");
            Archer arquero = new Archer("Debil");
            arquero.AddItem(new Sword());
            Dwarf enano = new Dwarf("Heroe2");       
            enemigo.AddItem(new Sword());
            Encounters Batalla = new Encounters(enemigo,arquero);
            Batalla.AddEnemy(enemigo3);
            Batalla.AddHeroes(enano);
            Batalla.DoEncounters();



            

        }
    }
}
