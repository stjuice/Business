using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace ConsoleApplication1
{
    class SingleTone<T>
        where T: new()
    {
        static T obj;

        private SingleTone() { }

        public static void CreateSingleTone()
        {
            if (obj == null)
                obj = new T();
        }
    }
    class Client
    {
        void Main()
        {
            SingleTone<int>.CreateSingleTone();
        }
    }
}