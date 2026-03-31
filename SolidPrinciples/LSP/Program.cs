using LSP.Birds;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird sparrow = new Sparrow();
            sparrow.Eat();

            Bird ostrich = new Ostrich();
            ostrich.Eat();

            FlyingBird flyingBird = new Sparrow();
            flyingBird.Fly();

            Console.ReadLine();
        }
    }
}
