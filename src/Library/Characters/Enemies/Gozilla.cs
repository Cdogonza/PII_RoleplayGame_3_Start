
namespace RoleplayGame
{
    public class Gozilla : Enemy
    {
        public Gozilla (string name): base (name)
        {         
            this.AddItem(new Axe());
            this.AddItem(new Armor());
        }
    }
}