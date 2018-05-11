using System;

namespace singleton_pattern
{
    // Singleton Design Pattern
    // A creational type pattern that ensures only one object of a particular class is instantiated
    // The single instance is responsible for invoking methods and event of the singleton
    // Advantages of a singleton:
        // Singleton controls concurrent access to the resource
        // It ensures there is only one object available across the application in a controlled state.
    
    // Changed the creation object pattern for this class
    // Sealed resticts the inheritance
    public sealed class Singleton
    {
        private static int counter;
        private static Singleton instance;
        private static readonly object obj = new object();

        // Public property is used to return only one instance of the class
        public static Singleton GetInstance
        {
            get
            {
                if (instance != null) 
                    return instance;
                // Ensuring that only one thread enters the code block and make others wait until the first it done
                // by utlizing lock to ensure thread safety
                lock (obj)
                {
                    if (instance == null)
                        instance = new Singleton();
                }
                return instance;
            }
        }

        // Private constructor ensures that object is not instantiated other than with in the class itself
        private Singleton()
        {
            counter++;
            Console.WriteLine($"Instances = {counter}");
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine("Hello from Singleton, " + message);
        }
    }
}
