﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class NoSwim : ISwim
    {
        public void Execute()
        {
            Console.WriteLine("Утка не плавает");
        }
    }
}
