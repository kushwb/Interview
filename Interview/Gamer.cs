using System;
using System.Collections.Generic;

namespace Interview
{
    public class Gamer
    {
        public Dictionary<string, int> Gamers = new Dictionary<string, int>();

        public int this[string key]
        {
            get { return Gamers[key]; }
            set { Gamers[key] = value; }
        }
        public void GamerAge(string gamer)
        {
            Console.WriteLine(Gamers[gamer]);
        }
    }
}