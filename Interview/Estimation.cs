using System;

namespace Interview
{
    public class Estimation : IActivity
    {
        public void Execute()
        {
            Console.WriteLine(nameof(Estimation) + " Activity");
        }
    }
}