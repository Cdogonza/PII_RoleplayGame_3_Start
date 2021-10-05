using System.Collections.Generic;
namespace RoleplayGame
{
    //La clase Heroes hereda lo que le corresponde a cualquier personaje y a su vez establece el incremento de puntos de
    //victoria cuando mata a un enemigo
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