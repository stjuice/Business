using System;

namespace Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid guid;
            guid = Guid.NewGuid();
            Console.WriteLine(guid);
            Console.WriteLine(guid.ToString("N"));
        }
    }
}
