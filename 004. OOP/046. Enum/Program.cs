using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Character c1 = new Character(Race.Elf);
            Character c2 = new Character(Race.Orc);
            Character c3 = new Character(Race.Human);

            // Enum is a value type
            // In class object creation, where it is necessary to pass a value type, we can pass an enum value.
            // Enum allows us to use strong typing. 
            // And prevents us from passing invalid values while creating an object.

        }
    }
}