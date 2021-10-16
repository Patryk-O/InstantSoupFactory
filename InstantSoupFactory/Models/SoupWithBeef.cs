using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantSoupFactory
{
    class SoupWithBeef : ISoup
    {
        string name = "Beef Soup";
        public string Pasta()
        {
            return  "hmm pasta with beef soup";
        }
    }
}
