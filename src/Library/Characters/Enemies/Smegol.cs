
namespace RoleplayGame
{
    public class Smegol : Enemy
    {
        public int Vp{get;set;}

        public Smegol (string name, int vp): base (name,vp)
        {
            this.Name = name;
            this.Vp = vp;
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
        }
    }
}