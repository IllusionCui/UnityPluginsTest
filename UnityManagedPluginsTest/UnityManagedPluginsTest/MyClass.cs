using System;

namespace UnityManagedPluginsTest
{
    public class TestClass
    {
        private int _a = 0;

        public TestClass()
        {
            System.Console.Write("[TestClass TestClass]");
        }

        public TestClass(int a)
        {
            _a = a;
            System.Console.Write("[TestClass TestClass] a = " + a);
        }

        public int GetA() {
            System.Console.Write("[TestClass GetA] a = " + _a);
            return _a;
        }

        public void SetA(int a) {
            _a = a;
            System.Console.Write("[TestClass SetA] a = " + _a);
        }

        public static void StaticFunc() {
            System.Console.Write("[TestClass StaticFunc]");
        }
    }
}

