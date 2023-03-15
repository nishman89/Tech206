using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsApp
{
    public class Method
    {
        public static int GetStones(int totalPounds)
        {
            return totalPounds < 0? throw new ArgumentException("No negative values") : totalPounds / 14;
        }

        public static int GetPounds(int totalPounds)
        {
            return totalPounds < 0 ? throw new ArgumentException("No negative values") : totalPounds % 14;
        }
    }
}
