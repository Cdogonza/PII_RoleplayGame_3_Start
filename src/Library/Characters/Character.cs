using System.Collections.Generic;
namespace RoleplayGame
{
 public abstract class Character :ICharacter
 {
    private int health = 100;
    
     private List<IItem> items = new List<IItem>();
    protected Character(string name)
        {
            this.Name = name;
        }
    
        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in items)
                {
                    if (item is IDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }
        public void ReceiveAttack(int power)
            {
                if (DefenseValue < power)
                    {
                        Health -= power - DefenseValue;                   
                    }
            }
        public void Cure()
            {
                Health = 100;
            }
        public string Name { get; set; }
        
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }
        public int Health
            {
                get
                    {
                        return this.health;
                    }
                private set
                    {
                        this.health = value < 0 ? 0 : value;
                    }
            }
        public void AddItem(IItem item)
        {
            this.items.Add(item);
        }
        public void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }
 }
}