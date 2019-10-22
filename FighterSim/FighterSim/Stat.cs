using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterSim
{
    class Stat
    {
        public int base_stat = 0;
        public StatInfo stat;

        public string Name
        {
            get
            {
                return stat.name;
            }
            private set { }
        }
    }
}
