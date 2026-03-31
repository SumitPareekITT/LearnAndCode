using System;

namespace LSP.Birds
{
    public class Sparrow : FlyingBird
    {
        public override void Eat()
        {
            Console.WriteLine("Sparrow is eating.");
        }

        public override void Fly()
        {
            Console.WriteLine("Sparrow is flying.");
        }
    }
}
