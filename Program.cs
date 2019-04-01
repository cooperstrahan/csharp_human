using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Jeff = new Human("Jeff");
            Human Dumpling = new Human("Dumpling", 10, 1, 10, 100);
            Dumpling.Attack(Jeff);
            Console.WriteLine(Jeff.Health);
        }
    }

    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
         
        // add a public "getter" property to access 
        public int Health
        {
            get
            {
                return health;
            }
        }
        
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
         
        // Add a constructor to assign custom values to all fields
        public Human(string name, int strength, int intelligence, int dexterity, int heal )
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = heal;
        }
         
        // Build Attack method
        public int Attack(Human target)
        {
            target.health -= this.Strength*5;
            return target.health;
        }
}

}
