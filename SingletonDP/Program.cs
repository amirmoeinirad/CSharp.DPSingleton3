
// Amir Moeini Rad
// September 2025

// Main Concept: The Singleton Design Pattern
// Version: 3.0

// In this pattern, a class has only one instance.
// This is useful when exactly one object is needed to coordinate actions across the system or application.
// Examples include database connections pool, logging manager, and configuration settings manager.

// In this version, the Lazy class is used.
// The Lazy class is recommended in enterprise apps. It better guarantees lazy initialization.


namespace SingletonDP
{
    public sealed class Singleton
    {                              
        // Since the accessor property 'Instance' is static, it cannot access an instance field.
        // This field provides single instance, thread safety and lazy initialization.
        private static readonly Lazy<Singleton> _instance = new(() => new Singleton());


        // Private default constructor
        // No one can create the Singleton object from outside the class.
        private Singleton()
        {
            Console.WriteLine("Creating the Singleton instance...");
        }

        
        // This property provides a global access point to the Singleton instance.        
        public static Singleton Instance
        {
            get { return _instance.Value; }
        }

        
        public void ShowMessage() => Console.WriteLine("Hello from the Singleton object!\n");
    }


    ///////////////////////////////////////////


    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("The Singleton Design Pattern in C#.NET.");
            Console.WriteLine("---------------------------------------\n");

                      
            Singleton s1 = Singleton.Instance;
            s1.ShowMessage();

            Singleton s2 = Singleton.Instance;
            s2.ShowMessage();

            Console.WriteLine("Are s1 and s2 the same? " + (ReferenceEquals(s1, s2) ? "Yes" : "No"));


            Console.WriteLine("\nDone.");
        }
    }
}
