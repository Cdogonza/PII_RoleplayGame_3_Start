using System.Text;
namespace RoleplayGame
{
    public class Enemy : Character
    {
        public int VicPoint{get;set;}
        public Enemy(string name,int vp) : base(name)
        {
            this.Name = name;
            this.VicPoint = vp;
        }
    }




}