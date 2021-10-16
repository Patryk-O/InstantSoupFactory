using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantSoupFactory
{
    public class SoupWithChickenFactory : SoupFactory
    {
        public string Name { get; set; }
        public string Meat = "Chicken";
        public IHotSoup createHotSoup()
        {
            Console.WriteLine("Hot Soup with Chicken was created");
            return new HotSoupWithChicken();
        }

        public ISoup createSoup()
        {
            Console.WriteLine("Soup with Chicken was created");
            return new SoupWithChicken();
        }
    }
}
