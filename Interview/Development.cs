using System;

namespace Interview
{
    public class Development : IActivity
    {
        public void Execute()
        {
            Console.WriteLine(nameof(Development) + " Activity");
        }
    }
}