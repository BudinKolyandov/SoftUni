﻿using PlayersAndMonsters.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.IO
{
    class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
