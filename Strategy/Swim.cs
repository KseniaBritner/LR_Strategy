﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Swim : ISwim
    {
        public void Execute()
        {
            Console.WriteLine("Утка плавает");
        }
    }
}
