﻿using System.Threading;

namespace BreakOutMethod.Dependency
{
    public class Water
    {
        public new string ToString()
        {
            Thread.Sleep(30000);
            return "Water";
        }
    }
}
