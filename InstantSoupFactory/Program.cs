using System;

namespace InstantSoupFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factoryA = new SoupWithChickenFactory();
            var soupA = factoryA.createHotSoup();
            var factoryB = new SoupWithBeefFactory();
            var soupB = factoryB.createHotSoup();

            Console.WriteLine(soupB.Pasta());
        }
    }
}
