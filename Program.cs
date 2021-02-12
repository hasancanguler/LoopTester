using System;
using System.Diagnostics;

namespace LoopTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sp = new Stopwatch();
            int totalCount = 200_000_000;            
            
            //ILoop looper = new ForLoop();
            ILoop looper = new DoLoop();
            //ILoop looper = new WhileLoop();

            sp.Start();
            looper.Start(totalCount);
            sp.Stop();

            Console.WriteLine(sp.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
