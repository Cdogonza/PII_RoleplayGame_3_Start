using System.Text;
namespace RoleplayGame
{
    //La clase Enemy hereda lo que le corresponde a personaje y a su vez establece cosas particulares para 
    //los enemigos, como son le valor de punto de victoria
    public class Enemy : Character
    {
        public int VicPoint{get;set;}
        public Enemy(string name) : base(name)
        {
            this.Name = name;
            this.VicPoint = 1;
        }
    }




}