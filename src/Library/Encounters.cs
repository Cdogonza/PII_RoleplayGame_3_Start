using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq;

namespace RoleplayGame
{
    public class Encounters
    {
        public List<Heroes> HeroesList = new List<Heroes>();
        public List<Enemy> EnemyList = new List<Enemy>();
        public Encounters(Enemy enemy, Heroes heroes)
        {
            HeroesList.Add(heroes);
            EnemyList.Add(enemy);

        }
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



        public void DoEncounters()
        {
            if (HeroQty == 1)
            {
                foreach (var enemy in EnemyList)
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
            foreach (var Heroe in HeroesList)
            {   
                if (Heroe.Health > 0 )
                {
                    foreach (var enemy in EnemyList)
                    {
                        enemy.ReceiveAttack(Heroe.AttackValue);
                        if( enemy.Health<=0)
                        {
                            Heroe.IncVictoriPoints(enemy);
                        }
                    }
                }
            }   
            int acum=0;
            foreach (var heroes in HeroesList)
            {
            acum += heroes.Health;
            if(acum ==0)
            {
                Console.WriteLine("La batalla termino porque todos los heroes han muerto");
                acum = 0;
            }
            }    
            int acum2=0;
            foreach (var enemy in EnemyList)
            {
            acum2 += enemy.Health;
            if(acum2 ==0)
            {
                Console.WriteLine("La batalla termino porque todos los enemigos han muerto");
                acum2 = 0;
            }
            }    
        }
      

    }
}