using System;
using System.Collections.Generic;
using System.Text;

namespace LoopTester
{
    public class DoLoop : ILoop
    {
        public void Start(int totalCount)
        {
            do
            {
                Business.DoSomething();
                totalCount--;
            } while (totalCount > 0);
        }
    }
}
