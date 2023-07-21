using System;

namespace OOP
{
    public class BankTerminal
    {
        protected string id;

        public BankTerminal(string id)
        {
            this.id = id;
        }

        public virtual void Connect() // virtual keyword is used to override the method in the derived class
        {
            Console.WriteLine("Connecting to the bank...");
        }
    }

    public class ModelXTerminal : BankTerminal
    {
        public ModelXTerminal(string id) : base(id)
        {
            // base.id = id;
        }
        public override void Connect() // override keyword is used to override the method in the base class
        {
            base.Connect();
            Console.WriteLine("Connecting to the bank using Model X...");
        }
    }

    public class ModelYTerminal : BankTerminal
    {
        public ModelYTerminal(string id) : base(id)
        {
            // base.id = id;
        }
        public override void Connect() // override keyword is used to override the method in the base class
        {
            Console.WriteLine("Connecting to the bank using Model Y...");
        }
    }
}