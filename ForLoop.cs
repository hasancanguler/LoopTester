﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoopTester
{
    public class ForLoop : ILoop
    {
        public void Start(int totalCount)
        {
            for (int index = totalCount; index > 0; index--)
            {
                Business.DoSomething();
            }
        }
    }
}
