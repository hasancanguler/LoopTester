using System;
using System.Collections.Generic;
using System.Text;

namespace LoopTester
{
    public class ForLoop : ILoop
    {
        public void Start(int totalCount)
        {
            string compareTest = "";
            for (int index = totalCount; index > 0; index--)
            {
                //Compare Test
                if (string.IsNullOrEmpty(compareTest))
                {
                    ////Compare Assignment
                    compareTest = string.Empty;
                }
            }
        }
    }
}
