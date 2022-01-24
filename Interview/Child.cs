using System;

namespace Interview
{
    public class Child : Parent
    {
        
        public Child(string arg):base(arg)
        {
            Console.WriteLine("Child constructor with parameter");
        }
        public void ChildMethod1()
        {
            Console.WriteLine("ChildMethod1");            
        }
    }
}