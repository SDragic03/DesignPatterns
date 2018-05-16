using System;

namespace factory_pattern_core
{
    public class BusinessObject : IBusiness
    {
        public void LogicFromBusinessObject()
        {
            Console.WriteLine("Logic from the original business object");
        }
        
    }
}