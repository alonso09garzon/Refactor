﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Process proces = new Process();
            proces.Print(proces.Calculate());

        }
    }
}
