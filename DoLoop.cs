using System;
using System.Collections.Generic;
using System.Text;

namespace LoopTester
{
    public class DoLoop : ILoop
    {
        public void Start(int totalCount)
        {
            string compareTest = "";
            do
            {
                //Compare Test
                if (string.IsNullOrEmpty(compareTest))
                {
                    ////Compare Assignment
                    compareTest = string.Empty;
                }
                totalCount--;
            } while (totalCount > 0);
        }
    }
}
