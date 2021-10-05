using System.Collections.Generic;
namespace RoleplayGame
{
 public class Heroes :Character
 {

     public Heroes(string name) : base (name)
     {
     }

     public int VictoryPointsAcumulate
    {
        get;set;       
    }
    public void IncVictoriPoints(Enemy enemy)
    {
        this.VictoryPointsAcumulate += enemy.VicPoint;
    }
}
}