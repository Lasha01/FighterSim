﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterSim
{
    class Stat
    {
        public int base_stat;
        public StatInfo stat;

        public string Name //Metod som hittar en stat med en specifik namn från API
        {
            get
            {
                return stat.name;
            }
            private set { }
        }
    }
}
