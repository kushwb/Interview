using System;

namespace Interview
{
    public class Calculator
    {
        public readonly String test = "test";
        public int number1;
        public int number2;
        
        public Calculator()
        {
            test = "Myname";
        }

        public int CalculateSum()
        {
            return number1 + number2;
        }
    }
}