using System;

namespace OOP
{
    public enum TrafficLight
    {
        // By default, the first value is 0, the second is 1, and so on.
        // Values, by default, are of type int and implicitly assigned values are 0, 1, 2, etc.
        // We can explicitly assign values to the enum members.
        Red,   // 0, by default, but we can explicitly assign it to 0
        Yellow, // 1
        Green // 2
    }

    public enum Race : int
    {
        Elf = 30,
        Orc = 40,
        Human = 20
    }
}