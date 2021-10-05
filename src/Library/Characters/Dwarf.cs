using System.Collections.Generic;
namespace RoleplayGame
{
    public class Dwarf:Heroes
    {        
        public Dwarf(string name): base (name)
        {
            this.Name = name;            
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
            this.AddItem(new Shield());
            this.AddItem(new Shield());
        }

    }
}      