using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantSoupFactory
{
    public class SoupWithBeefFactory : SoupFactory
    {
        public string Name { get; set; }
        public string Meat = "Chicken";
        public IHotSoup createHotSoup()
        {
            Console.WriteLine("Hot Soup with Beef was created");
            return new HotSoupwithBeef();
        }

        public ISoup createSoup()
        {
            Console.WriteLine("Soup with Beef was created");
            return new SoupWithBeef();
        }
    }
}
