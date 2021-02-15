using System;
using System.Collections.Generic;
using System.Text;

namespace LoopTester
{
    public class WhileLoop : ILoop
    {
        public void Start(int totalCount)
        {
            while (totalCount > 0)
            {
                Business.DoSomething();
                totalCount--;
            }
        }
    }
}
