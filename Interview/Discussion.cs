using System;

namespace Interview
{
    public class Discussion : IActivity
    {   
        public void Execute()
        {
            Console.WriteLine(nameof(Discussion) + " Activity");
        }
    }
}