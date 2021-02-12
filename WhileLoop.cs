using System;
using System.Collections.Generic;
using System.Text;

namespace LoopTester
{
    public class WhileLoop : ILoop
    {
        public void Start(int totalCount)
        {
            string compareTest = "";
            while (totalCount > 0)
            {
                //Compare Test
                if (string.IsNullOrEmpty(compareTest))
                {
                    ////Compare Assignment
                    compareTest = string.Empty;
                }
                totalCount--;
            }
        }
    }
}
