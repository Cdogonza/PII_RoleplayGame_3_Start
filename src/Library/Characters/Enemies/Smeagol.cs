
namespace RoleplayGame
{
    public class Smeagol : Enemy
    {
        public Smeagol (string name): base (name)
        {         
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
            this.AddItem(new Armor());
        }
    }
}