using System;

namespace Interview
{
    public class Parent
    {
        public bool isvalid;
        public void Method1()
        {
            Console.WriteLine("Method1");
        }
        public Parent()
        {
            Console.WriteLine("Parent default constructor");
        }

        public Parent(string arg)
        {
            Console.WriteLine("Parent constructor with parameter");
        }
    }
}