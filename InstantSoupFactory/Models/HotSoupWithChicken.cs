using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantSoupFactory
{
    class HotSoupWithChicken : IHotSoup
    {
        string name = "HotChicken Soup";
        public string HotSauce()
        {
            return  "Hot sauce to chicken";
        }

        public string Pasta()
        {
            return  "hmm hot pasta with chicken soup";
        }
    }
}
