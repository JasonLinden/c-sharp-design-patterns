using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Singleton
{
    namespace _01___Singleton
    {
        public class Singleton_ThreadSafe
        {
            // We have a private constructor
            private Singleton_ThreadSafe() { }

            public static Singleton_ThreadSafe Instance
            {
                get
                {
                    return Nested.instance;
                }
            }

            private class Nested
            {
                static Nested() { }

                internal static readonly Singleton_ThreadSafe instance = new Singleton_ThreadSafe();
            }

            public void DoStuff()
            {

            }
        }

        public class Singleton_ThreadSafe_WithLock
        {
            // We have a private constructor
            private Singleton_ThreadSafe_WithLock() { }

            private static readonly object _lock = new object();
            private static Singleton_ThreadSafe_WithLock _instance;

            public static Singleton_ThreadSafe_WithLock Instance
            {
                get
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton_ThreadSafe_WithLock();
                        }
                        return _instance;
                    }
                }
            }

            public void DoStuff()
            {

            }
        }

        public class Singleton_NonThreadSafe
        {
            private static Singleton_NonThreadSafe _instance;

            // We have a private constructor
            private Singleton_NonThreadSafe() { }

            public static Singleton_NonThreadSafe Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton_NonThreadSafe();
                    }

                    return _instance;
                }
            }

            public void DoStuff()
            {

            }
        }
    }
}
