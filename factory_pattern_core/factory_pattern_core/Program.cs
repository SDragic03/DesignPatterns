using System;

namespace factory_pattern_core
{
    class Program
    {
        static void Main(string[] args)
        {
            // hard coded the application to use this class
            // Would have to modify this class if we wanted to change the object
            var obj = new BusinessObject();
             
            Settings.UseOriginal = true;
            // Settings.UseOriginal = false;
            
            // Future changes to constructed objects are now centrally located
            // Using an abstraction, we can change which concrete version gets created,
            // make things less coupled and provide a abstraction layer
            var desiredBusinessObject = BusinessObjectFactory.Create();
            
            desiredBusinessObject.LogicFromBusinessObject();

            Console.ReadKey();
        }
    }
}