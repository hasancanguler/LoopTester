using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTester
{
    public class ParallelForLoop : ILoop
    {
        public void Start(int totalCount)
        {            
            Parallel.For (0,totalCount, index =>
            {
                Business.DoSomething();
            });
        }
    }
}
