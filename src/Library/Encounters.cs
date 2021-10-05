using System.Collections.Generic;
using System;
using System.Linq;

namespace RoleplayGame
{
    //En esta clase establesco lista enemigo y heroe para que se vayan agregando para la batalla
    //Como minimo debe de existir un enemigo y un heroe para que hay abatalla
   
    public class Encounters
    {
        public List<Heroes> HeroesList = new List<Heroes>();
        public List<Heroes> DeathHeroesList = new List<Heroes>();
        public List<Enemy> EnemyList = new List<Enemy>();
        public List<Enemy> DeathEnemyList = new List<Enemy>();
        public Encounters(Enemy enemy, Heroes heroes)
        {
            HeroesList.Add(heroes);
            EnemyList.Add(enemy);
        }
         //Luego con los metodos Add se agregan mas enemigos o mas Heroes
        public void AddEnemy(Enemy enemy)
        {
            EnemyList.Add(enemy);
        }
        public void AddHeroes(Heroes heroes)
        {
            HeroesList.Add(heroes);
        }
        //Recogo la cantidad de Enemigos y Heroes de cada lista para saber cuantos hay para atacarse
        public int EnemyQty
        {
            get
            {
            return this.EnemyList.Count();
            }
        }
        public int HeroQty
        {
            get
            {
            return this.HeroesList.Count();
            }
        }        

        //Finalmente se establece la batalla que mientras exista un Heroe y al menos un enemigo se van a estar atacando
        //El encuentro termina cuando no queden mas heroes con vida o enemigos con vida
        public void DoEncounters()
        {
        bool figth= true;
        int FigthRounds=0;
        while (figth)
        {   
            DeathEnemyList.Clear();
            DeathHeroesList.Clear();
            FigthRounds++;
            if (HeroQty == 1)
            {
                foreach (Enemy enemy in EnemyList)
                {
                  HeroesList[0].ReceiveAttack(enemy.AttackValue);
                }
            }else
            {
                for (int i = 0; i < EnemyQty; i++)
                {
                    HeroesList[i].ReceiveAttack(EnemyList[i].AttackValue);
                }
            }
                
            foreach (Heroes Heroe in HeroesList)
            {   
                if (Heroe.Health > 0 )
                {                  
                    foreach (Enemy enemy in EnemyList)
                    {
                        if( enemy.Health>0)
                        {                                           
                            enemy.ReceiveAttack(Heroe.AttackValue);    
                        }else 
                        if (!DeathEnemyList.Contains(enemy))
                        {                                                              
                            DeathEnemyList.Add(enemy);
                            Console.WriteLine($"Enemigo {enemy.Name} eliminado");
                            Heroe.IncVictoriPoints(enemy);
                            if(Heroe.VictoryPointsAcumulate==5)
                            {
                                Heroe.Cure();
                            }
                        }
                       
                    }
                    foreach (Enemy enemy in DeathEnemyList)
                    {
                        EnemyList.Remove(enemy);
                    } 
 
                }else                     
                     if (!DeathHeroesList.Contains(Heroe))
                        {                                                              
                            DeathHeroesList.Add(Heroe);
                            Console.WriteLine($"Heroe {Heroe.Name} eliminado");
                        }        
            }         
            foreach (Heroes heroe in DeathHeroesList)
                    {
                        HeroesList.Remove(heroe);
                    }     
            if(HeroesList.Count == 0)
            {
                Console.WriteLine("La batalla termino porque todos los heroes han muerto");
                figth = false;
            }
            if(EnemyList.Count == 0)
            {
                Console.WriteLine("La batalla termino porque todos los enemigos han muerto");
                figth = false;
            }
        if (FigthRounds == 20)
        {
            figth = false;
            Console.WriteLine("La batalla termino porque superaron el numero de rondas");
        }
        }

        }
    }
}