using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantSoupFactory
{
    class HotSoupwithBeef : IHotSoup
    {
        public string HotSauce()
        {
            return "Hot sauce to beef";
        }

        public string Pasta()
        {
            return  "hmm hot pasta with beef soup";
        }
    }
}
