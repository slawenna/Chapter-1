﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 103; i++)

            {

                if (i % 2 == 0) Console.WriteLine(i);

                else Console.WriteLine("-{0}", i);
            }

        }
    }
}
