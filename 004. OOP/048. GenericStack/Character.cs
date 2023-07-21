using System;

namespace OOP
{
    public class Character
    {
        public Race Race { get; private set; }
        public int Armor { get; private set; }

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
    }
}
