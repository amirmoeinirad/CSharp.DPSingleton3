namespace SingletonDP
{
    public sealed class Singleton
    {
        // This field provides single instance, thread safety and lazy initialization.
        // The lambda is inside the same class and can access the private constructor.
        // The Lazy class just accesses and stores the instance. The lambda is executed by C#.
        // Complete older syntax:
        // private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());
        // Simpler modern syntax:
        private static readonly Lazy<Singleton> _instance = new(() => new Singleton());

        // If the class constructor were public:
        // private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>();
        // or
        // private static readonly Lazy<Singleton> _instance = new();

        private Singleton()
        {
            Console.WriteLine("Creating the Singleton instance...");
        }

        // The global access point to the Singleton instance.        
        public static Singleton Instance
        {
            get => _instance.Value;
        }

        public void ShowMessage() => Console.WriteLine("\nHello from the Singleton object!");
    }
}
