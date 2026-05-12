// Amir Moeini Rad
// September 2025

// The Singleton Design Pattern
// Version: 3.0

// In this pattern, a class has only one instance.
// This is useful when exactly one object is needed to coordinate actions across the system or application.

// In this version, the Lazy class is used.
// The Lazy class is recommended in enterprise apps. It better guarantees lazy initialization.

namespace SingletonDP
{    
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

            Console.WriteLine("\nAre s1 and s2 the same? " + (ReferenceEquals(s1, s2) ? "Yes" : "No"));
            Console.WriteLine("\nDone.");
        }
    }
}
