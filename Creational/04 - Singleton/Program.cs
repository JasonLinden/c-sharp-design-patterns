using _04___Singleton._01___Singleton;

namespace _04___Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // How Singleton can be used.
            HowToUse();
        }

        private static void HowToUse()
        {
            // Call the Singleton's Methods directly
            Singleton_ThreadSafe.Instance.DoStuff();

            // Assign to another variable
            var myObject = Singleton_ThreadSafe.Instance;
            myObject.DoStuff();

            // Pass as a parameter
            SomeOtherMethod(Singleton_ThreadSafe.Instance);
        }

        private static void SomeOtherMethod(
            Singleton_ThreadSafe instance)
        {
            instance.DoStuff();
        }
    }
}
