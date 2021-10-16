using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantSoupFactory
{
    class SoupWithChicken : ISoup
    {
        string name = "Chicken Soup";
        public string Pasta()
        {
            return "hmm pasta with chicken soup";
        }
    }
}
