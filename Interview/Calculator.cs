using System;
using System.Collections.Generic;

namespace Interview
{
    public class Calculator
    {
        public readonly String test = "test";
        public int number1;
        public int number2;
        public Dictionary<string, int> Gamers = new Dictionary<string, int>();

        public int this[string key]
        {
            get { return Gamers[key]; }
            set { Gamers[key] = value; }
        }
        public Calculator()
        {
            test = "myname";
        }

        public int CalculateSum()
        {
            return number1 + number2;
        }

        public void GamerAge(string gamer)
        {
            Console.WriteLine(Gamers[gamer]);
        }
    }
}