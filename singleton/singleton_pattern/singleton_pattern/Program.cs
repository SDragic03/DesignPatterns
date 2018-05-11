using System;

namespace singleton_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
//            Singleton instance1 = new Singleton(); // compile error: Cannot access private constructor
//            instance1.PrintDetails("From first instance!");
//            
//            Singleton instance2 = new Singleton(); // compile error: Cannot access private constructor
//            instance2.PrintDetails("From second instance!");
            
            // Assuming Singleton is created from first class by referring to the GetInstance property from the Singleton class
            var fromFirst = Singleton.GetInstance;
            fromFirst.PrintDetails("this is from first!");
            
            var fromSecond = Singleton.GetInstance;
            fromSecond.PrintDetails("this is from second!");
           
            var fromThird = Singleton.GetInstance;
            fromThird.PrintDetails("this is from third!");
            
            var fromFourth = Singleton.GetInstance;
            fromFourth.PrintDetails("this is from fourth!");
           
            Console.ReadLine();
            
            // output:
            // Instances = 1
            // Hello from Singleton, this is from first!
            // Hello from Singleton, this is from second!
            // Hello from Singleton, this is from third!
            // Hello from Singleton, this is from fourth!
        }
    }
}