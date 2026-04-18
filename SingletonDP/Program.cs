
// Amir Moeini Rad
// September 2025

// Main Concept: The Singleton Design Pattern
// Version: 3.0

// In this pattern, a class has only one instance and provides a global point of access to it.
// This is useful when exactly one object is needed to coordinate actions across the system or application.
// Examples include database connections pool, logging manager, and configuration settings manager.

// In this version, the Lazy class is used.
// The Lazy class is recommended in enterprise apps. It better guarantees lazy initialization.


namespace SingletonDP
{
    public sealed class Singleton
    {
        // Field 1
        // Private static field (created only once)                
        // Can it be non-static? No, because we need to access it without creating an instance of the class from outside.
        // Furthermore, since the accessor property 'Instance' is staic, it cannot access an instance field.
        // It is private so that it cannot be accessed directly from outside the class.
        private static readonly Lazy<Singleton> _instance = new(() => new Singleton());


        // Private default constructor
        // No one can create the Singleton object from outside the class.
        private Singleton()
        {
            Console.WriteLine("Creating the Singleton instance...");
        }


        // Public property to get the single instance.
        // This property provides a global access point to the Singleton instance.        
        public static Singleton Instance
        {
            get { return _instance.Value; }
        }


        // Example method to demonstrate functionality.
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


            // We cannot create an instance of Singleton directly because its constructor is private.            
            Singleton s1 = Singleton.Instance;
            s1.ShowMessage();

            Singleton s2 = Singleton.Instance;
            s2.ShowMessage();

            Console.WriteLine("Are s1 and s2 the same? " + (ReferenceEquals(s1, s2) ? "Yes" : "No"));


            Console.WriteLine("\nDone.");
        }
    }
}
