using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Gandalf = new Wizard("Gandalf");
            Samurai Toyotomi = new Samurai("Toyotomi");
            Ninja Nagato = new Ninja("Nagato");
        }
    }

    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health;

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }
        
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
         
        public Human(string name, int strength, int intelligence, int dexterity, int heal )
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = heal;
        }
         
        public virtual int Attack(Human target)
        {
            target.health -= this.Strength*5;
            return target.health;
        }
    }

    class Wizard : Human {
        public Wizard(string name) : base(name)
        {
            Intelligence = 25;
            health = 50;
        }

        public override int Attack(Human target)
        {
            int dmg = Intelligence*5;
            target.Health -= dmg;
            health += dmg;
            return target.Health;
        }

        public int Heal(Human target)
        {
            int addedHealth = 10*Intelligence;
            target.Health += addedHealth;
            return target.Health;
        }

    }

    class Ninja : Human {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }        
        public override int Attack(Human target)
        {
            int damage = 5*Dexterity;
            target.Health -= damage;
            Random random = new Random();
            if(random.Next(0,10) >= 8 )
            {
                target.Health -= 10;
            }
            return target.Health;
        }
        public int Steal(Human target)
        {
            int stolenHealth = 5;
            target.Health -= stolenHealth;
            health += stolenHealth;
            return health;
        }

    }
    class Samurai : Human {
        public Samurai(string name) : base(name)
        {
            health = 200;
        }       
        public override int Attack(Human target)
        {
            if(target.Health <= 50)
            {
                target.Health = 0;
            }
            else 
            {
                base.Attack(target);
            }
            return target.Health;
        } 

        public int Meditate()
        {
            if (health < 200)
            {
                health = 200;
            }
            return health;
        }
    }

}
