using System;

namespace Exceptions
{
    public class Character
    {
        public Race Race { get; private set; }
        public int Armor { get; private set; }
        public string Name { get; private set; }
        public int Health { get; private set; } = 100;


        public Character(Race race)
        {
            Console.WriteLine("Character created.");
            Race = race;

            // Armor = (int)race;

            // Or using switch case
            switch (race)
            {
                case Race.Elf:
                    Armor = 30;
                    break;
                case Race.Orc:
                    Armor = 40;
                    break;
                case Race.Human:
                    Armor = 20;
                    break;
                default:
                    throw new ArgumentException("Unknown Race.");
                    // break; // When we throw an exception, we don't need to use break.
                    // Because the code after the throw statement is unreachable.
            }

            Console.WriteLine("Armor: {0}", Armor);
        }

        public Character(string name, int armor)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Name argument cannot be null.");
            }

            if (armor < 0 || armor > 100)
            {
                throw new ArgumentException("Armor must be between 0 and 100.");
                // or throw new ArgumentOutOfRangeException("Armor must be between 0 and 100.");
            }

            this.Armor = armor;
            this.Name = name;
        }

        public void Hit(int damage)
        {
            if (Health == 0)
                throw new InvalidOperationException("Character is dead.");
            // We are throwing an exception when the character is dead.
            // The exception will be caught in the Main method.
            // And it is the duty of outside code to handle the exception.
            // We are just defending our code from invalid input.

            if (damage > Health)
                throw new ArgumentException("Damage cannot be greater than Health.");
                // or throw new ArgumentOutOfRangeException("Damage cannot be greater than Health.");

            if (Health < damage)
                damage = Health;
            Health -= damage;
        }
    }
}
