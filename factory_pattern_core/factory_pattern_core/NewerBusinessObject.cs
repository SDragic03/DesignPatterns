using System;

namespace factory_pattern_core
{
    public class NewerBusinessObject : IBusiness
    {
        public void LogicFromBusinessObject()
        {
            Console.WriteLine("Logic from second business object");
        }
    }
}