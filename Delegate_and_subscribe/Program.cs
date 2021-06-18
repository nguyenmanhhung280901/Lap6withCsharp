using System;

namespace Delegate_and_subscribe
{
    internal class Program
    {
        delegate void Increment(ref int X);
         static void Add2(ref int x)
        {
            x += 2;
        }
         static void Add3(ref int x)
        {
            x += 3;
        }
        public static void Main(string[] args)
        {
            Increment functionDelegate = Add2;
            functionDelegate += Add3;
            functionDelegate += Add2;
            int x = 5;
            functionDelegate(ref x);
            Console.ReadLine();
        }
    }
}