using System;

namespace OOP
{
    public class Character // by default, internal and cannot be accessed outside of the assembly
    {
        public const int MaxHealth = 100;
        public readonly int MaxArmor;

        // public int health = 100; // by default, private and cannot be accessed outside of the class
        // public int Health // properties are always public
        // {
        //     get
        //     {
        //         return health;
        //     }
        //     private set // by default, "set" is public
        //     {
        //         health = value; // "value" is the value that is being set
        //     }
        // }

        // Auto properties:
        public int Health { get; private set; } = 100;

        public void Hit(int damage) // by default, private and cannot be accessed outside of the class
        {
            if (Health < damage)
                damage = Health;
            //health -= damage; 
            Health -= damage; // We can use the property instead of the field.
            // var health = GetHealth() - damage;
            // SetHealth(health);
        }

        // Access modifiers:
        // private: only accessible within the class
        // protected: only accessible within the class and its subclasses
        // internal: only accessible within the same assembly
        // public: accessible everywhere

        // "static" means that the method is not associated with a specific instance of the class
        // but with the class itself.
        // "static" methods can be called without creating an instance of the class


        // Classes cannot be private and protected.
        // Classes can be internal and public.

        // Properties are methods that look like fields.
        // Properties allow us to set access modifiers separately for reading and writing.
        // Properties are always public.
        // Properties are always associated with a specific instance of the class.
        // Properties are defined like this:
        // public int Health // properties are always public
        // {
        //     get
        //     {
        //         return health;
        //     }
        //     private set // by default, "set" is public
        //     {
        //         health = value; // "value" is the value that is being set
        //     }
        // }
        // The "get" keyword is used to get the value of the property.
        // The "set" keyword is used to set the value of the property.
        // The "value" keyword is used to refer to the value that is being set.
        // The "get" and "set" keywords are optional.
        // If we don't define a "set" keyword, the property is read-only.
        // If we don't define a "get" keyword, the property is write-only.

        // During compilation, the property is converted to tww methods:
        // public int GetHealth()
        // {
        //     return health;
        // }
        // private void SetHealth(int value)
        // {
        //     health = value;  
        // }

        // Auto properties:
        // public int Health { get; private set; } = 100;
        // This is equivalent to:
        // private int health = 100;
        // public int Health
        // {
        //     get
        //     {
        //         return health;
        //     }
        //     private set
        //     {
        //         health = value;
        //     }
        // }

        // Oftentimes, "set" is private.
        // This is because we don't want to allow the user to set the value of the property.
        // We want to allow the user to read the value of the property, but not to set it.

        // "Static" keyword:
        // We can declare a field, property, method, or class as "static".
        // "static" means that the field, property, method, or class is not associated with a specific instance of the class
        // but with the class itself.
        // "static" fields, properties, and methods can be called without creating an instance of the class.
        // "static" classes cannot be instantiated.
        // We cannot create an instance of a "static" class.
        // For example, Math class is a "static" class.
        // We cannot create an instance of the Math class. (no reason to do so)
        // We can call the methods of the Math class without creating an instance of the Math class.
        // For example, we can call Math.Sqrt(9) without creating an instance of the Math class.
        // Math.PI and Math.E are "static" fields.
        // We can access them without creating an instance of the Math class.

        // If everything in class is declared as "static",
        // then, usually, the class is declared as "static" as well.

        public static int speed = 10;

        public int GetSpeed()
        {
            return speed;
        }
        public void IncreaseSpeed()
        {
            speed += 10;
        }
        public void DecreaseSpeed()
        {
            speed -= 5;
        }

        public string Race { get; private set; }
        public int Armor { get; private set; }

        // Constructors:
        // Constructors are methods that are called when an instance of the class is created.
        // Name of the constructor is the same as the name of the class.
        // Constructors are always public.
        // Constructors are never inherited.
        // Constructors are never virtual.
        // Constructors are never abstract.
        // Constructors are never static.
        // Constructors are never sealed.
        // Constructors are never overridden.
        // Constructors are never called explicitly.
        // Constructors are called automatically when an instance of the class is created.
        // If we don't define a constructor, the compiler will create a default constructor for us.
        // The default constructor is a parameterless constructor.
        // The default constructor is public.

        public Character()
        {
            Console.WriteLine("Character created.");
            MaxArmor = 100; // read-only
        }
        public Character(string race)
        {
            Console.WriteLine("Character created.");
            Race = race;
            Armor = 30;
            MaxArmor = 100; // read-only
            // MaxHealth = 100; // error because "MaxHealth" is a constant
        }

        public Character(string race, int armor)
        {
            Console.WriteLine("Character created.");
            Race = race;
            Armor = armor;
            MaxArmor = 100; // read-only
        }

        // "const" keyword is used to declare a constant.
        // Constants are always static.
        
        // "readonly" keyword is used to declare a read-only field.
        // We can declare a "readonly" variable in the class.
        // Or we can assign a value to a "readonly" variable in the constructor.
        // With "const" we cannot assign a value to a variable in the constructor.

        // Difference between "const" and "readonly":
        // "const" is a compile-time constant.
        // "readonly" is a run-time constant.

        // We cannot declare class instances as "const".
        // With "readonly" we can declare class instances.
        // With "const" we can only declare primitive types (int, double, string, etc.)
        // With "readonly" we can declare class instances.

    }
}
